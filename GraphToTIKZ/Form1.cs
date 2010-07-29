using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using Antlr.Runtime;
using Antlr.Runtime.Tree;


namespace GraphToTIKZ
{

    public partial class Form1 : Form
    {
        
        TikzGraph G = new TikzGraph();
        Stack<TikzGraph> undos = new Stack<TikzGraph>();
        Stack<TikzGraph> redos = new Stack<TikzGraph>();
        MRUList MRUs = new MRUList(Consts.cMRUFile, Consts.MaxMRU);

        enum cTool {Move=1, AddVert=2, AddEdge=3, AddPath=4, Hand=5};
        cTool curTool = cTool.Move;

        // when a drag operation is started, contains the relative position of the cursor to the nearest marked vertex (=selvert)
        PointD dragOffset=new PointD();
        int selvert = -1;
        // control the display of the selection rectangle
        Point selrectorig, selrectend;
        bool m_showselrect = false;
        bool showselrect
        {
            get { return m_showselrect; }
            set
            {
                if (!m_showselrect && value)
                {
                    bak_unselectedobjs.Clear();
                    foreach (DrawObject o in G.objlist.Values)
                        if (!o.selected)
                            bak_unselectedobjs.Add(o);
                }
                m_showselrect = value;
            }
        }
        // remembers which items were selected (important only when selecting with the selection rectangle while ctrl pressed)
        List<DrawObject> bak_unselectedobjs = new List<DrawObject>();

        // the base resolution (points per cm)
        const int base_pixperunit = 7200/254;//Convert.ToInt32(Consts.ptspertikzunit);
        // the current resolution including the zoomfactor
        int pixelperunit = base_pixperunit;
        // the size, in tikz units (i.e., cm) of the grid drawn
        double rastersize = .5;
        Cursor handopencursor = new Cursor("..\\..\\Resources\\handopen.cur");
        Cursor handclosedcursor = new Cursor("..\\..\\Resources\\handclosed.cur");
        Point mousepos_bak = new Point(); // saves the cursor position for the hand tool, client coordinates of drawme!

        // indicates whether changes (that need to be saved) are made to the graph
        private bool m_lChangesMade = false;
        bool lChangesMade
        {
            get { return m_lChangesMade; }
            set
            {
                m_lChangesMade = value;
                Text = "GraphToTikz: " + m_curFile;
                if (m_lChangesMade)
                    Text += "*";
            }
        }

        bool lUserHasMovedSomething = false;

        bool lprocMuPdfStartedOnce = false;
        bool ImgRecompilationRunning = false;
        private bool m_recompileimgs=false;
        bool recompileimgs
        {
            get 
            {
                return m_recompileimgs; 
            }
            set 
            {
                m_recompileimgs = value;
                if (m_recompileimgs && !ImgRecompilationRunning && chkUseImgs.Checked) 
                    DoImgRecompilation();  
            }
        }
        bool RecompilationRunning = false;
        private bool m_recompile = false;
        bool recompile
        {
            get
            {
                return m_recompile;
            }
            set
            {
                m_recompile = value;
                if (m_recompile && !RecompilationRunning)
                    DoRecompilation();
            }
        }

        // in case radial coordinates are drawn, indicates the center
        // measured in graph units (i.e., including the G.scale)
        PointD radialcenter = new PointD(0, 0);

        // is true when form is closing
        bool WeAreClosing = false;

        // the currently loaded file, =Consts.defaultCurFile if not yet saved
        private string m_curFile = Consts.defaultCurFile;
        public string curFile
        {
            get
            {
                return m_curFile;
            }
            set
            {
                m_curFile = value;
                lChangesMade = lChangesMade; // to set Text
                if (m_curFile != Consts.defaultCurFile)
                    MRUs.Add(m_curFile);
                
            }
        }


        bool lstStyleUpdating = false;
        bool lUpdateSelection = false;
        bool lGraphUpdating = false;

        // the control in which the graph is drawn
        myControl drawme;

        Dictionary<int, KeyValuePair<int, bool>> tempIndToId = new Dictionary<int, KeyValuePair<int, bool>>(); // bool: is it text img (or label)?

        /// <summary>
        /// Rasterizes a point in graph coordinates (including G.scale).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        PointD rasterize(double x, double y) { return rasterize(new PointD(x, y)); }
        PointD rasterize(PointD p)
        {
            if (rastersize == 0) return p; //dangerous, clone()?
            if (chkRadial.Checked)
            {
                return Rasterizer.rasterizePolar(p, radialcenter, rastersize, Convert.ToInt32(8.0F/rastersize));
            }
            else
            {
                return Rasterizer.rasterizeEucl(p, rastersize, rastersize);
            }
        }


        public Form1()
        {
            InitializeComponent();
            drawme = new myControl();
            drawme.BackColor = Color.White;
            //drawme.Left = 0;
            //drawme.Top = 0;
            //drawme.Anchor = AnchorStyles.None;
            drawme.Paint += drawme_Paint;
            drawme.MouseDown += drawme_MouseDown;
            drawme.MouseMove += drawme_MouseMove;
            drawme.MouseUp += drawme_MouseUp;
            drawme.setdbuffer();
            //splitContainer1.Panel1.Controls.Add(drawme);
            drawmepanel.Controls.Add(drawme);

            //Enum.GetValues(typeof(vclass));
            cmbVertexType.DataSource = Enum.GetValues(typeof(vshape));// typeof(vclass)..ToExtendedList<int>();
            cmbDashStyle.DataSource = Enum.GetValues(typeof(TikzDashStyle));
            foreach (int t in Enum.GetValues(typeof(TikzArrowTip))) {
                cmbArrowTail.Items.Add(Consts.TikzArrowTipCodes[t]);
                cmbArrowTip.Items.Add(Consts.TikzArrowTipCodes[t]);
            }

            //cmbVertexType.DisplayMember = "Value";
            //cmbVertexType.ValueMember = "Key";
           
            
            
            // Set event handlers for style property page
            foreach (Control p in flowLPStyleProps.Controls)
                if (p is Panel)
                { // should always be true
                    foreach (Control c in (p as Panel).Controls)
                    {
                        if (c is TextBox || c is ComboBox)
                            c.TextChanged += changed_StyleProperties;
                        else if (c is NumericUpDown)
                            (c as NumericUpDown).ValueChanged += changed_StyleProperties;
                        else if (c is CheckBox)
                            (c as CheckBox).CheckedChanged += changed_StyleProperties;
                    }
                    p.Visible = false;
                }




            // TODO:Move stuff to Form load
        }

