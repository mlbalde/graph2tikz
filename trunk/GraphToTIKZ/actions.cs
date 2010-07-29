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

        void actionNewFile()
        {
            if (!TryDisposeGraph())
                return;

            curFile = Consts.defaultCurFile;
            ChangeCurrentGraph(new TikzGraph());
        }

        void actionOpenFile()
        {
            if (!TryDisposeGraph())
                return;
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            LoadFile(openFileDialog1.FileName);
        }

        void actionSaveFile()
        {
            SaveCurFile();
        }

        void actionSaveFileAs()
        {
            SaveCurFile(true);
        }

        void actionExportToClipboard()
        {
            Clipboard.SetText(G.getTikzString());
        }

        void actionImportFromClipboard()
        {
            if (!Clipboard.ContainsText())
            {
                MessageBox.Show("Error: There is no text in the Clipboard.", "Error importing from Clipboard");
                return;
            }
            try
            {
                string s = Clipboard.GetText();
                tikzgrammarLexer lex = new tikzgrammarLexer(new ANTLRStringStream(s));
                CommonTokenStream tokens = new CommonTokenStream(lex);

                tikzgrammarParser parser = new tikzgrammarParser(tokens);


                //tikzgrammarParser.expr_return r =
                parser.tikzpicture();

                // change the current graph
                if (TryDisposeGraph())
                    ChangeCurrentGraph(parser.tres);

                //CommonTree t = (CommonTree)r.Tree;
                //Console.WriteLine(t.ToStringTree());

                //CommonTreeNodeStream nodes = new CommonTreeNodeStream(t);
                //tstgrtree walker = new tstgrtree(nodes);
                //Console.WriteLine(walker.expr());
                //MessageBox.Show("Parsed: " + parser.tres.scale + " " + parser.tres.styles.Count + String.Join(" ", parser.tres.styles.Keys));
                //txtCode.BackColor = parser.tres.styles["mystyle"].fill;
            }
            catch (RecognitionException ex)
            {
                MessageBox.Show("Failed to Parse Clipboard Text (maybe ill-formatted): " + ex.StackTrace);
                //Console.Error.WriteLine(e.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to understand Clipboard Text (maybe ill-formatted): " + ex.StackTrace);
            }
            //Console.ReadLine();
        }

        void actionCut()
        {
            if (Helper.GetFocusControl() is TextBoxBase)
            {
                TextBoxBase t = Helper.GetFocusControl() as TextBoxBase;
                if (t.Enabled && !t.ReadOnly)
                    t.Cut();
            }
            else
            {
                actionCopy();
                actionDeleteSelection();
            }
        }

        void actionCopy()
        {
            if ( Helper.GetFocusControl() is TextBoxBase )
            {
                (Helper.GetFocusControl() as TextBoxBase).Copy();
            }
            else if (G.GetSelCount() > 0)
            {
                Clipboard.SetData("GraphToTikz", G.GetSelectedSubgraph());
            }
        }

        void actionPaste()
        {
            if (Helper.GetFocusControl() is TextBoxBase)
            {
                TextBoxBase t = Helper.GetFocusControl() as TextBoxBase;
                if (t.Enabled && !t.ReadOnly)
                    t.Paste();
            }
            else if (Clipboard.ContainsData("GraphToTikz"))
            {
                G.deselectall();
                //vertex v = (vertex)Clipboard.GetData("GraphToTikz");
                //if (v == null) MessageBox.Show("it is NULL"); 

                TikzGraph gg = (TikzGraph)Clipboard.GetData("GraphToTikz");
                BeforeGraphChange();
                G.Merge(gg);
                OnGraphChanged();
                drawme.Invalidate();
                return;
            }
        }

        void actionUndo()
        {
            if (Helper.GetFocusControl() is TextBoxBase)
            {
                (Helper.GetFocusControl() as TextBoxBase).Undo();
            }
            else
            {
                if (undos.Count < 1) return;
                redos.Push(G);
                ChangeCurrentGraph(undos.Pop(), false);
                lChangesMade = true;
            }
        }

        void actionRedo()
        {
            /*if (Helper.GetFocusControl() is TextBoxBase)
            {
                (Helper.GetFocusControl() as TextBoxBase).Redo();
            }
            else
            {*/
            if (redos.Count < 1) return;
                undos.Push(G);
                ChangeCurrentGraph(redos.Pop(), false);
                lChangesMade = true;
            //}
        }

        void actionDeleteSelection()
        {
            if (Helper.GetFocusControl() is TextBoxBase)
            {
                TextBoxBase t = Helper.GetFocusControl() as TextBoxBase;
                if (t.Enabled && !t.ReadOnly)
                    t.SelectedText = "";
            }
            else
            {
                if (G.GetSelCount() <= 0) return;
                // remove also all incoming edges
                /*objlist.Remove
                delegate(DrawObject o)
                {
                    if (!(objstyles is edge))
                        return false;
                    edge ed = o as edge;
                    return (ed.from.id == selvert || ed.to.id == selvert);
                });
                  */

                for (int i = G.objlist.Count() - 1; i >= 0; i--)
                {
                    DrawObject o = G.objlist.ElementAt(i).Value;
                    if (o.selected
                        || (o is edge
                                    && (((edge)o).from.selected || ((edge)o).to.selected)))
                    {
                        G.objlist.Remove(o.id);
                    }
                }

                setselvert(-1);
                drawme.Invalidate();
            }
        }

        void actionNewStyle(DOType type = DOType.V)
        {
            // find a unique stylename
            int i=1;
            string s = "New Style";
            while (G.styles.ContainsKey(s))
            {
                s = "New Style " + i++;
            }

            //string s = Microsoft.VisualBasic.Interaction.InputBox("Please enter (unique) style name:", "New Style", "MyStyle");
            //if (s == "") return;
            //if (G.styles.ContainsKey(s))
            //{
            //    MessageBox.Show("Error: A style with this name is already present.", "Invalid style name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            DrawObjectStyle dos = new DrawObjectStyle();
            dos.name = s;
            dos.type = type;
            G.styles.Add(dos.name, dos);
            ListViewItem lvi = lstStyles.Items.Add(dos.name); //dos.name, dos.name,0);
            //lvi.SubItems.Add(dos.type.ToString());
            lvi.Group = lstStyles.Groups[type.ToString()];

            lvi.Selected = true;
            actionChangeStyleName();
        }

        void actionDeleteStyle()
        {
            if (!isstyleselected()) return;
            if (G.GetStyleCount(getselstyle().type) < 2)
            {
                MessageBox.Show("Cannot delete style: At least one style for edges and vertices each has to be there.", "Warning"); 
                return;
            }

            // all objects sharing this style are set to the std. style
            foreach (DrawObject o in G.objlist.Values)
                if (o.style == getselstyle())
                    o.style = G.styles.Values.First();

            G.styles.Remove(getselstyle().name);
            RefreshStyleList();
            //lstStyles.Items.Remove(lstStyles.SelectedItems[0]);
            RefreshStyleDisplay();
        }

        void actionAssignStyle()
        {
            // sets the style for the current selection
            if (lstStyles.SelectedItems.Count <= 0) return;
            foreach (DrawObject o in G.objlist.Values)
            {
                if (o.selected)
                    if (o.type == getselstyle().type)
                        o.style = getselstyle();
            }
            drawme.Invalidate();
        }

        void actionChangeStyleName()
        {
            if (lstStyles.SelectedItems.Count > 0)
                lstStyles.SelectedItems[0].BeginEdit();
        }

        void actionUpdateTikzCode()
        {
            txtCode.Text = G.getTikzString();
        }

        void actionPreview()
        {

        }

        void actionRefreshPreviews()
        {
            recompile = true;
            recompileimgs = true;
        }

        void actionAddStyleToRepo()
        {
            if (isstyleselected())
                StyleRepo.AddStyle(getselstyle());
        }

        void actionShowStyleRepo()
        {
            StyleRepo.ShowRepo(G);
            RefreshStyleList();
            RefreshStyleDisplay();
            drawme.Invalidate();
        }
    }

}