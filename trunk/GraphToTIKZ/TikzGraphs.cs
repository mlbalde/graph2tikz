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



namespace GraphToTIKZ
{
    public enum TikzDashStyle { solid, dotted, dashed }
    public enum TikzArrowTip { none, rightarrow, leftarrow }
    public enum vshape { rectangle, coordinate, circle }
    [Serializable]
    public class TikzGraph : ICloneable
    {
        //public static float ptspertikzunit = 28.35F;    // 72dpi = 28.346.. dpcm
        //public static int stdfontsize = 8; // in tikz points

        public Dictionary<int, DrawObject> objlist = new Dictionary<int, DrawObject> ();
        public int idcnt=0;
        public Dictionary<string, DrawObjectStyle> styles = new Dictionary<string, DrawObjectStyle>();
        public double cx = 15;
        public double cy = 10;
        public double scale = 1.0;

        public TikzGraph()
        {
            // Add the standard styles
            DrawObjectStyle dos = new DrawObjectStyle();
            dos.type = DOType.V;
            dos.name = "vert";
            dos.lfill = true;
            dos.ldraw = true;
            dos.fill = Color.Black;
            dos.draw = Color.Black;
            styles.Add(dos.name, dos);

            dos = new DrawObjectStyle();
            dos.type = DOType.V;
            dos.name = "helper";
            dos.showeditX = true;
            dos.shape = vshape.coordinate;
            styles.Add(dos.name, dos);

            dos = new DrawObjectStyle();
            dos.type = DOType.E;
            dos.name = "default edge";
            dos.ldraw = true;
            dos.draw = Color.Black;
            styles.Add(dos.name, dos);
        }
        public void AddObject(DrawObject o)
        {
            o.id = idcnt++;
            objlist.Add(o.id, o);
        }
        public void Draw(Graphics g, int pixelperunit, bool useimgs)
        {
            // draw edges
            foreach (DrawObject o in objlist.Values)
            {
                if (o is edge) 
                    o.Draw(g, pixelperunit, (float)scale, useimgs);
            }
            // draw vertices
            foreach (DrawObject o in objlist.Values)
            {
                if (o is vertex) 
                    o.Draw(g, pixelperunit, (float)scale, useimgs);
            }
        }
        public void deselectall()
        {
            foreach (DrawObject o in objlist.Values)
                o.selected = false;
        }
        public vertex vfromname(string tname)
        {
            foreach (DrawObject o in objlist.Values)
                if (o is vertex)
                {
                    vertex v = o as vertex;
                    if (v.name == tname)
                        return v;
                }
            return null;
        }
        public object Clone() // performs deep copy, TODO: adjust ref to sel. vertex ??
        {
            TikzGraph t = MemberwiseClone() as TikzGraph;
            t.styles = new Dictionary<string, DrawObjectStyle>();
            t.objlist = new Dictionary<int, DrawObject>();
            // copy objects
            foreach (DrawObjectStyle dos in styles.Values)
                t.styles.Add(dos.name, dos.copy());
            foreach (DrawObject o in objlist.Values)
                t.objlist.Add(o.id, o.copy());
            // reset references
            foreach (DrawObject o in t.objlist.Values)
                if (o is vertex)
                {
                    (o as vertex).style = t.styles[(o as vertex).style.name];
                }
                else if (o is edge)
                {
                    edge ed = o as edge;
                    ed.from = (vertex)t.objlist[ed.from.id];
                    ed.to = (vertex)t.objlist[ed.to.id];
                }
            return t;
        }

