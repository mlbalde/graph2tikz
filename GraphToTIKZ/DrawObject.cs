using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;


namespace GraphToTIKZ
{
    public class myControl : Control
    {
        public void setdbuffer()
        {
            SetStyle(ControlStyles.DoubleBuffer |
                 ControlStyles.UserPaint |
                 ControlStyles.AllPaintingInWmPaint
                 , true);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint

            base.OnPaint(pe);
            // Create two semi-transparent colors

            /*   Color c1 = Color.FromArgb
                     (m_color1Transparent, m_color1);
                 Color c2 = Color.FromArgb
                     (m_color2Transparent, m_color2);
                 Brush b = new System.Drawing.Drawing2D.LinearGradientBrush
                     (ClientRectangle, c1, c2, 10);
                 pe.Graphics.FillRectangle(b, ClientRectangle);
                 b.Dispose();*/
        }

    }

    public enum DOType { V, E, U } // vertex or edge or unknown

    [Serializable]
    public abstract class DrawObject : ICloneable
    {
        public abstract DOType type { get; }
        public bool selected = false;
        public int id;
        public string text = "";
        public DrawObjectStyle style;
        public string name = "";
        //public float linewidth = Consts.TikzDefaultLinewidth;

        /// <summary>
        /// Draws the object.
        /// </summary>
        /// <param name="g">The Device to draw on.</param>
        /// <param name="pixelperunit">The resolution (in pixel per cm).</param>
        /// <param name="scale">The graphs scale factor. Rescales all coordinates, but not text size etc.</param>
        /// <param name="useimgs">Whether to use the precompiled images (or standard text).</param>
        public abstract void Draw(Graphics g, int pixelperunit, float scale, bool useimgs);
        //public abstract Point gettextpos(int pixelperunit);
        /// <summary>
        /// Determines whether the DrawObject intersects the rectangle rect, given in pixel coordinates.
        /// It uses the bounding box(es) from the last Draw()-call.
        /// (I.e., call draw first, then use this method.)
        /// </summary>
        /// <param name="rect">The rectangle.</param>
        /// <returns></returns>
        public abstract bool intersectswith(RectangleF rect); // means: intersects
        /// <summary>
        /// Shallow-Copies the object. The style is not copied
        /// </summary>
        /// <returns></returns>
        public DrawObject copy() { return (DrawObject)Clone(); }
        public object Clone() { return MemberwiseClone(); }

        /// <summary>
        /// Generates a string producing the object in a Tikzpicture environment.
        /// </summary>
        /// <param name="cy">The height of the Tikz image. This is needed since the TikzGraph
        /// uses an upper-right coordinate origin and Tikz a lower-left one.</param>
        /// <returns>The string.</returns>
        public abstract string getTikzString(double cy);
    }

    [Serializable]
    public class vertex : DrawObject
    {
        public override DOType type { get { return DOType.V; } }
        public double x, y;
        public string label = "";

        // the position of the label, measured counterclockwise starting from 3 o'clock
        public int labelangle = 0;

        // The images of the text and label, rendered using latex/dvipng
        public Image img_text = null;
        public Image img_label = null;

        // stores the bounding boxes from the last call to Draw()
        private RectangleF framerect = new RectangleF(), labelrect = new RectangleF();


        //int vsize = 10; // TODO

        public override bool intersectswith(RectangleF rect)
        {
            //return rect.IntersectsWith(new Rectangle(Convert.ToInt32(x * pixelperunit) - vsize, Convert.ToInt32(y * pixelperunit) - vsize, 2 * vsize, 2 * vsize));
            return (rect.IntersectsWith(framerect) || rect.IntersectsWith(labelrect));
        }