        void LoadSettings()
        {

        }

        void SaveSettings()
        {
            MRUs.Save();
            StyleRepo.Save();
        }

        private void OnSelectionchange()
        {
            lUpdateSelection = true;
            // refresh display
            IEnumerable<vertex> selvs = 
                from v in G.objlist.Values
                where ( (v is vertex ) && v.selected )
                select (v as vertex);
            IEnumerable<edge> seles =
                from v in G.objlist.Values
                where ((v is edge) && v.selected)
                select (v as edge);

            if (selvs.Count() == 0)
            {
                foreach (Control c in tabVertex.Controls)
                {
                    c.Enabled = false;
                    if (c is TextBox)
                        c.Text = "";
                    if (c is NumericUpDown)
                        (c as NumericUpDown).Value = 0;
                }
            }
            else
            {
                foreach (Control c in tabVertex.Controls)
                {
                    c.Enabled = true;
                }
                    if (selvs.Count(v => !selvs.First().text.Equals(v.text)) > 0)
                        txtText.Text = "";
                    else txtText.Text = selvs.First().text;
                    if (selvs.Count(v => !selvs.First().label.Equals(v.label)) > 0)
                        txtLabel.Text = "";
                    else txtLabel.Text = selvs.First().label;
                    //if (selvs.Count(v => !selvs.First().labelangle.Equals(v.labelangle)) > 0)
                    numlblpos.Value = selvs.First().labelangle;
                    //else txtText.Text = selvs.First().text;
            }

            if (seles.Count() == 0)
            {
                foreach (Control c in tabEdge.Controls)
                {
                    c.Enabled = false;
                    if (c is TextBox)
                        c.Text = "";
                    if (c is NumericUpDown)
                        (c as NumericUpDown).Value = 0;
                }
            }
            else
            {
                foreach (Control c in tabEdge.Controls)
                {
                    c.Enabled = true;
                }
                if (seles.Count(v => (seles.First().abovelabel != v.abovelabel)) > 0)
                    txtLabelAbove.Text = "";
                else txtLabelAbove.Text = seles.First().abovelabel;
                if (seles.Count(v => (seles.First().belowlabel != v.belowlabel)) > 0)
                    txtLabelBelow.Text = "";
                else txtLabelBelow.Text = seles.First().belowlabel;

                if (seles.Count(v => (seles.First().useinoutangle != v.useinoutangle)) > 0)
                    chkUseInOutAngles.CheckState = CheckState.Indeterminate;
                else
                {
                    //chkUseInOutAngles.CheckState = CheckState.Checked;
                    chkUseInOutAngles.Checked = seles.First().useinoutangle;
                }
                numInAngle.Value = seles.First().inangle;
                numOutAngle.Value = seles.First().outangle;
            }

     /*       if (selvert < 0)
            {
                txtText.Text = "";
                txtText.Enabled = false;
                foreach (RadioButton rb in textposrbs.Values) rb.Enabled = false;
            }
            else
            {
                vertex v = vertices[selvert];
                txtText.Text = v.text;
                txtText.Enabled = true;
                foreach (RadioButton rb in textposrbs.Values) rb.Enabled = true;
                textposrbs[v.pos].Checked = true;
            }
            */
            lUpdateSelection = false;
        }

        private void BeforeGraphChange()
        {
            // Occurs when the graph is about to be modified by the user (not triggered when loading a new graph)
            undos.Push(G.Clone() as TikzGraph);
            redos.Clear();
        }

        private void OnGraphChanged()
        {
            // Occurs when user has changed the graph... not after undo/redo
            if (chkAutoUpdate.Checked)
                recompile = true;
            lChangesMade = true;
            actionUpdateTikzCode(); // for now
        }