        public void Merge(TikzGraph t) // (with deepcopy)
        {
            // merge styles
            foreach (DrawObjectStyle dos in t.styles.Values)
                if (!styles.ContainsKey(dos.name))
                    styles.Add(dos.name, dos.copy());

            // merge object lists
            Dictionary<int, DrawObject> oldidtonewobject = new Dictionary<int, DrawObject>();
            foreach (DrawObject oldo in t.objlist.Values)
            {
                DrawObject o = oldo.copy();
                o.id = idcnt++;
                // reset style references
                o.style = styles[o.style.name];
                
                oldidtonewobject.Add(oldo.id, o);
                objlist.Add(o.id, o);
            } 
            // reset vertex from/to references
            foreach (DrawObject o in oldidtonewobject.Values)
                if (o is edge)
                {
                    edge ed = o as edge;
                    ed.from = (vertex)oldidtonewobject[ed.from.id];
                    ed.to = (vertex)oldidtonewobject[ed.to.id];
                }
        }
        /// <summary>
        /// Returns the selected subgraph, including unselected vertices incident to selected edges.
        /// Does not perfom a deepcopy!!
        /// </summary>
        /// <returns></returns>
        public TikzGraph GetSelectedSubgraph()
        {
            TikzGraph res = (TikzGraph) MemberwiseClone();
            res.objlist = new Dictionary<int, DrawObject>();
            foreach (DrawObject o in objlist.Values)
            {
                if (o.selected)
                {
                    res.objlist.Add(o.id, o);
                    // add vertices incident to selected edges
                    if (o is edge)
                    {
                        edge ed = o as edge;
                        if (!res.objlist.ContainsKey(ed.to.id))
                            res.objlist.Add(ed.to.id, ed.to);
                        if (!res.objlist.ContainsKey(ed.from.id))
                            res.objlist.Add(ed.from.id, ed.from);
                    }
                }
            }
            

            return res;            
        }
        public int GetSelCount()
        {
            return objlist.Count(kv => kv.Value.selected);
        }
        public bool parseTikzString(string s)
        {
            Match m;
            Regex r1 = new Regex("\\\\begin\\{tikzpicture\\}\\s*\\[(?<1>[^\\[\\]\\\\]*)\\](?<2>.*)\\\\end\\{tikzpicture\\}", RegexOptions.Singleline);
            //Regex r1 = new Regex("\\\\begin\\{tikzpicture\\}.*\\\\end\\{tikzpicture\\}", RegexOptions.Singleline);
            m = r1.Match(s);
            if (!m.Success) return false;

            string sts = m.Groups[1].Value, bodystr = m.Groups[2].Value;
            //string[] stylestrs = Regex.Split(sts, ",(?![^\\}\\{]*\\})",RegexOptions.Singleline);

            Dictionary<string, DrawObjectStyle> doss = DrawObjectStyle.parseTikzString(sts);

            // nodes and edges
            Dictionary<string, vertex> vs = vertex.parseTikzString(bodystr, doss);
            edge[] eds = edge.parseTikzString(bodystr, vs);


            //stylestr.Trim();
            return true;
        }
        // ldrawBB = true will draw a bounding box
        public string getTikzString(bool ldrawBB = false)
        {
            StringBuilder sb = new StringBuilder();
            List<string> si = new List<string>();
            List<string> colorslist = new List<string>();
            
            foreach (DrawObjectStyle dos in styles.Values)
            { 
                if (!dos.fill.IsNamedColor && dos.lfill && !colorslist.Contains(DrawObjectStyle.ColorToTikzString(dos.fill)) )
                {
                    sb.AppendLine(@"\definecolor{"+DrawObjectStyle.ColorToTikzString(dos.fill)+
                                    "}{rgb}{"+(dos.fill.R/256.0)+","+(dos.fill.G/256.0)+","+(dos.fill.B/256.0)+"}");
                    colorslist.Add(DrawObjectStyle.ColorToTikzString(dos.fill));
                }
                if (!dos.draw.IsNamedColor && dos.ldraw && !colorslist.Contains(DrawObjectStyle.ColorToTikzString(dos.draw)) )
                {
                    sb.AppendLine(@"\definecolor{"+DrawObjectStyle.ColorToTikzString(dos.draw)+
                                    "}{rgb}{" + (dos.draw.R / 256.0) + "," + (dos.draw.G / 256.0) + "," + (dos.draw.B / 256.0) + "}");
                    colorslist.Add(DrawObjectStyle.ColorToTikzString(dos.draw));
                }

                si.Add(dos.getTikzString());
            }
            sb.AppendLine("\\begin{tikzpicture}[scale=" + scale.ToString(Consts.DoubleFormat) + ","); //TODO: cx, cy
            sb.AppendLine(String.Join(",\r\n", si) + "]");
            sb.AppendLine("");
            if (ldrawBB)
            {
                sb.AppendLine(@"\draw (0,0) rectangle ("+cx+","+cy+");");
            }

            // write vertices and edges
            si.Clear();
            List<string> si2 = new List<string>();
            foreach (DrawObject o in objlist.Values)
            {
                if (o is vertex)
                    si.Add(o.getTikzString(cy));
                else
                    si2.Add(o.getTikzString(cy));
            }

            sb.AppendLine(String.Join("\r\n", si));
            sb.AppendLine("");
            sb.AppendLine(String.Join("\r\n", si2));

            sb.AppendLine("\\end{tikzpicture}");
            //sb.AppendLine("vert/.style={circle,draw,fill, minimum size=5pt, inner sep=0}, invvert/.style={inner sep=-1,minimum size=-1}, ext/.style={circle,draw, minimum size=5pt, inner sep=0}, scale=2 ]");

            return sb.ToString();
        }