        public override void Draw(Graphics g, int pixelperunit, float scale, bool useimgs)
        {
            // scale: scales all coordinates (not point size etc)
            //base.Draw(g, objlist);

            Pen pblack = new Pen(Color.Black, style.LineWidth/Consts.ptspertikzunit);
            Pen pdraw = new Pen(style.draw, style.LineWidth / Consts.ptspertikzunit);
            Pen pmarked = new Pen(Color.Magenta, style.LineWidth / Consts.ptspertikzunit);
            //Pen plight = new Pen(Color.LightGray, 0.5f);
            SolidBrush bblack = new SolidBrush(Color.Black);
            SolidBrush bfill = new SolidBrush(style.fill);
            SolidBrush bmarked = new SolidBrush(Color.Magenta);

            if (selected)
            {
                bfill = bmarked;
                pdraw = pmarked;
            }

            // determine text size
            float tptopixel = pixelperunit / Consts.ptspertikzunit;
            Font thefont = new Font(Consts.TikzDefaultFont, Consts.TikzDefaultFontSize * tptopixel);
            SizeF txtsize, framesize, labelsize;
            if (img_text == null || !useimgs)
                txtsize = g.MeasureString(text, thefont);
            else
            {
                txtsize = img_text.Size;
                txtsize.Height *= Consts.cmperin / Consts.TikzImgResolution;
                txtsize.Width  *= Consts.cmperin / Consts.TikzImgResolution;
            }
            // determine size of surrounding rect/circle
            if (style.shape == vshape.rectangle)
            {
                framesize = new SizeF(txtsize.Width + 2 * style.innersep * tptopixel, txtsize.Height + 2 * style.innersep * tptopixel);
            }
            else if (style.shape == vshape.coordinate)
            {
                framesize = new SizeF(Consts.coordvertexsize, Consts.coordvertexsize);
            }
            else // circle
            {
                float diam = (float)Math.Sqrt(txtsize.Width * txtsize.Width + txtsize.Height * txtsize.Height);
                framesize = new SizeF(diam + 2 * style.innersep * tptopixel, diam + 2 * style.innersep * tptopixel);
            }
            

            if (framesize.Width < style.minimumsize * tptopixel)
                framesize.Width = style.minimumsize * tptopixel;
            if (framesize.Height < style.minimumsize * tptopixel)
                framesize.Height = style.minimumsize * tptopixel;
            //framesize = TikzGraph.ConvertTikzPtsToScreenPtsSize(framesize, pixelperunit);
            framerect = new RectangleF(new PointF((float)x * scale * pixelperunit - framesize.Width / 2,
                                        (float)y * scale * pixelperunit - framesize.Height / 2), framesize);


            if (style.lfill)
                if (style.shape == vshape.rectangle)
                    g.FillRectangle(bfill, framerect);
                else if (style.shape == vshape.circle)
                    g.FillEllipse(bfill, framerect);
            if (style.ldraw)
                if (style.shape == vshape.rectangle)
                    g.DrawRectangles(pdraw, new RectangleF[] { framerect });
                else if (style.shape == vshape.circle)
                    g.DrawEllipse(pdraw, framerect);

            if (style.showeditX || style.shape == vshape.coordinate)
            {
                // draw an X
                g.DrawLine(pdraw, (float)x * scale * pixelperunit - Consts.drawXsize, (float)y * scale * pixelperunit - Consts.drawXsize,
                              (float)x * scale * pixelperunit + Consts.drawXsize, (float)y * scale * pixelperunit + Consts.drawXsize);
                g.DrawLine(pdraw, (float)x * scale * pixelperunit - Consts.drawXsize, (float)y * scale * pixelperunit + Consts.drawXsize,
                             (float)x * scale * pixelperunit + Consts.drawXsize, (float)y * scale * pixelperunit - Consts.drawXsize);
            }

            // draw the text
            if (text != "" && style.shape != vshape.coordinate)
            {
                PointF textorig = new PointF((float)x * scale * pixelperunit - txtsize.Width / 2, (float)y * scale * pixelperunit - txtsize.Height / 2);
                if (img_text != null && useimgs)
                    g.DrawImage(img_text, new RectangleF(textorig, txtsize));
                else
                    g.DrawString(text, thefont, bblack, textorig);
                //gettextpos(pixelperunit));
            }
            // draw the label
            if (label != "")
            {
                if (img_label == null || !useimgs)
                    labelsize = g.MeasureString(label, thefont);
                else
                {
                    labelsize = img_label.Size;
                    labelsize.Height *= Consts.cmperin / Consts.TikzImgResolution;
                    labelsize.Width *= Consts.cmperin / Consts.TikzImgResolution;
                }
                float labeldist = getrectradius(labelsize, labelangle) + style.outersep * tptopixel;
                if (style.shape == vshape.circle)
                    labeldist += framesize.Width / 2;
                else
                    labeldist += getrectradius(framesize, labelangle);

                float cosa = (float)Math.Cos(labelangle * 2 * Math.PI / 360), sina = (float)Math.Sin(labelangle * 2 * Math.PI / 360);
                PointF labelorig = new PointF((float)x * scale * pixelperunit + cosa * labeldist - labelsize.Width / 2,
                                              (float)y * scale * pixelperunit - sina * labeldist - labelsize.Height / 2);
                
                labelrect = new RectangleF(labelorig, labelsize);
                if (img_label != null && useimgs)
                    g.DrawImage(img_label, labelrect);
                else
                    g.DrawString(label, thefont, bblack, labelorig);
               
            }
            else labelrect = new RectangleF(-1, -1, 0, 0);
        }
        float getrectradius(SizeF s, int angle)
        {
            double cosa = Math.Cos(angle * 2 * Math.PI / 360), sina = Math.Sin(angle * 2 * Math.PI / 360);
            if (Math.Abs(cosa * s.Height) > Math.Abs(sina * s.Width))
                return (float)(s.Width / (2 * Math.Abs(cosa)));
            else
                return (float)(s.Height / (2 * Math.Abs(sina)));
        }

