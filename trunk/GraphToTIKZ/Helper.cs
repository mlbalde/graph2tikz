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
using System.Drawing.Drawing2D;


namespace GraphToTIKZ
{
    static class Consts
    {
        public const float cmperin = 2.54F;
        public const float ptspertikzunit = 72.0F / cmperin;
        public const float TikzDefaultLinewidth = 0;
        public const string TikzDefaultFont = "Times";
        public const float TikzDefaultFontSize = 8F;
        public const int TikzImgResolution = 300; // resolution in dpi with which images are compiled

        public static string[] TikzArrowTipCodes = new string[] { "", ">", "<" };
        //public static DashStyle[] TikzToSystemDashStyle = new DashStyle[] { DashStyle.Solid, DashStyle.Dot, DashStyle.Dash };
        public static float[][] TikzToSystemDashPattern = new float[][] {
            new float[]{0.1F}, new float[]{.1F,.1F}, new float[]{.2F,.1F}
        };

        public const string cSettingsFile = "T2Gsettings.xml";
        public const string cMRUFile = "T2GMRU.xml";
        public const int MaxMRU = 10;
        public const string cStyleRepoFile = "StyleRepo.dat";

        public const string CoordinateVertexStyleName = "helper";

        public const string DoubleFormat = "#.####";

        public const float selecttoler = .01F;
        public const float drawXsize = .1F; // drawn for invisible vertices
        public const float coordvertexsize = .25F; // size of size zero vertex (to ease selection)

        //const string cLatex = "Pdflatex";
        //string cLatexPath = "pdflatex"; //@"C:\Program Files\MiKTeX 2.8\miktex\bin\pdfplatex.exe";
        public const string cTempFile = "temp_preview";         // for preview
        public const string cTempImgFile = "temp_previewtexts"; // for equation rendering
        public const string defaultCurFile = "<new graph>";
        public const string PreviewHeader =
        @"\documentclass[fleqn]{article}
\usepackage{tikz,amsmath, amssymb,bm,color}
\usepackage[margin=0cm,nohead]{geometry}
";

        public const string ImgHeader =
        @"\documentclass[fleqn]{article}
\usepackage{amsmath, amssymb,bm,color}
";

        public const string precompilation_args = "-ini -job-name=\"" + cTempFile + "\" \"&pdflatex " + cTempFile + "pre.tex\\dump\"";
        public const string precompilation_args_img = "-ini -job-name=\"" + cTempImgFile + "\" \"&latex " + cTempImgFile + "pre.tex\\dump\"";


    }

    static class Helper
    {
        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("USER32.dll")]
        public static extern int SendMessage(
          IntPtr hWnd, // handle to destination window
          uint Msg, // message
          int wParam, // first message parameter
          int lParam // second message parameter
          );
        [DllImport("User32.dll")]
        public static extern Boolean EnumChildWindows(IntPtr hWndParent, Delegate lpEnumFunc, int lParam);