        public static SizeF ConvertTikzPtsToScreenPtsSize(SizeF s, int pixelperunit)
        {
            return new SizeF(s.Width * pixelperunit / Consts.ptspertikzunit, s.Height * pixelperunit / Consts.ptspertikzunit);
        }
        public static PointF ConvertTikzPtsToScreenPtsPt(PointF s, int pixelperunit)
        {
            return new PointF(s.X * pixelperunit / Consts.ptspertikzunit, s.Y * pixelperunit / Consts.ptspertikzunit);
        }

        public static RectangleF ConvertTikzPtsToScreenPtsRect(RectangleF r, int pixelperunit)
        {
            return new RectangleF(ConvertTikzPtsToScreenPtsPt(r.Location, pixelperunit), ConvertTikzPtsToScreenPtsSize(r.Size, pixelperunit));
        }

        /// <summary>
        /// Obtains the object at position (x,y), in pixel coordinates.
        /// Uses the object positions/sizes from the last call to Draw(), i.e.,
        /// Draw() needs to be called before this method can be used.
        /// 
        /// In case there are multiple objects at position (x,y), a vertex 
        /// is returned rather than an edge, and an object further down (foreground)
        /// rather than one further up the list.
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The x coordinate</param>
        /// <param name="bestobj">(output) holds the Drawobject after return, </param>
        /// <param name="vertexonly">Determines whether vertices only should be considered.</param>
        /// <returns>true, if an object has been found at (x,y), false otherwise. (Then bestobj=null.)</returns>
        public bool objfromxy(double x, double y, out DrawObject bestobj, bool vertexonly)
        {
            float toler = Consts.selecttoler;
            bestobj = null;
            foreach (DrawObject o in objlist.Values)
                if (!vertexonly || (o is vertex) )
                {
                    if (o.intersectswith(new RectangleF((float)(x - toler), (float)(y - toler), 2 * toler, 2 * toler)))
                    {
                        if (bestobj == null || (bestobj is edge) || (o is vertex))
                            bestobj = o;
                    }
                }
            return (bestobj != null);
        }
        public bool vertfromxy(double x, double y, out vertex v)
        {
            DrawObject o;
            bool ret = objfromxy(x, y, out o, true);
            v = o as vertex;
            return ret;
        }

        /// <summary>
        /// Returns the number of selected vertices
        /// </summary>
        /// <returns></returns>
        public int GetSelCountV()
        {
            return objlist.Values.Count(v => ((v is vertex) && v.selected));
        }
        /// <summary>
        /// Returns the number of selected edges
        /// </summary>
        /// <returns></returns>
        public int GetSelCountE()
        {
            return objlist.Values.Count(v => ((v is edge) && v.selected));
        }

        public int GetStyleCount(DOType type)
        {
            return styles.Values.Count(v => (v.type == type));
        }

        public DrawObjectStyle GetFirstStyle(DOType type)
        {
            foreach (DrawObjectStyle dos in styles.Values)
            {
                if (dos.type == type)
                    return dos;
            }
            return null; // this should never happen
        }
    }
}