        /// <summary>
        /// Determines the extend of the framerect in the direction specified by the vector t.
        /// </summary>
        /// <param name="t">The direction. Must not be the null vector</param>
        /// <returns>The distance, measured in units (length of t)</returns>
        public double getBBRadius(PointD t)
        {
            if (style.shape == vshape.circle)
                return (framerect.Width / (2*t.Norm()));
            else if (style.shape == vshape.rectangle)
            {
                // determine which side the intersection point is on 
                if (Math.Abs(t.X * framerect.Height) > Math.Abs(t.Y * framerect.Width))
                    return (framerect.Width / (2 * Math.Abs(t.X)));
                else
                    return (framerect.Height / (2 * Math.Abs(t.Y)));
            }
            else 
                return 0;
        }

        public override string getTikzString(double cy)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\\node (v{0}) at ({1:G4},{2:G4}) [{3}", new object[] { id, x, cy - y, style.name });

            if (label != "")
                sb.Append(",label=" + labelangle + ":" + label);

            sb.Append("] {" + text + "};");
            return sb.ToString();
        }
        public static Dictionary<string, vertex> parseTikzString(string s, Dictionary<string, DrawObjectStyle> styles)
        {
            Dictionary<string, vertex> res = new Dictionary<string, vertex>();
            Match m;
            Regex r = new Regex(@"\\node \((?<1>[^\)]*)\) at \((?<2>[^\),]*),(?<3>[^\),]*)\) \[(?<4>[^\]]*)\] \{(?<5>[^\}]*)\};");
            for (m = r.Match(s); m.Success; m = m.NextMatch())
            {
                vertex v = new vertex();
                v.x = Double.Parse(m.Groups[2].Value);
                v.y = Double.Parse(m.Groups[3].Value);
                v.style = styles[m.Groups[4].Value]; // TODO: labels
                v.text = m.Groups[5].Value;
                res.Add(m.Groups[1].Value, v);
            }
            return res;
        }

    }
    [Serializable]
    public class edge : DrawObject
    {
        public override DOType type { get { return DOType.E; } }
        public vertex from, to;
        public PointD fromp = new PointD(), top = new PointD();
        public int inangle=0, outangle=0;
        public bool useinoutangle=false;
        public string abovelabel="", belowlabel="";
        Image img_abovelabel = null, img_belowlabel = null;

        /*   public override DrawObject copy()
           {
               edge v = new edge();
               v.text = text; v.selected = selected; v.id = id;
               v.from = (vertex)from.copy(); v.to = (vertex)to.copy(); // TODOOOOOOOO
               return v;
           }*/
        public override void Draw(Graphics g, int pixelperunit, float scale, bool useimgs)
        {
            //base.Draw(g, objlist);

            Pen pdraw = new Pen(style.draw, style.LineWidth / Consts.ptspertikzunit);
            Pen pmarked = new Pen(Color.Magenta, style.LineWidth / Consts.ptspertikzunit);
            Pen p;

            if (selected)
            {
                p = pmarked;
            }
            else
            {
                p = pdraw;
            }
            if (style.dashstyle != TikzDashStyle.solid)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                p.DashPattern = Consts.TikzToSystemDashPattern[(int)style.dashstyle];
            }
            //p.StartCap = LineCap.Triangle;
            //p.EndCap = LineCap.ArrowAnchor;
            if (style.fromTip != TikzArrowTip.none)
                p.CustomStartCap = LineCapBuilder.TikzTipToLineCap[(int)style.fromTip];
            if (style.toTip != TikzArrowTip.none)
                p.CustomEndCap = LineCapBuilder.TikzTipToLineCap[(int)style.toTip];

            fromp = new PointD(pixelperunit * scale * from.x, pixelperunit * scale * from.y);
            top   = new PointD(pixelperunit * scale * to.x, pixelperunit * scale * to.y);
            