        private void chkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoUpdate.Checked)
                recompile = true;
        }

        private void drawme_MouseDown(object sender, MouseEventArgs e)
        {
            drawme.Focus();
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                vertex v;
                PointD location = new PointD(e.Location.X / (double)pixelperunit, e.Location.Y / (double)pixelperunit);
                PointD rasterp = rasterize(location);
                switch (curTool)
                {
                    case cTool.Move:
                        if (G.vertfromxy(location.X, location.Y, out v))
                        {
                            setselvert(v.id, ModifierKeys.HasFlag(Keys.Control));
                            dragOffset = new PointF(e.Location.X - Convert.ToInt32(v.x * pixelperunit * G.scale),
                                                    e.Location.Y - Convert.ToInt32(v.y * pixelperunit * G.scale));
                        }
                        else
                        {
                            setselvert(-1, ModifierKeys.HasFlag(Keys.Control));
                            selrectorig = e.Location;
                            selrectend = e.Location;
                            showselrect = true;
                        }
                        drawme.Invalidate();
                        break;
                    case cTool.AddVert:
 
                        BeforeGraphChange();
                        AddVertexAt(rasterp);
                        OnGraphChanged();
                        drawme.Invalidate();
                        if (!ModifierKeys.HasFlag(Keys.Control))
                            selectTool(cTool.Move);
                        break;
                    case cTool.AddPath:
                        BeforeGraphChange();
                        // create a new vertex at current position
                        v = AddVertexAt(rasterp);
                        // in case some vertex was selected->add an edge
                        if (selvert >= 0)
                            AddEdge(G.objlist[selvert] as vertex, v);
                        OnGraphChanged();
                        drawme.Invalidate();
                        // select either the new point (default) or leave the old selected (ctrl pressed)
                        if (!ModifierKeys.HasFlag(Keys.Control))
                            setselvert(v.id);
                        break;
                    case cTool.AddEdge:
                        if (G.vertfromxy(location.X, location.Y, out v) )
                        {
                            if (selvert < 0)
                            {
                                setselvert( v.id);
                                drawme.Invalidate();
                            }
                            else
                            {
                                BeforeGraphChange();
                                AddEdge(G.objlist[selvert] as vertex, v);

                                if (ModifierKeys.HasFlag(Keys.Shift)) // make a path
                                    setselvert(v.id);
                                else if (!ModifierKeys.HasFlag(Keys.Control))
                                    setselvert( -1);
                                    // otherwise just do nothing -> make a star
                                    
                                OnGraphChanged();
                                drawme.Invalidate();
                            }
                        }
                        else
                        {
                            if (!ModifierKeys.HasFlag(Keys.Control) && !ModifierKeys.HasFlag(Keys.Shift))
                                setselvert(-1);
                            drawme.Invalidate();
                        }
                        break;
                    case cTool.Hand:
                        drawme.Cursor = handclosedcursor;
                        mousepos_bak.X = e.X; mousepos_bak.Y = e.Y;
                        break;
                }
            }
        }

        private void setselvert(int i, bool inaddition=false)
        {
            selvert = i;
            // clears the selection if a vertex becomes selected that was unselected before
            if ( !inaddition && (i<0 || (i>=0 && !G.objlist[i].selected)) )
                G.deselectall();
            if (i >= 0 && G.objlist[i].selected && inaddition)
            {
                selvert = -1;
                G.objlist[i].selected = false;
            }
            if (selvert >= 0)
            {
                G.objlist[i].selected = true;
                DrawObjectStyle dos = G.objlist[i].style;
                //lstStyles.SelectedItem = dos;//[G.objlist[i].style.name].Selected = true;
                lstStyles.FindItemWithText(dos.name).Selected = true;
            }
            OnSelectionchange();
            //UpdateText();
        }

        private void drawme_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.Transform = new System.Drawing.Drawing2D.Matrix(pixelperunit, 0, 0, pixelperunit, 0, 0);

            //g.DrawRectangle(new Pen(Color.Black, 1), 1, 1, 5, 5);
            if (chkRadial.Checked)
                Rasterizer.DrawPolarRaster(g, drawme.Width / (float)pixelperunit, drawme.Height / (float)pixelperunit,
                    (PointF)radialcenter, rastersize, Convert.ToInt32(8.0 / rastersize));
            else
                Rasterizer.DrawEuclRaster(g, drawme.Width / (float)pixelperunit, drawme.Height / (float)pixelperunit, rastersize, rastersize);
            G.Draw(g, 1, chkUseImgs.Checked);
            g.ResetTransform();

            // Show a Selection Rectangle
            if (showselrect && curTool == cTool.Move)
            {
                Pen dashedp = new Pen(Color.Black, 0.5f);
                dashedp.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(dashedp, Math.Min(selrectorig.X, selrectend.X), Math.Min(selrectorig.Y, selrectend.Y), 
                    Math.Abs(selrectend.X - selrectorig.X), Math.Abs(selrectend.Y - selrectorig.Y)); 
            }

        }

        private void drawme_MouseUp(object sender, MouseEventArgs e)
        {
            showselrect = false;
            if (curTool == cTool.Move && lUserHasMovedSomething)
            {
                lUserHasMovedSomething = false;
                OnGraphChanged();
            }
            if (curTool == cTool.Hand)
                drawme.Cursor = handopencursor;
            drawme.Invalidate();

        }

        private void drawme_MouseMove(object sender, MouseEventArgs e)
        {
            if (selvert < 0 && curTool == cTool.Move && e.Button == MouseButtons.Left)
            {
                selrectend = e.Location;
                RectangleF rect = new RectangleF( Math.Min(selrectorig.X, selrectend.X)/(float)pixelperunit,
                    Math.Min(selrectorig.Y, selrectend.Y) / (float)pixelperunit,
                    Math.Abs(selrectend.X - selrectorig.X) / (float)pixelperunit,
                    Math.Abs(selrectend.Y - selrectorig.Y) / (float)pixelperunit);

                // only necessary for selection with crtl pressed
                foreach (DrawObject o in bak_unselectedobjs)
                {
                    o.selected = false;
                }
                //AddStatusLine(bak_unselectedobjs.Count().ToString());
                foreach (DrawObject o in G.objlist.Values)
                {
                    o.selected = o.intersectswith(rect) || (o.selected && ModifierKeys.HasFlag(Keys.Control));
                }
                OnSelectionchange();

                drawme.Invalidate();
            }
            if (selvert >= 0 && curTool == cTool.Move && e.Button==MouseButtons.Left)
            {
                vertex v = G.objlist[selvert] as vertex;
                PointD rasterp = rasterize((e.Location.X - dragOffset.X)/pixelperunit, (e.Location.Y - dragOffset.Y)/pixelperunit);
                double dx = rasterp.X / (G.scale) - v.x, dy = rasterp.Y / (G.scale ) - v.y;

                //if (dx>0) 
                //    dx=dx;
                // set an undo point... but only one undo per drag operation
                if (!lUserHasMovedSomething)
                    BeforeGraphChange();

                foreach (DrawObject o in G.objlist.Values)
                {
                    if (o is vertex && o.selected)
                    {
                        ((vertex)o).x += dx;
                        ((vertex)o).y += dy;
                    }
                }
                //selrectorig = e.Location;
                lUserHasMovedSomething = true;
                drawme.Invalidate();
            }
            if (curTool == cTool.Hand && e.Button == MouseButtons.Left)
            {
                Point p = drawmepanel.AutoScrollPosition;
                drawmepanel.AutoScrollPosition = new Point(-p.X-e.X+mousepos_bak.X,-p.Y - e.Y+mousepos_bak.Y);
            }
            // adjust mouse cursor when over selected items
           /* if (G.GetSelCount() >= 0 && curTool == cTool.Move)
            {
                vertex v;
                if (G.vertfromxy(e.Location.X / (double)pixelperunit, e.Location.Y / (double)pixelperunit, out v)
                        && v.selected)
                    drawme.Cursor = Cursors.SizeAll;
                else drawme.Cursor = Cursors.Arrow;
            }
            */
            
        }

        // pos is in screen coordinates, not involving G.scale
        vertex AddVertexAt(PointD pos)
        {
            vertex v = new vertex();
            v.x = pos.X / G.scale;
            v.y = pos.Y / G.scale;

            // use the currently checked edge style
            foreach (ListViewItem lvi in lstStyles.CheckedItems)
                if (lvi.Checked && lvi.Group.Name == "V")
                {
                    v.style = G.styles[lvi.Text];
                }
            if (v.style == null)
                throw new Exception("no style selected");

            /*if (cstyle != "")
                v.style = G.styles[cstyle];
            else if (lstStyles.SelectedItems.Count > 0 && getselstyle().type == DOType.V)
                v.style = getselstyle();
            else
            {
                v.style = G.GetFirstStyle(DOType.V); //[lstStyles.Items[0].Text]; //TODO:Achtung
            }
            */
            G.AddObject(v);
            return v;
        }

        edge AddEdge(vertex fromv, vertex tov)
        {
            // add an edge
            edge ed = new edge();
            ed.from = fromv;
            ed.to = tov;
            // use the currently checked edge style
            foreach (ListViewItem lvi in lstStyles.CheckedItems)
                if (lvi.Checked && lvi.Group.Name == "E")
                {
                    ed.style = G.styles[lvi.Text];
                }
            if (ed.style == null)
                throw new Exception("no style selected");

            // for tadpole edge, use in/out angles
            if (fromv == tov)
            {
                ed.useinoutangle = true;
                ed.inangle = 135;
                ed.outangle = 45;
            }

            G.AddObject(ed);
            return ed;
        }

        private void cmdGenCode_Click(object sender, EventArgs e)
        {
            txtCode.Text = G.getTikzString();
        }

       /* private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            rastersize = Double.Parse(cmbGridsize.Text);
            drawme.Invalidate();
        }*/

        private void rbMove_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton rb = (ToolStripButton)sender;
            if (rb.Checked)
            {
                setselvert(-1);
                int t = Int32.Parse((string)rb.Tag);
                curTool = (cTool)t;
                drawme.Invalidate();
            }
        }

        private void change_GraphProperties(object sender, EventArgs e)
        {
            if (!lGraphUpdating)
            {
                G.cx = (double)numWidth.Value;
                G.cy = (double)numHeight.Value;
                G.scale = (double)numScale.Value;

                drawme.Width = Convert.ToInt32(G.cx * G.scale * pixelperunit);
                drawme.Height = Convert.ToInt32(G.cy * G.scale * pixelperunit);
                drawme.Invalidate();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            // Start with a new graph
            LoadSettings();

            ChangeCurrentGraph(new TikzGraph());

            //RefreshStyleList();
            //RefreshStyleDisplay();

            setselvert(-1);

            AddStatusLine("Welcome to GraphToTikz");
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changed_VertexOrEdgeProperties(object sender, EventArgs e)
        {
            if (lUpdateSelection) return;
            // Update selection properties
            foreach (DrawObject o in G.objlist.Values)
                if (o.selected)
                    if (o is vertex)
                    {
                        vertex v = o as vertex;
                        if (sender == txtText)
                            v.text = txtText.Text;
                        if (sender == txtLabel)
                            v.label = txtLabel.Text;
                        if (sender == numlblpos)
                            v.labelangle = Convert.ToInt32(numlblpos.Value);
                        
                    }
                    else if (o is edge)
                    {
                        edge ed = o as edge;
                        if (sender == txtLabelAbove)
                            ed.abovelabel = txtLabelAbove.Text;
                        if (sender == txtLabelBelow)
                            ed.belowlabel = txtLabelBelow.Text;
                        if (sender == chkUseInOutAngles)
                            ed.useinoutangle = chkUseInOutAngles.Checked;
                        if (sender == numInAngle)
                            ed.inangle = Convert.ToInt32(numInAngle.Value);
                        if (sender == numOutAngle)
                            ed.outangle = Convert.ToInt32(numOutAngle.Value);
                    }

            drawme.Invalidate();
        }

        /// <summary>
        /// Sets position and size of the container in which the graph is drawm (=drawme)
        /// </summary>
        void UpdatedrawmePosition()
        {
            drawme.Width = Convert.ToInt32(G.cx * G.scale * pixelperunit);
            drawme.Height = Convert.ToInt32(G.cy * G.scale * pixelperunit);

            CenterDrawme();
        }
        void CenterDrawme()
        {
            // center control
            if (drawme.Width >= drawme.Parent.Width)
                drawme.Left = 0;
            else
                drawme.Left = (drawme.Parent.Width - drawme.Width) / 2;
            if (drawme.Height >= drawme.Parent.Height)
                drawme.Top = 0;
            else
                drawme.Top = (drawme.Parent.Height - drawme.Height) / 2;
        }

        private void cmbZoom_TextChanged(object sender, EventArgs e)
        {
            string z = cmbZoom.Text;
            if (z[z.Length-1] == '%')
                z = z.Remove(z.Length - 1);
            int zoomlevel;
            if (Int32.TryParse(z, out zoomlevel))
            {
                pixelperunit = base_pixperunit * zoomlevel / 100;
                UpdatedrawmePosition();
                drawme.Invalidate();
            }
        }

        private void chkRadial_CheckedChanged(object sender, EventArgs e)
        {
            if (G.GetSelCountV() >= 1)
            {
                vertex v;
                if (selvert >= 0)
                    v = G.objlist[selvert] as vertex;
                else
                    v = (vertex)G.objlist.Values.First(kvp => (kvp is vertex && kvp.selected));
                radialcenter.X = v.x*G.scale;
                radialcenter.Y = v.y*G.scale;
            }
            else
            {
                radialcenter.X = G.cx * G.scale / 2;
                radialcenter.Y = G.cy * G.scale / 2;
            }
            drawme.Invalidate();
        }

        private void numGridSize_ValueChanged(object sender, EventArgs e)
        {
            double d;
            if (Double.TryParse(cmbGridsize.Text, out d))
            {
                rastersize = d;
                drawme.Invalidate();
            }
        }

        private void lstStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshStyleDisplay();
        }
        void RefreshStyleList()
        {
            lstStyles.Items.Clear();
            lstStyles.Groups.Add("V", "Vertex Styles");
            lstStyles.Groups.Add("E", "Edge Styles");
            lstStyles.Groups.Add("U", "Generic Styles");
            foreach (DrawObjectStyle dos in G.styles.Values)
            {
                //lstStyles.Items.Add(dos.name, dos.name, 0);
                ListViewItem lvi = lstStyles.Items.Add(dos.name);
                //lvi.SubItems.Add(dos.type.ToString());
                lvi.Group = lstStyles.Groups[dos.type.ToString()];

                // Check first Item in every group
                if (lvi.Group.Items.Count == 1)
                    lvi.Checked = true;
            }
            RefreshStyleDisplay();
        }
        void RefreshStyleDisplay()
        {
            lstStyleUpdating = true;

            if (lstStyles.SelectedItems.Count == 0)
            {
                
                //tabVStyle.Hide();
                //tabEStyle.Hide();
                
                 foreach (Control c in flowLPStyleProps.Controls)
                    if (c is Panel)
                    {
                        c.Visible = false;
                    }
                 
            }
            else
            {
                DrawObjectStyle dos = getselstyle();
                foreach (Control c in flowLPStyleProps.Controls)
                    if (c is Panel)
                    {
                        c.Visible = (c.Tag as string).Contains(dos.type.ToString());
                    }
                //tabVStyle.Show();
                    //else dos = new DrawObjectStyle();

                    /*       foreach (Control c in tabVStyle.Controls)
                           {
                               if (!(c is Label))
                                   c.Enabled = l;
                           }*/

                txtName.Text = dos.name;
                numInner.Value = (decimal)dos.innersep;
                numOuter.Value = (decimal)dos.outersep;
                txtExtra.Text = dos.extraformat;
                numMinsize.Value = (decimal)dos.minimumsize;
                numLineWidth.Value = (decimal)dos.LineWidth;

                cmdDraw.BackColor = dos.draw;
                cmdFill.BackColor = dos.fill;

                chkDraw.Checked = dos.ldraw;
                chkFill.Checked = dos.lfill;
                chkShowX.Checked = dos.showeditX;

                cmbVertexType.SelectedIndex = (int)dos.shape;
                cmbDashStyle.SelectedIndex = (int)dos.dashstyle;
                cmbArrowTip.SelectedIndex = (int)dos.toTip;
                cmbArrowTail.SelectedIndex = (int)dos.fromTip;

            }
            lstStyleUpdating = false;
        }

        private void cmdDraw_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = cmdDraw.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cmdDraw.BackColor = colorDialog1.Color;
                UpdateSelStyle();
                //((DrawObjectStyle)lstStyles.SelectedItem).draw = colorDialog1.Color;
            }
        }

        private void cmdFill_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = cmdFill.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cmdFill.BackColor = colorDialog1.Color;
                UpdateSelStyle();
            }
        }

        private void changed_StyleProperties(object sender, EventArgs e)
        {
            UpdateSelStyle();
        }
        void UpdateSelStyle()
        {
            if (lstStyles.SelectedItems.Count < 1 || lstStyleUpdating) return;
            DrawObjectStyle dos = getselstyle();
            dos.draw = cmdDraw.BackColor;
            dos.fill = cmdFill.BackColor;
            dos.ldraw = chkDraw.Checked;
            dos.lfill = chkFill.Checked;
            dos.showeditX = chkShowX.Checked;
            dos.extraformat = txtExtra.Text;
            dos.innersep = (float)(numInner.Value);
            dos.outersep = (float)(numOuter.Value);
            dos.shape = (vshape)cmbVertexType.SelectedValue;
            dos.minimumsize = Convert.ToInt32(numMinsize.Value);
            dos.LineWidth = (float)(numLineWidth.Value);
            dos.fromTip = (TikzArrowTip)cmbArrowTail.SelectedIndex;
            dos.toTip = (TikzArrowTip)cmbArrowTip.SelectedIndex;
            dos.dashstyle = (TikzDashStyle)cmbDashStyle.SelectedIndex;
            drawme.Invalidate();
            if (chkAutoUpdate.Checked)
                recompile = true;
        }


       
        private void button4_Click_1(object sender, EventArgs e)
        {
            Point p = drawmepanel.AutoScrollPosition;
            drawmepanel.AutoScrollPosition = new Point(-p.X+100,-p.Y+100);//p.X + e.X - mousepos_bak.X, p.Y + e.Y - mousepos_bak.Y);
            //mousepos_bak.X = e.X; mousepos_bak.Y = e.Y;

            return;
            drawme.Focus();
            AddStatusLine("Hallo Welt111", false);


            return;
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo myProcessStartInfo = new System.Diagnostics.ProcessStartInfo("latex"); //"ipconfig");
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;
            myProcessStartInfo.Arguments = "-quiet temp_preview.tex";
            myProcess.StartInfo = myProcessStartInfo;

            myProcess.Start();
            myProcess.WaitForExit();
            StreamReader myStreamReader = myProcess.StandardOutput;
            // Read the standard output of the spawned process.

            string myString = myStreamReader.ReadToEnd();
            txtCode.AppendText(myString);
            myProcess.Close();

            return;
            DoImgRecompilation();

            return;
            //string s = ;
            //TikzGraph t = new TikzGraph();
            //t.parseTikzString(txtCode.Text);
            tikzgrammarLexer lex = new tikzgrammarLexer(new ANTLRStringStream(txtCode.Text));
            CommonTokenStream tokens = new CommonTokenStream(lex);

            tikzgrammarParser parser = new tikzgrammarParser(tokens);

            try
            {
                //tikzgrammarParser.expr_return r =
                parser.tikzpicture();
                //CommonTree t = (CommonTree)r.Tree;
                //Console.WriteLine(t.ToStringTree());

                //CommonTreeNodeStream nodes = new CommonTreeNodeStream(t);
                //tstgrtree walker = new tstgrtree(nodes);
                //Console.WriteLine(walker.expr());
                MessageBox.Show("Parsed: " + parser.tres.scale + " " + parser.tres.styles.Count + String.Join(" ",parser.tres.styles.Keys) );
                txtCode.BackColor = parser.tres.styles["mystyle"].fill;
            }
            catch (RecognitionException ex)
            {
                MessageBox.Show("Failed to Parse: " + ex.StackTrace);
                //Console.Error.WriteLine(e.StackTrace);
            }
            //Console.ReadLine();

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openRecentItemClicked(object sender, EventArgs e)
        {
            if (!TryDisposeGraph())
                return;
            LoadFile(sender.ToString());
        }

        private void LoadFile(string cFile)
        {
            if (!File.Exists(cFile))
            {
                MessageBox.Show("Error: File not found: " + cFile, "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Stream stream = File.Open(cFile, FileMode.Open);
            try
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                TikzGraph newG = (TikzGraph)bFormatter.Deserialize(stream);
                curFile = cFile;
                ChangeCurrentGraph(newG);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: Could not load " + cFile+". Is it in the correct format?",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                stream.Close();
            }
        }

        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            undoToolStripMenuItem1.Enabled = undos.Count > 0;
            redoToolStripMenuItem1.Enabled = redos.Count > 0;

            // Update MRU list
            openRecentToolStripMenuItem.DropDownItems.Clear();
            if (MRUs.Count > 0)
            {
                foreach (string s in MRUs.FileNames)
                {
                    openRecentToolStripMenuItem.DropDownItems.Add(s, null, openRecentItemClicked);
                }
            }
            else
            {
                ToolStripItem t = openRecentToolStripMenuItem.DropDownItems.Add("<None>");
                t.Enabled = false;
            }
        }

        private DrawObjectStyle getselstyle()
        {
            return G.styles[lstStyles.SelectedItems[0].Text]; //(DrawObjectStyle)lstStyles.SelectedItem;
        }
        private bool isstyleselected()
        {
            return (lstStyles.SelectedItems.Count>0);//(lstStyles.SelectedIndex >= 0);
        }

        void RefreshGraphTabpage()
        {
            lGraphUpdating = true;
            numScale.Value = (decimal)G.scale;
            numWidth.Value = (decimal)G.cx;
            numHeight.Value = (decimal)G.cy;
            lGraphUpdating = false;
        }
        private bool ChangeCurrentGraph(TikzGraph newG, bool ClearUndos = true)
        {
            //if (!TryDisposeGraph())
            //    return false;
            G = newG;
            if (ClearUndos)
            {
                undos.Clear();
                redos.Clear();
            }
            setselvert(-1);
            RefreshStyleList();
            RefreshStyleDisplay();
            RefreshGraphTabpage();
            UpdatedrawmePosition();
            drawme.Invalidate();
            return true;
        }

        bool SaveCurFile(bool saveas = false)
        {
            if (curFile != Consts.defaultCurFile)
                saveFileDialog1.FileName = curFile;
            if (curFile == Consts.defaultCurFile || saveas)
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                    return false;
                else curFile = saveFileDialog1.FileName;

            }

            Stream stream = File.Open(curFile, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, G);
            stream.Close();
            lChangesMade = false;
            AddStatusLine("Graph saved to file " + curFile + ".");
            return true;
        }


        private bool TryDisposeGraph()
        {
            if (lChangesMade)
            {
                switch (MessageBox.Show("Save changes to " + curFile + "?", "Changes need to be saved",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    case (DialogResult.Yes):
                        if (!SaveCurFile()) return false;
                        break;
                    case (DialogResult.Cancel):
                        return false;
                }
            }
            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lChangesMade)
                if (!TryDisposeGraph())
                {
                    e.Cancel = true;
                }

            if (lprocMuPdfStartedOnce && !procMuPdf.HasExited)
                procMuPdf.Kill();
            SaveSettings();

            WeAreClosing = true;
        }

        void DoRecompilation()
        {
            if (!File.Exists(Consts.cTempFile + ".fmt"))
            {
                AddStatusLine("Generating precompiled headers....");  // TODO: move to GeneratePrecompiledHeaders
                Helper.GeneratePrecompiledHeaders();
                return;
            }

            recompile = false;
            RecompilationRunning = true;

            // save into temporary textfile
            StreamWriter s = new StreamWriter(Consts.cTempFile+".tex");
            s.WriteLine(@"%&" + Consts.cTempFile);
            s.WriteLine(@"\pdfpageattr{/MediaBox [0 0 " + Convert.ToInt32(G.cx * G.scale * Consts.ptspertikzunit) + " "
                                                        + Convert.ToInt32(G.cy * G.scale * Consts.ptspertikzunit) + "]}");
            s.WriteLine(@"\begin{document}");
            s.WriteLine(@"\thispagestyle{empty}");
            s.WriteLine(@"\mathindent0cm \parindent0cm");
            s.WriteLine(@"not seen");
            s.WriteLine(@"\vfill");
            s.WriteLine(G.getTikzString(true));
            s.WriteLine(@"\end{document}");
            s.Close();

            // call pdflatex
            //procPdfLatex.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            procPdfLatex.StartInfo.Arguments = "-quiet "+Consts.cTempFile + ".tex";
            AddStatusLine("Compiling document for preview: " + procPdfLatex.StartInfo.FileName + " " + procPdfLatex.StartInfo.Arguments);
            procPdfLatex.Start();
        }

        private void cmdPreview_Click(object sender, EventArgs e)
        {
            RefreshMuPdfDisplay(true);
            DoRecompilation();
        }

        private void setLatexPathToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void procLatex_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            txtCode.AppendText(e.Data + "\r\n");
        }

        private void procPdfLatex_Exited(object sender, EventArgs e)
        {
            // open file in pdf reader
            if (procPdfLatex.ExitCode == 0)
            {
                AddStatusLine("pdflatex compilation successful");
                RefreshMuPdfDisplay();
            }
            else
            {
                StreamReader s = procPdfLatex.StandardOutput;
                AddStatusLine("Error: pdflatex finished with exit code " + procPdfLatex.ExitCode, true);
                AddStatusLine("Error(s): " + s.ReadToEnd(), true);
                s.Close();
            }
            RecompilationRunning = false;
            recompile = recompile; // restart compilation if necessary
            //System.Diagnostics.Process p = new System.Diagnostics.Process();
            //p.StartInfo.FileName = "mupdf";
            //p.StartInfo.Arguments = cTempFile + ".pdf";
            //p.Start();
        }

        public delegate int Callback(IntPtr hWnd, int lParam);
        public int EnumChildGetValue(IntPtr hWnd,int lParam)
        {
            Helper.SendMessage(hWnd, 0x102, Convert.ToInt32('r'), 1); // 102=WM_CHAR
            return 1;
        }

        void RefreshMuPdfDisplay(bool lBringToFront=false)
        {
            if (!lprocMuPdfStartedOnce || procMuPdf.HasExited)
            {
                procMuPdf.StartInfo.Arguments = Consts.cTempFile + ".pdf";
                procMuPdf.Start();
                lprocMuPdfStartedOnce = true;
            }
            else
            {
                // send refresh key ("r")
                if (procMuPdf.MainWindowHandle != IntPtr.Zero)
                {
                    //SetForegroundWindow(procMuPdf.MainWindowHandle);
                    //SendKeys.Send("r");
                    //procMuPdf.StandardInput.WriteLine("r");
                    //SetForegroundWindow(this.Handle);
                    // SendMessage(procMuPdf.MainWindowHandle, 0x100, 0x52,0);
                    Callback myCallBack = new Callback(EnumChildGetValue);
                    if(procMuPdf.MainWindowHandle == IntPtr.Zero)
                    {
                        MessageBox.Show("Please Start Calling Window Application");
                    }
                    else
                    {
                        Helper.EnumChildWindows(procMuPdf.MainWindowHandle, myCallBack, 0);
                    }

                    if (lBringToFront)
                        Helper.SetForegroundWindow(procMuPdf.MainWindowHandle);
                }
                else
                    AddStatusLine("Error: mupdf window not found", true);
            }


        }

        private void procLatex_Exited_1(object sender, EventArgs e)
        {
            if (procLatex.ExitCode == 0)
            {
                // run dvipng
                int density = Consts.TikzImgResolution; //Convert.ToInt32(pixelperunit * 72 / TikzGraph.ptspertikzunit);
                procDvipng.StartInfo.Arguments = "-T tight -bg transparent -D " + density + " " + Consts.cTempImgFile;
                AddStatusLine("Creating images: " + procDvipng.StartInfo.FileName + " " + procDvipng.StartInfo.Arguments);
                procDvipng.Start();
            }
            else
            {
                StreamReader s = procLatex.StandardOutput;
                AddStatusLine("Latex Error (exit code" + procLatex.ExitCode + ")", true);//: \r\n" + s.ReadToEnd() + "\r\n");
                s.Close();
                ImgRecompilationRunning = false;
            }
        }

        private void procDvipng_Exited(object sender, EventArgs e)
        {
            if (procDvipng.ExitCode == 0)
            {
                // retrieve images
                foreach (KeyValuePair<int, KeyValuePair<int, bool>> kv in tempIndToId)
                {
                    string cFile = Consts.cTempImgFile + kv.Key + ".png";
                    FileStream fs = new FileStream(cFile, FileMode.Open);
                    Image img = Image.FromStream(fs);
                    fs.Close();
                    if (kv.Value.Value)
                        (G.objlist[kv.Value.Key] as vertex).img_text = img;
                    else (G.objlist[kv.Value.Key] as vertex).img_label = img;
                }
                drawme.Invalidate();
                AddStatusLine("Image generation successful");
            }
            else
            {
                StreamReader s = procDvipng.StandardOutput, serr = procDvipng.StandardError;
                AddStatusLine("Dvipng Error(s): \r\n" + s.ReadToEnd() +  "\r\n"+ serr.ReadToEnd() +"\r\n", true);
                s.Close();
                serr.Close();

            }
            ImgRecompilationRunning = false;
        }

        void AddStatusLine(string text, bool lError = false)
        {
            txtStatus.Select(txtStatus.Text.Length, 0);
            if (lError)
                txtStatus.SelectionColor=Color.Red;
            else
                txtStatus.SelectionColor = Color.Black;
            txtStatus.AppendText("\r\n"+text);
            txtStatus.ScrollToCaret();
        }

        private void toolSelector_Click(object sender, EventArgs e)
        {
            ToolStripButton rb = (ToolStripButton)sender;
            int t = Int32.Parse((string)rb.Tag);
            selectTool((cTool)t);
        }

        void selectTool(cTool tool)
        {
            // Select the apropriate tool
            cmdSelectTool.Checked = (tool == cTool.Move);
            cmdVertexTool.Checked = (tool == cTool.AddVert);
            cmdEdgeTool.Checked = (tool == cTool.AddEdge);
            cmdPathTool.Checked = (tool == cTool.AddPath);
            cmdHandTool.Checked = (tool == cTool.Hand);

            if (curTool != tool)
            {
                setselvert(-1);
                curTool = tool;
                if (tool == cTool.Hand)
                    drawme.Cursor = handopencursor;
                else
                    drawme.Cursor = Cursors.Default;
                drawme.Invalidate();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            cmbZoom.SelectedIndex = Math.Max(cmbZoom.SelectedIndex-1, 0);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cmbZoom.SelectedIndex = Math.Min(cmbZoom.SelectedIndex + 1, cmbZoom.Items.Count - 1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        void DoImgRecompilation()
        {
            if (!File.Exists(Consts.cTempImgFile + ".fmt") )
            {
                Helper.GeneratePrecompiledHeaders();
                return;
            }
            ImgRecompilationRunning = true;
            recompileimgs = false;
            tempIndToId.Clear();
            StreamWriter s = new StreamWriter(Consts.cTempImgFile + ".tex");
            s.WriteLine(@"%&" + Consts.cTempImgFile);
            s.WriteLine(@"\begin{document}");
            s.WriteLine(@"\thispagestyle{empty}");
            s.WriteLine(@"\pagestyle{empty}");
            s.WriteLine(@"\mathindent0cm \parindent0cm");
            int count = 1;
            foreach (DrawObject o in G.objlist.Values)
                if (o is vertex)
                {
                    vertex v = o as vertex;
                    if (v.text != "")
                    {
                        s.WriteLine(v.text);
                        s.WriteLine(@"\newpage");
                        tempIndToId.Add(count++, new KeyValuePair<int, bool>(v.id, true));
                    }
                    if (v.label != "")
                    {
                        s.WriteLine(v.label);
                        s.WriteLine(@"\newpage");
                        tempIndToId.Add(count++, new KeyValuePair<int, bool>(v.id, false));
                    }
                }
            s.WriteLine(@"\end{document}");
            s.Close();

            procLatex.StartInfo.Arguments = "-quiet " + Consts.cTempImgFile + ".tex";
            AddStatusLine("Compiling for image generation: " + procLatex.StartInfo.FileName + " " + procLatex.StartInfo.Arguments);
            procLatex.Start();

        }

        private void txtText_Leave(object sender, EventArgs e)
        {
            recompileimgs = true;
        }

        private void chkUseImgs_CheckedChanged(object sender, EventArgs e)
        {
            recompileimgs = chkUseImgs.Checked;
            drawme.Invalidate();
        }



        #region actionHandlers

        private void action_UpdateTikzCode(object sender, EventArgs e)
        {
            actionUpdateTikzCode();
        }

        private void action_Copy(object sender, EventArgs e)
        {
            actionCopy();
        }

        private void action_Paste(object sender, EventArgs e)
        {
            actionPaste();
        }

        private void action_NewFile(object sender, EventArgs e)
        {
            actionNewFile();
        }

        private void action_DeleteSelection(object sender, EventArgs e)
        {
            actionDeleteSelection();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void action_DeleteStyle(object sender, EventArgs e)
        {
            actionDeleteStyle();
        }

        private void action_NewStyle(object sender, EventArgs e)
        {
            if (sender == cmdNewEStyle || sender == addEdgeStyleToolStripMenuItem )
                actionNewStyle(DOType.E);
            else actionNewStyle(DOType.V);
        }
        private void action_AddStyleToRepo(object sender, EventArgs e)
        {
            actionAddStyleToRepo();
        }

        private void action_OpenFile(object sender, EventArgs e)
        {
            actionOpenFile();
        }
        private void action_SaveFile(object sender, EventArgs e)
        {
            actionSaveFile();
        }

        private void action_SaveFileAs(object sender, EventArgs e)
        {
            actionSaveFileAs();
        }

        private void action_AssignStyle(object sender, EventArgs e)
        {
            actionAssignStyle();
        }

        private void action_Undo(object sender, EventArgs e)
        {
            actionUndo();
        }

        private void action_Redo(object sender, EventArgs e)
        {
            actionRedo();
        }

        private void action_ChangeStyleName(object sender, EventArgs e)
        {
            actionChangeStyleName();
        }
        private void action_ExportToClipboard(object sender, EventArgs e)
        {
            actionExportToClipboard();
        }

        private void action_ImportFromClipboard(object sender, EventArgs e)
        {
            actionImportFromClipboard();
        }

        private void action_ShowStyleRepo(object sender, EventArgs e)
        {
            actionShowStyleRepo();
        }

        #endregion

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            drawme.Invalidate();
        }


        private void tabControl2_Click(object sender, EventArgs e)
        {
            actionUpdateTikzCode();
        }

        private void action_refreshPreviews(object sender, EventArgs e)
        {
            actionRefreshPreviews();
        }

        private void contextMenuStyles_Opening(object sender, CancelEventArgs e)
        {
            addToStyleRepositoryToolStripMenuItem.Visible = isstyleselected();
            deleteToolStripMenuItem.Visible = isstyleselected();
            assignToCurrentSelectionToolStripMenuItem.Visible = isstyleselected();
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            if (drawme != null)
                CenterDrawme();
        }

        private void action_Cut(object sender, EventArgs e)
        {
            actionCut();
        }

        private void lstStyles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                actionChangeStyleName();
        }

        private void lstStyles_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            // Determine if label is changed by checking for null.
            if (e.Label == null)
                return;

            string cNew = e.Label, cOld = lstStyles.Items[e.Item].Text;
            if (cNew == "")
            {
                MessageBox.Show("Invalid style name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;
            }
            else if (G.styles.ContainsKey(cNew))
            {
                MessageBox.Show(cNew + ": a style with that name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;
            }
            else
            {
                DrawObjectStyle dos = G.styles[cOld];
                G.styles.Remove(dos.name);
                dos.name = cNew;
                G.styles.Add(dos.name, dos);
                RefreshStyleList();
            }
        }

        private void lstStyles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (WeAreClosing || e.CurrentValue != CheckState.Checked)
                return;
            // Count checked items in grouo
            int c = 0;
            foreach (ListViewItem lvi in lstStyles.Items[e.Index].Group.Items)
                if (lvi.Checked)
                    c++;
            if (c == 1) // we are trying to uncheck the sole checked item => prevent
                e.NewValue = CheckState.Checked;
        }

        private void lstStyles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!e.Item.Checked || WeAreClosing) 
                return;
            
            foreach (ListViewItem lvi in e.Item.Group.Items)
            {
                if (lvi != e.Item)
                    lvi.Checked = false;
            }
            
        }



    }


}