        // Import GetFocus() from user32.dll
        [DllImport("user32.dll", CharSet = CharSet.Auto,
           CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr GetFocus();

        public static Control GetFocusControl()
        {
            Control focusControl = null;
            IntPtr focusHandle = GetFocus();
            if (focusHandle != IntPtr.Zero)
                // returns null if handle is not to a .NET control
                focusControl = Control.FromHandle(focusHandle);
            return focusControl;
        } 

        public static void GeneratePrecompiledHeaders()
        {
            StreamWriter s = new StreamWriter(Consts.cTempImgFile + "pre.tex");
            s.WriteLine(Consts.ImgHeader);
            s.Close();

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("latex");
            psi.Arguments = Consts.precompilation_args_img;
            psi.CreateNoWindow = true;
            p.StartInfo = psi;
            p.Start();

            s = new StreamWriter(Consts.cTempFile + "pre.tex");
            s.WriteLine(Consts.PreviewHeader);
            s.Close();

            p = new System.Diagnostics.Process();
            psi = new System.Diagnostics.ProcessStartInfo("pdflatex");
            psi.Arguments = Consts.precompilation_args;
            psi.CreateNoWindow = true;
            p.StartInfo = psi;
            p.Start();
        }

    }

    [Serializable]
    public class PointD
    {
        public double X = 0, Y = 0;
        public PointD(double x, double y) { X = x; Y = y; }
        public PointD() {  }
        /// <summary>
        /// Converts Euclidan coordinates to polar.
        /// </summary>
        /// <param name="p">Point in Euclidean coordinates.</param>
        /// <param name="polarcenter">The center of the (polar) coordinate system.</param>
        /// <returns>Point in polar coordinates. X coord.=radius, Y coord.=angle (in radians).</returns>
        public static PointD eucltopolar(PointD p, PointD polarcenter)
        {
            double xx = (double)p.X - polarcenter.X,
                   yy = (double)p.Y - polarcenter.Y;
            double angle = 0;
            if (xx < 0) angle = Math.PI + Math.Atan(yy / xx);
            else if (xx == 0 && yy > 0) angle = Math.PI / 2;
            else if (xx == 0 && yy < 0) angle = -Math.PI / 2;
            else angle = Math.Atan(yy / xx);
            return new PointD(Math.Sqrt(xx * xx + yy * yy), angle);
        }
        /// <summary>
        /// Converts polar coordinates to Euclidean.
        /// </summary>
        /// <param name="p">The point. p.X=radius, p.Y=angle (in radians)</param>
        /// <param name="polarcenter">The center of the (polar) coordinate system.</param>
        /// <returns>p in Euclidean coordinates.</returns>
        public static PointD polartoeucl(PointD p, PointD polarcenter)
        {
            return polartoeucl(p.X, p.Y, polarcenter);
        }
        public static PointD polartoeucl(double r, double phi, PointD polarcenter)
        {
            return new PointD(r * Math.Cos(phi) + polarcenter.X, r * Math.Sin(phi) + polarcenter.Y);
        }

        public static explicit operator PointF(PointD p)
        {
            return new PointF((float)p.X, (float)p.Y);
        }
        public static implicit operator PointD(PointF p)
        {
            return new PointD(p.X, p.Y);
        }
        public double Norm()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public static PointD operator +(PointD a, PointD b)
        {
            return new PointD(a.X + b.X, a.Y + b.Y);
        }
        public static PointD operator -(PointD a, PointD b)
        {
            return new PointD(a.X - b.X, a.Y - b.Y);
        }
        public static PointD operator *(double lambda, PointD a)
        {
            return new PointD(a.X *lambda, a.Y*lambda);
        }
        public static PointD operator *(PointD a, double lambda)
        {
            return lambda * a;
        }
        public static PointD operator -(PointD a)
        {
            return new PointD(-a.X, -a.Y);
        }
    }

    public static class Rasterizer
    {
        public static void DrawEuclRaster(Graphics g, double width, double height, double xstep, double ystep)
        {
            if (xstep <= 0 || ystep <= 0)
                return;
            Pen p = new Pen(Color.LightGray, 0); //1.0F / g.Transform.Elements[0]);
            for (float x = 0; x < width; x += (float)xstep)
                g.DrawLine(p, x, 0, x, (float)height);
            for (float y = 0; y < height; y += (float)ystep)
                g.DrawLine(p, 0, y, (float)width, y);
            /*  int cex = Convert.ToInt32(radialcenter.X * pixelperunit*G.scale),
                          cey = Convert.ToInt32(radialcenter.Y * pixelperunit*G.scale);
                      for (int i = 0; i < 360; i += step)
                      {
                          Point pp = radtopix(10 * (G.cx*G.scale + G.cy*G.scale), i);
                          g.DrawLine(plight, cex,cey, pp.X, pp.Y);
                      }
                      for (int j = 0; j < 2 * (drawme.Height + drawme.Width); j += step)
                      {

                          g.DrawEllipse(plight, cex-j,cey-j,2*j,2*j);
                      } */
        }

        public static void DrawPolarRaster(Graphics g, double width, double height, PointD center, double rstep, int nsectors)
        {
            if (rstep <= 0 || nsectors <= 0)
                return;
            Pen p = new Pen(Color.LightGray, 0);// 1.0F / g.Transform.Elements[0]);
            for (int i = 0; i < nsectors; i++)
            {
                PointF pp = (PointF)PointD.polartoeucl(width + height, i * 2 * Math.PI / nsectors, center);
                g.DrawLine(p, (PointF)center, pp);
            }
            for (float r = 0; r < width + height; r += (float)rstep)
            {
                g.DrawEllipse(p, (float)center.X - r, (float)center.Y - r, 2 * r, 2 * r);
            }

        }

        public static PointD rasterizeEucl(PointD p, double xstep, double ystep)
        {
            return new PointD(Math.Round(p.X / xstep) * xstep, Math.Round(p.Y / ystep) * ystep);
        }
        // input: p in Eucl. coordinates
        public static PointD rasterizePolar(PointD p, PointD center, double rstep, int nsectors)
        {
            PointD pp = PointD.eucltopolar(p, center);
            pp.X = Math.Round(pp.X / rstep) * rstep;
            pp.Y = Math.Round(pp.Y * nsectors / (2 * Math.PI)) * 2 * Math.PI / nsectors;
            return PointD.polartoeucl(pp, center);
        }

    }

    public class MRUList
    {
        public List<string> FileNames = new List<string>();
        public int Count
        {
            get { return FileNames.Count; }
        }
        private string cFilename;
        private int MaxItems;
        public MRUList(string cFile, int nMaxItems)
        {
            cFilename = cFile;
            MaxItems = nMaxItems;
            if (File.Exists(cFile))
            {
                XmlSerializer sMRU = new XmlSerializer(typeof(List<string>));
                FileStream fs = new FileStream(cFile, FileMode.Open);
                XmlReader r = new XmlTextReader(fs);
                if (sMRU.CanDeserialize(r))
                {
                    FileNames = (List<string>)sMRU.Deserialize(r);
                }
                r.Close();
            }
        }

        /// <summary>
        /// If File exists, move the file to first position.
        /// </summary>
        /// <param name="cFile">The file to add to the MRU List</param>
        public void Add(string cFile)
        {
            if (FileNames.Contains(cFile))
                FileNames.Remove(cFile);
            FileNames.Insert(0, cFile);

            if (FileNames.Count > MaxItems)
                FileNames.RemoveAt(FileNames.Count - 1);
        }

        public void Save()
        {
            // Serialization
            XmlSerializer sMRU = new XmlSerializer(typeof(List<string>));
            XmlSerializer s = new XmlSerializer(typeof(string));
            TextWriter w = new StreamWriter(cFilename);
            sMRU.Serialize(w, FileNames);
            w.Close();
        }
    }

    public static class LineCapBuilder
    {
        public static CustomLineCap ArrowHead;
        public static CustomLineCap InvArrowHead;
        public static CustomLineCap[] TikzTipToLineCap;
        static LineCapBuilder()
        {

            GraphicsPath hPath = new GraphicsPath(FillMode.Winding);

            // Create the outline for our custom end cap.
            //hPath.AddLine(new Point(0, 0), new Point(-30, -60));
            //hPath.AddLine(new Point(0, 0), new Point(30, -60));
            //hPath.AddLine(new Point(30,-60), new Point(-30,-60));
            hPath.AddLines(new Point[] { new Point(0, 0), new Point(-3, -6), new Point(3, -6), new Point(0, 0) });

            // Construct the hook-shaped end cap.
            CustomLineCap HookCap = new CustomLineCap(hPath, null);

            // Set the start cap and end cap of the HookCap to be rounded.
            HookCap.SetStrokeCaps(LineCap.Round, LineCap.Round);

            // Create a pen and set end custom start and end
            // caps to the hook cap.
            //Pen customCapPen = new Pen(Color.Black, 5);
            //customCapPen.CustomStartCap = HookCap;
            //customCapPen.CustomEndCap = HookCap;
            ArrowHead = HookCap;
            // Create a second pen using the start and end caps from
            // the hook cap.
            //Pen capPen = new Pen(Color.Red, 10);
            //LineCap startCap;
            //LineCap endCap;
            try
            {
                hPath = new GraphicsPath(FillMode.Winding);
                hPath.AddLines(new Point[] { new Point(0, -6), new Point(3, 0), new Point(-3, 0), new Point(0, -6) });
                HookCap = new CustomLineCap(hPath, null);
                HookCap.SetStrokeCaps(LineCap.Round, LineCap.Round);
                InvArrowHead = HookCap;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            //HookCap.GetStrokeCaps(out startCap, out endCap);
            //capPen.StartCap = startCap;
            //capPen.EndCap = endCap;


            TikzTipToLineCap = new CustomLineCap[] { null, ArrowHead, InvArrowHead };

        }

    }

    [Serializable]
    public class StyleRepoEntry
    {
        public DrawObjectStyle dos;
        public bool l;
        public StyleRepoEntry(DrawObjectStyle tdos, bool tl)
        {
            dos = tdos; l = tl;
        }
    }

    public static class StyleRepo
    {
        public static List<StyleRepoEntry> styles = new List<StyleRepoEntry>();
        static frmStyleRepo stylesForm = new frmStyleRepo();

        static IEnumerable<DrawObjectStyle> default_styles
            = from v in styles where v.l select v.dos;

        static StyleRepo()
        {
            // Load styles from file
            if (File.Exists(Consts.cStyleRepoFile))
            {
                Stream stream = File.Open(Consts.cStyleRepoFile, FileMode.Open);
                try
                {
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    styles = (List<StyleRepoEntry>)bFormatter.Deserialize(stream);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: Could not load style repository");
                }
                finally
                {
                    stream.Close();
                }
            }
        }

        public static void DeleteStyle(string cname)
        {
            StyleRepoEntry dosb = findStyle(cname);
            if (dosb != null)
                styles.Remove(dosb);
        }

        public static StyleRepoEntry findStyle(string cname)
        {
            return styles.Find(v => (v.dos.name == cname));
        }

        public static bool AddStyle(DrawObjectStyle dos)
        {
            // Check if style exists and ask user whether to replace
            StyleRepoEntry st = findStyle(dos.name);
            bool oldDef = false;
            if (st != null)
            {
                if (MessageBox.Show("A style with that name already exists. Replace it permanently (no undo possible)?",
                            "Warning: style exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) != DialogResult.Yes)
                    return false;

                styles.Remove(st);
            }

            styles.Add(new StyleRepoEntry(dos.copy(), oldDef));
            return true;
        }

        public static void ShowRepo(TikzGraph tG)
        {
            stylesForm.G = tG;
            stylesForm.FillStyleList();
            stylesForm.ShowDialog();
        }

        public static void Save()
        {
            // Save styles to file
            Stream stream = File.Open(Consts.cStyleRepoFile, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, styles);
            stream.Close();
        }

    }
}