            // adjust fromp/top by taking into account the extend of the source/target vertices
            PointD tdirect = top - fromp;
            double l1, l2;
            if (useinoutangle)
            {
                PointD t1 = new PointD(Math.Cos(inangle *2*Math.PI /360), -Math.Sin(inangle *2*Math.PI /360)),
                       t2 = new PointD(Math.Cos(outangle *2*Math.PI /360), -Math.Sin(outangle *2*Math.PI /360));
                l1 = to.getBBRadius(t1);
                l2 = from.getBBRadius(t2);
                top = top + l1 * t1;
                fromp = fromp + l2 * t2;

                double cptdist = .25 * (top-fromp).Norm();
                if (to == from) // tadpole case
                    cptdist *= 10;

                g.DrawBezier(p, (PointF)fromp, (PointF)(fromp + cptdist * t2), (PointF)(top + cptdist * t1), (PointF)top);
            }
            else
            {
                l1 = to.getBBRadius(-tdirect);
                l2 = from.getBBRadius(tdirect);
                if (l1 + l2 >= 1)
                {
                    top = fromp = fromp + (.5 * tdirect);
                }
                else
                {
                    top = top - l1 * tdirect;
                    fromp = fromp + l2 * tdirect;

                    g.DrawLine(p, (PointF)fromp, (PointF)top);
                }


            }

            
            
            // draw the text
            // g.DrawString(text, new Font("Arial", 8), bblack, gettextpos());

        }

        public override string getTikzString(double cy)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\\draw["+style.name);
            if (useinoutangle)
                sb.AppendFormat(",in={0}, out={1}", inangle, outangle);
            if (from == to)
                sb.Append(",loop");
            sb.AppendFormat("] (v{0}) to (", from.id);
            if (from == to) 
               sb.Append(");");
            else
                sb.Append("v" + to.id + ");");
            return sb.ToString();
        }
        public static edge[] parseTikzString(string s, Dictionary<string, vertex> verts)
        {
            Match m;
            List<edge> res = new List<edge>();
            Regex r = new Regex(@"\\draw \((?<1>[^\)]*)\)--\((?<2>[^\)]*)\);");
            for (m = r.Match(s); m.Success; m = m.NextMatch())
            {
                edge ed = new edge();
                ed.from = verts[m.Groups[1].Value];
                ed.to = verts[m.Groups[2].Value];
                res.Add(ed);
            }

            return res.ToArray();
        }
        public override bool intersectswith(RectangleF rect)
        {
            PointF p1 = (PointF)fromp, //new Point(Convert.ToInt32(from.x * scale * pixelperunit), Convert.ToInt32(from.y * scale * pixelperunit)),
            p2 = (PointF)top; // new Point(Convert.ToInt32(to.x * scale * pixelperunit), Convert.ToInt32(to.y * scale * pixelperunit));
            if (rect.Contains(p1) || rect.Contains(p2))
                return true;

            PointF topright = new PointF(rect.X + rect.Width, rect.Y),
                bottomleft = new PointF(rect.X, rect.Y + rect.Height),
                bottomright = new PointF(rect.X + rect.Width, rect.Y + rect.Height);
            if (LinesIntersect(p1, p2, rect.Location, topright) || LinesIntersect(p1, p2, rect.Location, bottomleft)
                || LinesIntersect(p1, p2, bottomright, topright) || LinesIntersect(p1, p2, bottomright, bottomleft))
                return true;

            return false;
        }

        private bool LinesIntersect(PointF a1, PointF a2, PointF b1, PointF b2)
        {
            double s1 = a2.X - a1.X, s2 = a2.Y - a1.Y, t1 = b2.X - b1.X, t2 = b2.Y - b1.Y,
                u1 = b1.X - a1.X, u2 = b1.Y - a1.Y;

            double det = s2 * t1 - s1 * t2;
            if (det != 0)
            {
                double l = (-t2 * u1 + t1 * u2) / det, m = (-s2 * u1 + s1 * u2) / det;
                return (l >= 0 && l <= 1 && m >= 0 && m <= 1);
            }
            else
            {
                return (isPointonLine(a1, a2, b1) || isPointonLine(a1, a2, b2));
            }

        }
        private bool isPointonLine(PointF a, PointF b, PointF x)
        {
            double eps = 1e-15;
            double s1 = b.X - a.X, s2 = b.Y - a.Y;
            if (s1 == 0 && s2 == 0)
                return (x.X == a.X && x.Y == a.Y);

            double u1 = x.X - a.X, u2 = x.Y - a.Y;
            double l = (s1 * u1 + s2 * u2) / Math.Sqrt(s1 * s1 + s2 * s2);
            return (Math.Abs(l * s1 - u1) < eps && Math.Abs(l * s2 - u2) < eps && l >= 0 && l <= 1);
        }

    }

    [Serializable]
    public class DrawObjectStyle : ICloneable
    {
        public DOType type = DOType.U;
        public string name = "";
        public vshape shape = vshape.rectangle;
        public Color fill = Color.Black;
        public Color draw = Color.Black;
        public bool showeditX = false;
        public int minimumsize = 5;
        public bool lfill = false, ldraw = false;
        public string extraformat = "";
        public float innersep, outersep;
        public TikzArrowTip fromTip=TikzArrowTip.none, toTip=TikzArrowTip.none;
        public TikzDashStyle dashstyle = TikzDashStyle.solid;
        public float LineWidth = Consts.TikzDefaultLinewidth;

        public override string ToString() { return name; }
        public object Clone() { return MemberwiseClone(); }
        public DrawObjectStyle copy() { return (DrawObjectStyle)Clone(); }
        public string getTikzString()
        {
            //DrawObjectStyle defaults = new DrawObjectStyle();
            List<string> si = new List<string>();

            if (ldraw)
                if (draw.Equals(Color.Black))
                    si.Add("draw");
                else
                    si.Add("draw=" + ColorToTikzString(draw));
            if (type == DOType.V) // &&outersep != defaults.outersep)
            {
                si.Add("outer sep=" + outersep);
                si.Add("inner sep=" + innersep);
                si.Add("minimum size=" + minimumsize);
                if (shape != vshape.rectangle)
                    si.Add("shape=" + shape.ToString());
                if (lfill)
                    if (fill.Equals(Color.Black))
                        si.Add("fill");
                    else
                        si.Add("fill=" + ColorToTikzString(fill));
            }
            if (type == DOType.E)
            {
                string s = Consts.TikzArrowTipCodes[(int)fromTip] + "-" + Consts.TikzArrowTipCodes[(int)toTip];
                if (s != "-")
                    si.Add(s);
            }
            if (LineWidth != 0)
                si.Add("line width=" + LineWidth);
            if (dashstyle != TikzDashStyle.solid)
                si.Add("dash style=" + dashstyle.ToString());
            
            if (extraformat != "")
                si.Add(extraformat);

            return name + "/.style={" + String.Join(",", si) + "}";
        }
        public static string ColorToTikzString(Color c)
        {
            if (c.IsNamedColor)
                return c.Name.ToLower(); //still a hack
            else
                return "color" + c.R + c.G + c.B;
        }
        public static Color TikzStringToColor(string s)
        {

            return Color.FromName(s);
        }
        public static Dictionary<string, DrawObjectStyle> parseTikzString(string s)
        {
            Dictionary<string, DrawObjectStyle> res = new Dictionary<string, DrawObjectStyle>();
            Match m;
            Regex r = new Regex(@"(,|^)(?<1>[^\)\(\[\]\{\},]*)/\.style=\{(?<2>[^\}]*)\}");
            for (m = r.Match(s); m.Success; m = m.NextMatch())
            {
                DrawObjectStyle dos = new DrawObjectStyle();
                dos.name = m.Groups[1].Value;
                string[] optlist = m.Groups[2].Value.Split(',');
                List<string> notparsedopts = new List<string>();
                foreach (string opt in optlist)
                {
                    opt.Trim();
                    string[] kvals = opt.Split('=');
                    if (kvals.Length > 2) { notparsedopts.Add(opt); continue; }
                    kvals[0].Trim();
                    if (kvals[0].Equals("draw"))
                    {
                        dos.ldraw = true;
                        if (kvals.Length > 1)
                            dos.draw = TikzStringToColor(kvals[1]);
                    }
                    else if (kvals[0].Equals("fill"))
                    {
                        dos.lfill = true;
                        if (kvals.Length > 1)
                            dos.fill = TikzStringToColor(kvals[1]);
                    }
                    else if (kvals[0].Equals("inner sep"))
                    {
                        if (kvals.Length > 1)
                            dos.innersep = Int32.Parse(kvals[1]);
                    }
                    else if (kvals[0].Equals("outer sep"))
                    {
                        if (kvals.Length > 1)
                            dos.outersep = Int32.Parse(kvals[1]);
                    }
                    else notparsedopts.Add(opt);
                }
                dos.extraformat = String.Join(",", notparsedopts);
                res.Add(m.Groups[1].Value, dos);
            }

            return res;
        }
    }

 /*   public class EdgeStyle : DrawObjectStyle
    {
        public string typedescr { get { return "E"; } }
    }

    public class VertexStyle : DrawObjectStyle
    {
        public string typedescr { get { return "V"; } }
    }
    */


}