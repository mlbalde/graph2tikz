namespace GraphToTIKZ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.drawmepanel = new GraphToTIKZ.Custompanel();
            this.tabControl3 = new Dotnetrix.Controls.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshPreviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLatexPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.generateTikzCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStyleRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.procPdfLatex = new System.Diagnostics.Process();
            this.procDvipng = new System.Diagnostics.Process();
            this.procLatex = new System.Diagnostics.Process();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbGridsize = new System.Windows.Forms.ToolStripComboBox();
            this.chkRadial = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.cmbZoom = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmdSelectTool = new System.Windows.Forms.ToolStripButton();
            this.cmdHandTool = new System.Windows.Forms.ToolStripButton();
            this.cmdVertexTool = new System.Windows.Forms.ToolStripButton();
            this.cmdEdgeTool = new System.Windows.Forms.ToolStripButton();
            this.cmdPathTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chkUseImgs = new System.Windows.Forms.ToolStripButton();
            this.cmdPreview = new System.Windows.Forms.ToolStripButton();
            this.chkAutoUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdSetStyle = new System.Windows.Forms.Button();
            this.cmdNewEStyle = new System.Windows.Forms.Button();
            this.cmdDelStyle = new System.Windows.Forms.Button();
            this.cmdNewVStyle = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.procMuPdf = new System.Diagnostics.Process();
            this.lstStyles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStyles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToStyleRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVertexStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEdgeStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.assignToCurrentSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleStateImages = new System.Windows.Forms.ImageList(this.components);
            this.tabProperties = new System.Windows.Forms.TabControl();
            this.tabVertex = new System.Windows.Forms.TabPage();
            this.numlblpos = new System.Windows.Forms.NumericUpDown();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.tabEdge = new System.Windows.Forms.TabPage();
            this.numOutAngle = new System.Windows.Forms.NumericUpDown();
            this.numInAngle = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chkUseInOutAngles = new System.Windows.Forms.CheckBox();
            this.txtLabelBelow = new System.Windows.Forms.TextBox();
            this.txtLabelAbove = new System.Windows.Forms.TextBox();
            this.tabVStyle = new System.Windows.Forms.TabPage();
            this.flowLPStyleProps = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_spName = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnl_spLineStyle = new System.Windows.Forms.Panel();
            this.cmbDashStyle = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnl_spInnerSep = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numInner = new System.Windows.Forms.NumericUpDown();
            this.pnl_spOuterSep = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numOuter = new System.Windows.Forms.NumericUpDown();
            this.pnl_spMinSize = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.numMinsize = new System.Windows.Forms.NumericUpDown();
            this.pnl_spDraw = new System.Windows.Forms.Panel();
            this.chkDraw = new System.Windows.Forms.CheckBox();
            this.cmdDraw = new System.Windows.Forms.Button();
            this.pnl_spFill = new System.Windows.Forms.Panel();
            this.cmdFill = new System.Windows.Forms.Button();
            this.chkFill = new System.Windows.Forms.CheckBox();
            this.pnl_spShowX = new System.Windows.Forms.Panel();
            this.chkShowX = new System.Windows.Forms.CheckBox();
            this.pnl_spExtraFormat = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.pnl_spShape = new System.Windows.Forms.Panel();
            this.cmbVertexType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnl_spLineWidth = new System.Windows.Forms.Panel();
            this.numLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_spArrowTips = new System.Windows.Forms.Panel();
            this.cmbArrowTip = new System.Windows.Forms.ComboBox();
            this.cmbArrowTail = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStyles.SuspendLayout();
            this.tabProperties.SuspendLayout();
            this.tabVertex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numlblpos)).BeginInit();
            this.tabEdge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOutAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInAngle)).BeginInit();
            this.tabVStyle.SuspendLayout();
            this.flowLPStyleProps.SuspendLayout();
            this.pnl_spName.SuspendLayout();
            this.pnl_spLineStyle.SuspendLayout();
            this.pnl_spInnerSep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInner)).BeginInit();
            this.pnl_spOuterSep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOuter)).BeginInit();
            this.pnl_spMinSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinsize)).BeginInit();
            this.pnl_spDraw.SuspendLayout();
            this.pnl_spFill.SuspendLayout();
            this.pnl_spShowX.SuspendLayout();
            this.pnl_spExtraFormat.SuspendLayout();
            this.pnl_spShape.SuspendLayout();
            this.pnl_spLineWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLineWidth)).BeginInit();
            this.pnl_spArrowTips.SuspendLayout();
            this.tabGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.drawmepanel);
            this.splitContainer1.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl3);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(690, 540);
            this.splitContainer1.SplitterDistance = 412;
            this.splitContainer1.TabIndex = 4;
            // 
            // drawmepanel
            // 
            this.drawmepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.drawmepanel.AutoScroll = true;
            this.drawmepanel.Location = new System.Drawing.Point(0, 0);
            this.drawmepanel.Name = "drawmepanel";
            this.drawmepanel.Size = new System.Drawing.Size(690, 414);
            this.drawmepanel.TabIndex = 0;
            // 
            // tabControl3
            // 
            this.tabControl3.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Multiline = true;
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(690, 124);
            this.tabControl3.TabIndex = 0;
            this.tabControl3.Click += new System.EventHandler(this.tabControl2_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.txtStatus);
            this.tabPage7.Location = new System.Drawing.Point(24, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(662, 116);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Status";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(3, 3);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(656, 110);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Text = "";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.txtCode);
            this.tabPage8.Location = new System.Drawing.Point(24, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(662, 116);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Tikz Code";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(3, 3);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCode.Size = new System.Drawing.Size(656, 110);
            this.txtCode.TabIndex = 2;
            this.txtCode.Text = resources.GetString("txtCode.Text");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edge.bmp");
            this.imageList1.Images.SetKeyName(1, "bmpvert.bmp");
            this.imageList1.Images.SetKeyName(2, "ZoomInHS.bmp");
            this.imageList1.Images.SetKeyName(3, "ZoomOutHS.bmp");
            this.imageList1.Images.SetKeyName(4, "PointerHS.png");
            this.imageList1.Images.SetKeyName(5, "PlayHS.png");
            this.imageList1.Images.SetKeyName(6, "PrintPreviewHS.png");
            this.imageList1.Images.SetKeyName(7, "Properties.png");
            this.imageList1.Images.SetKeyName(8, "delete.png");
            this.imageList1.Images.SetKeyName(9, "126_Edit_16x16_72.png");
            this.imageList1.Images.SetKeyName(10, "077_AddFile_16x16_72.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.stylesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MenuActivate += new System.EventHandler(this.menuStrip1_MenuActivate);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.openRecentToolStripMenuItem,
            this.importFromClipboardToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToClipboardToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.action_NewFile);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.action_OpenFile);
            // 
            // openRecentToolStripMenuItem
            // 
            this.openRecentToolStripMenuItem.Name = "openRecentToolStripMenuItem";
            this.openRecentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openRecentToolStripMenuItem.Text = "Open Recent";
            // 
            // importFromClipboardToolStripMenuItem
            // 
            this.importFromClipboardToolStripMenuItem.Name = "importFromClipboardToolStripMenuItem";
            this.importFromClipboardToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.importFromClipboardToolStripMenuItem.Text = "Import from Clipboard";
            this.importFromClipboardToolStripMenuItem.Click += new System.EventHandler(this.action_ImportFromClipboard);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(191, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.action_SaveFile);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.action_SaveFileAs);
            // 
            // exportToClipboardToolStripMenuItem
            // 
            this.exportToClipboardToolStripMenuItem.Name = "exportToClipboardToolStripMenuItem";
            this.exportToClipboardToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exportToClipboardToolStripMenuItem.Text = "Export To Clipboard";
            this.exportToClipboardToolStripMenuItem.Click += new System.EventHandler(this.action_ExportToClipboard);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem1.Text = "&Undo";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.action_Undo);
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem1.Text = "&Redo";
            this.redoToolStripMenuItem1.Click += new System.EventHandler(this.action_Redo);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem1.Image")));
            this.cutToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem1.Text = "Cu&t";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.action_Cut);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem1.Image")));
            this.copyToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem1.Text = "&Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.action_Copy);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem1.Image")));
            this.pasteToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem1.Text = "&Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.action_Paste);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.action_DeleteSelection);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshPreviewsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshPreviewsToolStripMenuItem
            // 
            this.refreshPreviewsToolStripMenuItem.Name = "refreshPreviewsToolStripMenuItem";
            this.refreshPreviewsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshPreviewsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.refreshPreviewsToolStripMenuItem.Text = "Refresh Previews";
            this.refreshPreviewsToolStripMenuItem.Click += new System.EventHandler(this.action_refreshPreviews);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.setLatexPathToolStripMenuItem,
            this.toolStripMenuItem1,
            this.generateTikzCodeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // setLatexPathToolStripMenuItem
            // 
            this.setLatexPathToolStripMenuItem.Name = "setLatexPathToolStripMenuItem";
            this.setLatexPathToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.setLatexPathToolStripMenuItem.Text = "Set Latex Path";
            this.setLatexPathToolStripMenuItem.Click += new System.EventHandler(this.setLatexPathToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // generateTikzCodeToolStripMenuItem
            // 
            this.generateTikzCodeToolStripMenuItem.Name = "generateTikzCodeToolStripMenuItem";
            this.generateTikzCodeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.generateTikzCodeToolStripMenuItem.Text = "Generate Tikz code";
            this.generateTikzCodeToolStripMenuItem.Click += new System.EventHandler(this.cmdGenCode_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // stylesToolStripMenuItem
            // 
            this.stylesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStyleRepositoryToolStripMenuItem});
            this.stylesToolStripMenuItem.Name = "stylesToolStripMenuItem";
            this.stylesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.stylesToolStripMenuItem.Text = "Styles";
            // 
            // showStyleRepositoryToolStripMenuItem
            // 
            this.showStyleRepositoryToolStripMenuItem.Name = "showStyleRepositoryToolStripMenuItem";
            this.showStyleRepositoryToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.showStyleRepositoryToolStripMenuItem.Text = "Show Style Repository";
            this.showStyleRepositoryToolStripMenuItem.Click += new System.EventHandler(this.action_ShowStyleRepo);
            // 
            // procPdfLatex
            // 
            this.procPdfLatex.EnableRaisingEvents = true;
            this.procPdfLatex.StartInfo.Arguments = "temp_preview.tex";
            this.procPdfLatex.StartInfo.CreateNoWindow = true;
            this.procPdfLatex.StartInfo.Domain = "";
            this.procPdfLatex.StartInfo.FileName = "pdflatex";
            this.procPdfLatex.StartInfo.LoadUserProfile = false;
            this.procPdfLatex.StartInfo.Password = null;
            this.procPdfLatex.StartInfo.RedirectStandardError = true;
            this.procPdfLatex.StartInfo.RedirectStandardOutput = true;
            this.procPdfLatex.StartInfo.StandardErrorEncoding = null;
            this.procPdfLatex.StartInfo.StandardOutputEncoding = null;
            this.procPdfLatex.StartInfo.UserName = "";
            this.procPdfLatex.StartInfo.UseShellExecute = false;
            this.procPdfLatex.SynchronizingObject = this;
            this.procPdfLatex.Exited += new System.EventHandler(this.procPdfLatex_Exited);
            // 
            // procDvipng
            // 
            this.procDvipng.EnableRaisingEvents = true;
            this.procDvipng.StartInfo.CreateNoWindow = true;
            this.procDvipng.StartInfo.Domain = "";
            this.procDvipng.StartInfo.FileName = "dvipng";
            this.procDvipng.StartInfo.LoadUserProfile = false;
            this.procDvipng.StartInfo.Password = null;
            this.procDvipng.StartInfo.StandardErrorEncoding = null;
            this.procDvipng.StartInfo.StandardOutputEncoding = null;
            this.procDvipng.StartInfo.UserName = "";
            this.procDvipng.StartInfo.UseShellExecute = false;
            this.procDvipng.SynchronizingObject = this;
            this.procDvipng.Exited += new System.EventHandler(this.procDvipng_Exited);
            // 
            // procLatex
            // 
            this.procLatex.EnableRaisingEvents = true;
            this.procLatex.StartInfo.CreateNoWindow = true;
            this.procLatex.StartInfo.Domain = "";
            this.procLatex.StartInfo.FileName = "latex";
            this.procLatex.StartInfo.LoadUserProfile = false;
            this.procLatex.StartInfo.Password = null;
            this.procLatex.StartInfo.RedirectStandardOutput = true;
            this.procLatex.StartInfo.StandardErrorEncoding = null;
            this.procLatex.StartInfo.StandardOutputEncoding = null;
            this.procLatex.StartInfo.UserName = "";
            this.procLatex.StartInfo.UseShellExecute = false;
            this.procLatex.SynchronizingObject = this;
            this.procLatex.Exited += new System.EventHandler(this.procLatex_Exited_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripButton7,
            this.toolStripSeparator7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton5,
            this.toolStripSeparator11,
            this.toolStripLabel1,
            this.cmbGridsize,
            this.chkRadial,
            this.toolStripSeparator9,
            this.toolStripButton2,
            this.cmbZoom,
            this.toolStripButton3,
            this.toolStripSeparator10,
            this.toolStripLabel2,
            this.cmdSelectTool,
            this.cmdHandTool,
            this.cmdVertexTool,
            this.cmdEdgeTool,
            this.cmdPathTool,
            this.toolStripSeparator2,
            this.chkUseImgs,
            this.cmdPreview,
            this.chkAutoUpdate,
            this.toolStripSeparator8,
            this.toolStripButton1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(908, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.action_NewFile);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.action_OpenFile);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.action_SaveFile);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cmdPreview_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.action_Copy);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.action_Paste);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.ToolTipText = "Delete Selection";
            this.toolStripButton7.Click += new System.EventHandler(this.action_DeleteSelection);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.ToolTipText = "Import Tikz-String from Clipboard";
            this.toolStripButton8.Click += new System.EventHandler(this.action_ImportFromClipboard);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "toolStripButton9";
            this.toolStripButton9.ToolTipText = "Export Tikz-String to Clipboard";
            this.toolStripButton9.Click += new System.EventHandler(this.action_ExportToClipboard);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "cmdUpdateTikzCode";
            this.toolStripButton5.ToolTipText = "Update Tikz Code in Textbox below";
            this.toolStripButton5.Click += new System.EventHandler(this.action_UpdateTikzCode);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "Grid";
            // 
            // cmbGridsize
            // 
            this.cmbGridsize.Items.AddRange(new object[] {
            "0",
            "0.1",
            "0.2",
            "0.5",
            "1",
            "2",
            "5",
            "10"});
            this.cmbGridsize.Name = "cmbGridsize";
            this.cmbGridsize.Size = new System.Drawing.Size(75, 25);
            this.cmbGridsize.Text = "0.5";
            this.cmbGridsize.TextChanged += new System.EventHandler(this.numGridSize_ValueChanged);
            // 
            // chkRadial
            // 
            this.chkRadial.CheckOnClick = true;
            this.chkRadial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chkRadial.Image = ((System.Drawing.Image)(resources.GetObject("chkRadial.Image")));
            this.chkRadial.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.chkRadial.Name = "chkRadial";
            this.chkRadial.Size = new System.Drawing.Size(23, 22);
            this.chkRadial.Text = "toolStripButton1";
            this.chkRadial.ToolTipText = "Polar coordinates around currently selected node, or center of graph if no node s" +
                "elected";
            this.chkRadial.CheckedChanged += new System.EventHandler(this.chkRadial_CheckedChanged);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Zoom out";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // cmbZoom
            // 
            this.cmbZoom.Items.AddRange(new object[] {
            "25%",
            "50%",
            "75%",
            "100%",
            "125%",
            "150%",
            "200%",
            "300%",
            "400%",
            "500%",
            "750%",
            "1000%",
            "5000%"});
            this.cmbZoom.Name = "cmbZoom";
            this.cmbZoom.Size = new System.Drawing.Size(75, 25);
            this.cmbZoom.Text = "100%";
            this.cmbZoom.TextChanged += new System.EventHandler(this.cmbZoom_TextChanged);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Zoom in";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel2.Text = "Tools:";
            // 
            // cmdSelectTool
            // 
            this.cmdSelectTool.Checked = true;
            this.cmdSelectTool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmdSelectTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSelectTool.Image = ((System.Drawing.Image)(resources.GetObject("cmdSelectTool.Image")));
            this.cmdSelectTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSelectTool.Name = "cmdSelectTool";
            this.cmdSelectTool.Size = new System.Drawing.Size(23, 22);
            this.cmdSelectTool.Tag = "1";
            this.cmdSelectTool.Text = "Select";
            this.cmdSelectTool.Click += new System.EventHandler(this.toolSelector_Click);
            // 
            // cmdHandTool
            // 
            this.cmdHandTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdHandTool.Image = ((System.Drawing.Image)(resources.GetObject("cmdHandTool.Image")));
            this.cmdHandTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdHandTool.Name = "cmdHandTool";
            this.cmdHandTool.Size = new System.Drawing.Size(23, 22);
            this.cmdHandTool.Tag = "5";
            this.cmdHandTool.Text = "toolStripButton6";
            this.cmdHandTool.ToolTipText = "Hand tool";
            this.cmdHandTool.Click += new System.EventHandler(this.toolSelector_Click);
            // 
            // cmdVertexTool
            // 
            this.cmdVertexTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdVertexTool.Image = global::GraphToTIKZ.Resource1.bmpvert;
            this.cmdVertexTool.ImageTransparentColor = System.Drawing.Color.White;
            this.cmdVertexTool.Name = "cmdVertexTool";
            this.cmdVertexTool.Size = new System.Drawing.Size(23, 22);
            this.cmdVertexTool.Tag = "2";
            this.cmdVertexTool.Text = "toolStripButton5";
            this.cmdVertexTool.ToolTipText = "Add Node";
            this.cmdVertexTool.Click += new System.EventHandler(this.toolSelector_Click);
            // 
            // cmdEdgeTool
            // 
            this.cmdEdgeTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdEdgeTool.Image = ((System.Drawing.Image)(resources.GetObject("cmdEdgeTool.Image")));
            this.cmdEdgeTool.ImageTransparentColor = System.Drawing.Color.White;
            this.cmdEdgeTool.Name = "cmdEdgeTool";
            this.cmdEdgeTool.Size = new System.Drawing.Size(23, 22);
            this.cmdEdgeTool.Tag = "3";
            this.cmdEdgeTool.Text = "toolStripButton6";
            this.cmdEdgeTool.ToolTipText = "Add edge";
            this.cmdEdgeTool.Click += new System.EventHandler(this.toolSelector_Click);
            // 
            // cmdPathTool
            // 
            this.cmdPathTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPathTool.Image = ((System.Drawing.Image)(resources.GetObject("cmdPathTool.Image")));
            this.cmdPathTool.ImageTransparentColor = System.Drawing.Color.White;
            this.cmdPathTool.Name = "cmdPathTool";
            this.cmdPathTool.Size = new System.Drawing.Size(23, 22);
            this.cmdPathTool.Tag = "4";
            this.cmdPathTool.Text = "Add a path";
            this.cmdPathTool.ToolTipText = "Add a path (=multiple edges)";
            this.cmdPathTool.Click += new System.EventHandler(this.toolSelector_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // chkUseImgs
            // 
            this.chkUseImgs.CheckOnClick = true;
            this.chkUseImgs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chkUseImgs.Image = ((System.Drawing.Image)(resources.GetObject("chkUseImgs.Image")));
            this.chkUseImgs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkUseImgs.Name = "chkUseImgs";
            this.chkUseImgs.Size = new System.Drawing.Size(23, 22);
            this.chkUseImgs.Text = "chkUseImages";
            this.chkUseImgs.ToolTipText = "Toggle use of compiled Latex png\'s for the text";
            this.chkUseImgs.CheckedChanged += new System.EventHandler(this.chkUseImgs_CheckedChanged);
            // 
            // cmdPreview
            // 
            this.cmdPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPreview.Image = ((System.Drawing.Image)(resources.GetObject("cmdPreview.Image")));
            this.cmdPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPreview.Name = "cmdPreview";
            this.cmdPreview.Size = new System.Drawing.Size(23, 22);
            this.cmdPreview.Text = "toolStripButton7";
            this.cmdPreview.ToolTipText = "Bring up the previewer (mupdf) and recompile";
            this.cmdPreview.Click += new System.EventHandler(this.cmdPreview_Click);
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.CheckOnClick = true;
            this.chkAutoUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chkAutoUpdate.Image = ((System.Drawing.Image)(resources.GetObject("chkAutoUpdate.Image")));
            this.chkAutoUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(23, 22);
            this.chkAutoUpdate.Text = "toolStripButton5";
            this.chkAutoUpdate.ToolTipText = "Automatic recompilation and update of the preview window on/off";
            this.chkAutoUpdate.CheckedChanged += new System.EventHandler(this.chkAutoUpdate_CheckedChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // cmdSetStyle
            // 
            this.cmdSetStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSetStyle.Location = new System.Drawing.Point(868, 139);
            this.cmdSetStyle.Name = "cmdSetStyle";
            this.cmdSetStyle.Size = new System.Drawing.Size(28, 23);
            this.cmdSetStyle.TabIndex = 21;
            this.cmdSetStyle.Text = "S";
            this.toolTip1.SetToolTip(this.cmdSetStyle, "Assign selected style to current selection");
            this.cmdSetStyle.UseVisualStyleBackColor = true;
            this.cmdSetStyle.Click += new System.EventHandler(this.action_AssignStyle);
            // 
            // cmdNewEStyle
            // 
            this.cmdNewEStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNewEStyle.ImageIndex = 10;
            this.cmdNewEStyle.ImageList = this.imageList1;
            this.cmdNewEStyle.Location = new System.Drawing.Point(868, 81);
            this.cmdNewEStyle.Name = "cmdNewEStyle";
            this.cmdNewEStyle.Size = new System.Drawing.Size(28, 23);
            this.cmdNewEStyle.TabIndex = 23;
            this.toolTip1.SetToolTip(this.cmdNewEStyle, "Add new edge style");
            this.cmdNewEStyle.UseVisualStyleBackColor = true;
            this.cmdNewEStyle.Click += new System.EventHandler(this.action_NewStyle);
            // 
            // cmdDelStyle
            // 
            this.cmdDelStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDelStyle.ImageIndex = 8;
            this.cmdDelStyle.ImageList = this.imageList1;
            this.cmdDelStyle.Location = new System.Drawing.Point(868, 110);
            this.cmdDelStyle.Name = "cmdDelStyle";
            this.cmdDelStyle.Size = new System.Drawing.Size(28, 23);
            this.cmdDelStyle.TabIndex = 20;
            this.toolTip1.SetToolTip(this.cmdDelStyle, "Delete Style");
            this.cmdDelStyle.UseVisualStyleBackColor = true;
            this.cmdDelStyle.Click += new System.EventHandler(this.action_DeleteStyle);
            // 
            // cmdNewVStyle
            // 
            this.cmdNewVStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNewVStyle.ImageIndex = 10;
            this.cmdNewVStyle.ImageList = this.imageList1;
            this.cmdNewVStyle.Location = new System.Drawing.Point(868, 52);
            this.cmdNewVStyle.Name = "cmdNewVStyle";
            this.cmdNewVStyle.Size = new System.Drawing.Size(28, 23);
            this.cmdNewVStyle.TabIndex = 19;
            this.toolTip1.SetToolTip(this.cmdNewVStyle, "Add new vertex style");
            this.cmdNewVStyle.UseVisualStyleBackColor = true;
            this.cmdNewVStyle.Click += new System.EventHandler(this.action_NewStyle);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(868, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 26);
            this.button6.TabIndex = 16;
            this.toolTip1.SetToolTip(this.button6, "Change Style Name");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.action_ChangeStyleName);
            // 
            // procMuPdf
            // 
            this.procMuPdf.StartInfo.Domain = "";
            this.procMuPdf.StartInfo.FileName = "mupdf";
            this.procMuPdf.StartInfo.LoadUserProfile = false;
            this.procMuPdf.StartInfo.Password = null;
            this.procMuPdf.StartInfo.RedirectStandardInput = true;
            this.procMuPdf.StartInfo.StandardErrorEncoding = null;
            this.procMuPdf.StartInfo.StandardOutputEncoding = null;
            this.procMuPdf.StartInfo.UserName = "";
            this.procMuPdf.StartInfo.UseShellExecute = false;
            this.procMuPdf.SynchronizingObject = this;
            // 
            // lstStyles
            // 
            this.lstStyles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStyles.CheckBoxes = true;
            this.lstStyles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstStyles.ContextMenuStrip = this.contextMenuStyles;
            this.lstStyles.FullRowSelect = true;
            this.lstStyles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstStyles.HideSelection = false;
            this.lstStyles.LabelEdit = true;
            this.lstStyles.Location = new System.Drawing.Point(696, 52);
            this.lstStyles.MultiSelect = false;
            this.lstStyles.Name = "lstStyles";
            this.lstStyles.Size = new System.Drawing.Size(166, 142);
            this.lstStyles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstStyles.StateImageList = this.styleStateImages;
            this.lstStyles.TabIndex = 22;
            this.lstStyles.UseCompatibleStateImageBehavior = false;
            this.lstStyles.View = System.Windows.Forms.View.Details;
            this.lstStyles.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstStyles_AfterLabelEdit);
            this.lstStyles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstStyles_ItemCheck);
            this.lstStyles.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstStyles_ItemChecked);
            this.lstStyles.SelectedIndexChanged += new System.EventHandler(this.lstStyles_SelectedIndexChanged);
            this.lstStyles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstStyles_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stylename";
            this.columnHeader1.Width = 109;
            // 
            // contextMenuStyles
            // 
            this.contextMenuStyles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToStyleRepositoryToolStripMenuItem,
            this.addVertexStyleToolStripMenuItem,
            this.addEdgeStyleToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.assignToCurrentSelectionToolStripMenuItem});
            this.contextMenuStyles.Name = "contextMenuStyles";
            this.contextMenuStyles.Size = new System.Drawing.Size(216, 114);
            this.contextMenuStyles.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStyles_Opening);
            // 
            // addToStyleRepositoryToolStripMenuItem
            // 
            this.addToStyleRepositoryToolStripMenuItem.Name = "addToStyleRepositoryToolStripMenuItem";
            this.addToStyleRepositoryToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.addToStyleRepositoryToolStripMenuItem.Text = "Add to Style Repository";
            this.addToStyleRepositoryToolStripMenuItem.Click += new System.EventHandler(this.action_AddStyleToRepo);
            // 
            // addVertexStyleToolStripMenuItem
            // 
            this.addVertexStyleToolStripMenuItem.Name = "addVertexStyleToolStripMenuItem";
            this.addVertexStyleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.addVertexStyleToolStripMenuItem.Text = "Add Vertex Style";
            this.addVertexStyleToolStripMenuItem.Click += new System.EventHandler(this.action_NewStyle);
            // 
            // addEdgeStyleToolStripMenuItem
            // 
            this.addEdgeStyleToolStripMenuItem.Name = "addEdgeStyleToolStripMenuItem";
            this.addEdgeStyleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.addEdgeStyleToolStripMenuItem.Text = "Add Edge Style";
            this.addEdgeStyleToolStripMenuItem.Click += new System.EventHandler(this.action_NewStyle);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.action_DeleteStyle);
            // 
            // assignToCurrentSelectionToolStripMenuItem
            // 
            this.assignToCurrentSelectionToolStripMenuItem.Name = "assignToCurrentSelectionToolStripMenuItem";
            this.assignToCurrentSelectionToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.assignToCurrentSelectionToolStripMenuItem.Text = "Assign to current Selection";
            this.assignToCurrentSelectionToolStripMenuItem.Click += new System.EventHandler(this.action_AssignStyle);
            // 
            // styleStateImages
            // 
            this.styleStateImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("styleStateImages.ImageStream")));
            this.styleStateImages.TransparentColor = System.Drawing.Color.Transparent;
            this.styleStateImages.Images.SetKeyName(0, "empty.bmp");
            this.styleStateImages.Images.SetKeyName(1, "112_RightArrowShort_Green_16x16_72.png");
            // 
            // tabProperties
            // 
            this.tabProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabProperties.Controls.Add(this.tabVertex);
            this.tabProperties.Controls.Add(this.tabEdge);
            this.tabProperties.Controls.Add(this.tabVStyle);
            this.tabProperties.Controls.Add(this.tabGraph);
            this.tabProperties.Location = new System.Drawing.Point(696, 200);
            this.tabProperties.Name = "tabProperties";
            this.tabProperties.SelectedIndex = 0;
            this.tabProperties.Size = new System.Drawing.Size(212, 388);
            this.tabProperties.TabIndex = 18;
            // 
            // tabVertex
            // 
            this.tabVertex.Controls.Add(this.numlblpos);
            this.tabVertex.Controls.Add(this.txtLabel);
            this.tabVertex.Controls.Add(this.label11);
            this.tabVertex.Controls.Add(this.label10);
            this.tabVertex.Controls.Add(this.label9);
            this.tabVertex.Controls.Add(this.txtText);
            this.tabVertex.Location = new System.Drawing.Point(4, 22);
            this.tabVertex.Name = "tabVertex";
            this.tabVertex.Padding = new System.Windows.Forms.Padding(3);
            this.tabVertex.Size = new System.Drawing.Size(204, 362);
            this.tabVertex.TabIndex = 0;
            this.tabVertex.Text = "Vertex";
            this.tabVertex.UseVisualStyleBackColor = true;
            // 
            // numlblpos
            // 
            this.numlblpos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numlblpos.Location = new System.Drawing.Point(80, 143);
            this.numlblpos.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numlblpos.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numlblpos.Name = "numlblpos";
            this.numlblpos.Size = new System.Drawing.Size(88, 20);
            this.numlblpos.TabIndex = 20;
            this.numlblpos.ValueChanged += new System.EventHandler(this.changed_VertexOrEdgeProperties);
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(80, 117);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(100, 20);
            this.txtLabel.TabIndex = 19;
            this.txtLabel.TextChanged += new System.EventHandler(this.changed_VertexOrEdgeProperties);
            this.txtLabel.Leave += new System.EventHandler(this.txtText_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Label Pos.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Label";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Text";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(80, 86);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(106, 20);
            this.txtText.TabIndex = 9;
            this.txtText.TextChanged += new System.EventHandler(this.changed_VertexOrEdgeProperties);
            this.txtText.Leave += new System.EventHandler(this.txtText_Leave);
            // 
            // tabEdge
            // 
            this.tabEdge.Controls.Add(this.numOutAngle);
            this.tabEdge.Controls.Add(this.numInAngle);
            this.tabEdge.Controls.Add(this.label20);
            this.tabEdge.Controls.Add(this.label19);
            this.tabEdge.Controls.Add(this.label17);
            this.tabEdge.Controls.Add(this.label16);
            this.tabEdge.Controls.Add(this.chkUseInOutAngles);
            this.tabEdge.Controls.Add(this.txtLabelBelow);
            this.tabEdge.Controls.Add(this.txtLabelAbove);
            this.tabEdge.Location = new System.Drawing.Point(4, 22);
            this.tabEdge.Name = "tabEdge";
            this.tabEdge.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdge.Size = new System.Drawing.Size(204, 362);
            this.tabEdge.TabIndex = 1;
            this.tabEdge.Text = "Edge";
            this.tabEdge.UseVisualStyleBackColor = true;
            // 
            // numOutAngle
            // 
            this.numOutAngle.Location = new System.Drawing.Point(71, 75);
            this.numOutAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numOutAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numOutAngle.Name = "numOutAngle";
            this.numOutAngle.Size = new System.Drawing.Size(53, 20);
            this.numOutAngle.TabIndex = 9;
            this.numOutAngle.ValueChanged += new System.EventHandler(this.changed_VertexOrEdgeProperties);
            // 
            // numInAngle
            // 
            this.numInAngle.Location = new System.Drawing.Point(72, 48);
            this.numInAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numInAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numInAngle.Name = "numInAngle";
            this.numInAngle.Size = new System.Drawing.Size(52, 20);
            this.numInAngle.TabIndex = 8;
            this.numInAngle.ValueChanged += new System.EventHandler(this.changed_VertexOrEdgeProperties);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Out";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "In";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Label below";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Label above";
            // 
            // chkUseInOutAngles
            // 
            this.chkUseInOutAngles.AutoSize = true;
            this.chkUseInOutAngles.Location = new System.Drawing.Point(20, 25);
            this.chkUseInOutAngles.Name = "chkUseInOutAngles";
            this.chkUseInOutAngles.Size = new System.Drawing.Size(111, 17);
            this.chkUseInOutAngles.TabIndex = 3;
            this.chkUseInOutAngles.Text = "Use In-Out-angles";
            this.chkUseInOutAngles.UseVisualStyleBackColor = true;
            this.chkUseInOutAngles.CheckedChanged += new System.EventHandler(this.changed_VertexOrEdgeProperties);
            // 
            // txtLabelBelow
            // 
            this.txtLabelBelow.Location = new System.Drawing.Point(82, 159);
            this.txtLabelBelow.Name = "txtLabelBelow";
            this.txtLabelBelow.Size = new System.Drawing.Size(100, 20);
            this.txtLabelBelow.TabIndex = 5;
            this.txtLabelBelow.TextChanged += new System.EventHandler(this.changed_VertexOrEdgeProperties);
            // 
            // txtLabelAbove
            // 
            this.txtLabelAbove.Location = new System.Drawing.Point(82, 128);
            this.txtLabelAbove.Name = "txtLabelAbove";
            this.txtLabelAbove.Size = new System.Drawing.Size(100, 20);
            this.txtLabelAbove.TabIndex = 4;
            this.txtLabelAbove.TextChanged += new System.EventHandler(this.changed_VertexOrEdgeProperties);
            // 
            // tabVStyle
            // 
            this.tabVStyle.Controls.Add(this.flowLPStyleProps);
            this.tabVStyle.Location = new System.Drawing.Point(4, 22);
            this.tabVStyle.Name = "tabVStyle";
            this.tabVStyle.Padding = new System.Windows.Forms.Padding(3);
            this.tabVStyle.Size = new System.Drawing.Size(204, 362);
            this.tabVStyle.TabIndex = 2;
            this.tabVStyle.Text = "Style";
            this.tabVStyle.UseVisualStyleBackColor = true;
            // 
            // flowLPStyleProps
            // 
            this.flowLPStyleProps.AutoScroll = true;
            this.flowLPStyleProps.Controls.Add(this.pnl_spName);
            this.flowLPStyleProps.Controls.Add(this.pnl_spLineStyle);
            this.flowLPStyleProps.Controls.Add(this.pnl_spInnerSep);
            this.flowLPStyleProps.Controls.Add(this.pnl_spOuterSep);
            this.flowLPStyleProps.Controls.Add(this.pnl_spMinSize);
            this.flowLPStyleProps.Controls.Add(this.pnl_spDraw);
            this.flowLPStyleProps.Controls.Add(this.pnl_spFill);
            this.flowLPStyleProps.Controls.Add(this.pnl_spShowX);
            this.flowLPStyleProps.Controls.Add(this.pnl_spExtraFormat);
            this.flowLPStyleProps.Controls.Add(this.pnl_spShape);
            this.flowLPStyleProps.Controls.Add(this.pnl_spLineWidth);
            this.flowLPStyleProps.Controls.Add(this.pnl_spArrowTips);
            this.flowLPStyleProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLPStyleProps.Location = new System.Drawing.Point(3, 3);
            this.flowLPStyleProps.Name = "flowLPStyleProps";
            this.flowLPStyleProps.Size = new System.Drawing.Size(198, 356);
            this.flowLPStyleProps.TabIndex = 18;
            // 
            // pnl_spName
            // 
            this.pnl_spName.Controls.Add(this.label7);
            this.pnl_spName.Controls.Add(this.txtName);
            this.pnl_spName.Location = new System.Drawing.Point(3, 3);
            this.pnl_spName.Name = "pnl_spName";
            this.pnl_spName.Size = new System.Drawing.Size(175, 24);
            this.pnl_spName.TabIndex = 0;
            this.pnl_spName.Tag = "EVU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 0);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(89, 20);
            this.txtName.TabIndex = 12;
            // 
            // pnl_spLineStyle
            // 
            this.pnl_spLineStyle.Controls.Add(this.cmbDashStyle);
            this.pnl_spLineStyle.Controls.Add(this.label15);
            this.pnl_spLineStyle.Location = new System.Drawing.Point(3, 33);
            this.pnl_spLineStyle.Name = "pnl_spLineStyle";
            this.pnl_spLineStyle.Size = new System.Drawing.Size(175, 26);
            this.pnl_spLineStyle.TabIndex = 19;
            this.pnl_spLineStyle.Tag = "EU";
            // 
            // cmbDashStyle
            // 
            this.cmbDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDashStyle.FormattingEnabled = true;
            this.cmbDashStyle.Location = new System.Drawing.Point(82, 2);
            this.cmbDashStyle.Name = "cmbDashStyle";
            this.cmbDashStyle.Size = new System.Drawing.Size(87, 21);
            this.cmbDashStyle.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Dash Style";
            // 
            // pnl_spInnerSep
            // 
            this.pnl_spInnerSep.Controls.Add(this.label5);
            this.pnl_spInnerSep.Controls.Add(this.numInner);
            this.pnl_spInnerSep.Location = new System.Drawing.Point(3, 65);
            this.pnl_spInnerSep.Name = "pnl_spInnerSep";
            this.pnl_spInnerSep.Size = new System.Drawing.Size(175, 25);
            this.pnl_spInnerSep.TabIndex = 1;
            this.pnl_spInnerSep.Tag = "VU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Inner Sep";
            // 
            // numInner
            // 
            this.numInner.DecimalPlaces = 1;
            this.numInner.Location = new System.Drawing.Point(80, 4);
            this.numInner.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numInner.Name = "numInner";
            this.numInner.Size = new System.Drawing.Size(90, 20);
            this.numInner.TabIndex = 7;
            // 
            // pnl_spOuterSep
            // 
            this.pnl_spOuterSep.Controls.Add(this.label6);
            this.pnl_spOuterSep.Controls.Add(this.numOuter);
            this.pnl_spOuterSep.Location = new System.Drawing.Point(3, 96);
            this.pnl_spOuterSep.Name = "pnl_spOuterSep";
            this.pnl_spOuterSep.Size = new System.Drawing.Size(175, 24);
            this.pnl_spOuterSep.TabIndex = 2;
            this.pnl_spOuterSep.Tag = "VU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Outer Sep";
            // 
            // numOuter
            // 
            this.numOuter.DecimalPlaces = 1;
            this.numOuter.Location = new System.Drawing.Point(80, 2);
            this.numOuter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numOuter.Name = "numOuter";
            this.numOuter.Size = new System.Drawing.Size(90, 20);
            this.numOuter.TabIndex = 8;
            // 
            // pnl_spMinSize
            // 
            this.pnl_spMinSize.Controls.Add(this.label14);
            this.pnl_spMinSize.Controls.Add(this.numMinsize);
            this.pnl_spMinSize.Location = new System.Drawing.Point(3, 126);
            this.pnl_spMinSize.Name = "pnl_spMinSize";
            this.pnl_spMinSize.Size = new System.Drawing.Size(175, 25);
            this.pnl_spMinSize.TabIndex = 3;
            this.pnl_spMinSize.Tag = "VU";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Minimum Size";
            // 
            // numMinsize
            // 
            this.numMinsize.DecimalPlaces = 1;
            this.numMinsize.Location = new System.Drawing.Point(80, 3);
            this.numMinsize.Name = "numMinsize";
            this.numMinsize.Size = new System.Drawing.Size(89, 20);
            this.numMinsize.TabIndex = 20;
            // 
            // pnl_spDraw
            // 
            this.pnl_spDraw.Controls.Add(this.chkDraw);
            this.pnl_spDraw.Controls.Add(this.cmdDraw);
            this.pnl_spDraw.Location = new System.Drawing.Point(3, 157);
            this.pnl_spDraw.Name = "pnl_spDraw";
            this.pnl_spDraw.Size = new System.Drawing.Size(175, 30);
            this.pnl_spDraw.TabIndex = 4;
            this.pnl_spDraw.Tag = "EVU";
            // 
            // chkDraw
            // 
            this.chkDraw.AutoSize = true;
            this.chkDraw.Location = new System.Drawing.Point(3, 7);
            this.chkDraw.Name = "chkDraw";
            this.chkDraw.Size = new System.Drawing.Size(51, 17);
            this.chkDraw.TabIndex = 5;
            this.chkDraw.Text = "Draw";
            this.chkDraw.UseVisualStyleBackColor = true;
            this.chkDraw.CheckedChanged += new System.EventHandler(this.changed_StyleProperties);
            // 
            // cmdDraw
            // 
            this.cmdDraw.BackColor = System.Drawing.Color.Transparent;
            this.cmdDraw.Location = new System.Drawing.Point(80, 3);
            this.cmdDraw.Name = "cmdDraw";
            this.cmdDraw.Size = new System.Drawing.Size(75, 23);
            this.cmdDraw.TabIndex = 10;
            this.cmdDraw.UseVisualStyleBackColor = false;
            this.cmdDraw.Click += new System.EventHandler(this.cmdDraw_Click);
            // 
            // pnl_spFill
            // 
            this.pnl_spFill.Controls.Add(this.cmdFill);
            this.pnl_spFill.Controls.Add(this.chkFill);
            this.pnl_spFill.Location = new System.Drawing.Point(3, 193);
            this.pnl_spFill.Name = "pnl_spFill";
            this.pnl_spFill.Size = new System.Drawing.Size(175, 26);
            this.pnl_spFill.TabIndex = 5;
            this.pnl_spFill.Tag = "VU";
            // 
            // cmdFill
            // 
            this.cmdFill.Location = new System.Drawing.Point(82, 3);
            this.cmdFill.Name = "cmdFill";
            this.cmdFill.Size = new System.Drawing.Size(75, 23);
            this.cmdFill.TabIndex = 11;
            this.cmdFill.UseVisualStyleBackColor = true;
            this.cmdFill.Click += new System.EventHandler(this.cmdFill_Click);
            // 
            // chkFill
            // 
            this.chkFill.AutoSize = true;
            this.chkFill.Location = new System.Drawing.Point(3, 6);
            this.chkFill.Name = "chkFill";
            this.chkFill.Size = new System.Drawing.Size(38, 17);
            this.chkFill.TabIndex = 6;
            this.chkFill.Text = "Fill";
            this.chkFill.UseVisualStyleBackColor = true;
            this.chkFill.CheckedChanged += new System.EventHandler(this.changed_StyleProperties);
            // 
            // pnl_spShowX
            // 
            this.pnl_spShowX.Controls.Add(this.chkShowX);
            this.pnl_spShowX.Location = new System.Drawing.Point(3, 225);
            this.pnl_spShowX.Name = "pnl_spShowX";
            this.pnl_spShowX.Size = new System.Drawing.Size(175, 23);
            this.pnl_spShowX.TabIndex = 6;
            this.pnl_spShowX.Tag = "VU";
            // 
            // chkShowX
            // 
            this.chkShowX.AutoSize = true;
            this.chkShowX.Location = new System.Drawing.Point(3, 3);
            this.chkShowX.Name = "chkShowX";
            this.chkShowX.Size = new System.Drawing.Size(60, 17);
            this.chkShowX.TabIndex = 9;
            this.chkShowX.Text = "ShowX";
            this.chkShowX.UseVisualStyleBackColor = true;
            this.chkShowX.CheckedChanged += new System.EventHandler(this.changed_StyleProperties);
            // 
            // pnl_spExtraFormat
            // 
            this.pnl_spExtraFormat.Controls.Add(this.label8);
            this.pnl_spExtraFormat.Controls.Add(this.txtExtra);
            this.pnl_spExtraFormat.Location = new System.Drawing.Point(3, 254);
            this.pnl_spExtraFormat.Name = "pnl_spExtraFormat";
            this.pnl_spExtraFormat.Size = new System.Drawing.Size(175, 33);
            this.pnl_spExtraFormat.TabIndex = 7;
            this.pnl_spExtraFormat.Tag = "EVU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Extra Format";
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(80, 7);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(89, 20);
            this.txtExtra.TabIndex = 15;
            // 
            // pnl_spShape
            // 
            this.pnl_spShape.Controls.Add(this.cmbVertexType);
            this.pnl_spShape.Controls.Add(this.label12);
            this.pnl_spShape.Location = new System.Drawing.Point(3, 293);
            this.pnl_spShape.Name = "pnl_spShape";
            this.pnl_spShape.Size = new System.Drawing.Size(175, 26);
            this.pnl_spShape.TabIndex = 8;
            this.pnl_spShape.Tag = "VU";
            // 
            // cmbVertexType
            // 
            this.cmbVertexType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVertexType.FormattingEnabled = true;
            this.cmbVertexType.Location = new System.Drawing.Point(82, 2);
            this.cmbVertexType.Name = "cmbVertexType";
            this.cmbVertexType.Size = new System.Drawing.Size(87, 21);
            this.cmbVertexType.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Shape";
            // 
            // pnl_spLineWidth
            // 
            this.pnl_spLineWidth.Controls.Add(this.numLineWidth);
            this.pnl_spLineWidth.Controls.Add(this.label1);
            this.pnl_spLineWidth.Location = new System.Drawing.Point(3, 325);
            this.pnl_spLineWidth.Name = "pnl_spLineWidth";
            this.pnl_spLineWidth.Size = new System.Drawing.Size(175, 27);
            this.pnl_spLineWidth.TabIndex = 9;
            this.pnl_spLineWidth.Tag = "EVU";
            // 
            // numLineWidth
            // 
            this.numLineWidth.DecimalPlaces = 1;
            this.numLineWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numLineWidth.Location = new System.Drawing.Point(83, 4);
            this.numLineWidth.Name = "numLineWidth";
            this.numLineWidth.Size = new System.Drawing.Size(86, 20);
            this.numLineWidth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Line width";
            // 
            // pnl_spArrowTips
            // 
            this.pnl_spArrowTips.Controls.Add(this.cmbArrowTip);
            this.pnl_spArrowTips.Controls.Add(this.cmbArrowTail);
            this.pnl_spArrowTips.Controls.Add(this.label4);
            this.pnl_spArrowTips.Location = new System.Drawing.Point(3, 358);
            this.pnl_spArrowTips.Name = "pnl_spArrowTips";
            this.pnl_spArrowTips.Size = new System.Drawing.Size(175, 26);
            this.pnl_spArrowTips.TabIndex = 19;
            this.pnl_spArrowTips.Tag = "E";
            // 
            // cmbArrowTip
            // 
            this.cmbArrowTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArrowTip.FormattingEnabled = true;
            this.cmbArrowTip.Location = new System.Drawing.Point(130, 3);
            this.cmbArrowTip.Name = "cmbArrowTip";
            this.cmbArrowTip.Size = new System.Drawing.Size(40, 21);
            this.cmbArrowTip.TabIndex = 19;
            // 
            // cmbArrowTail
            // 
            this.cmbArrowTail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArrowTail.FormattingEnabled = true;
            this.cmbArrowTail.Location = new System.Drawing.Point(82, 2);
            this.cmbArrowTail.Name = "cmbArrowTail";
            this.cmbArrowTail.Size = new System.Drawing.Size(40, 21);
            this.cmbArrowTail.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Arrow Tips";
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.label13);
            this.tabGraph.Controls.Add(this.numScale);
            this.tabGraph.Controls.Add(this.numWidth);
            this.tabGraph.Controls.Add(this.label2);
            this.tabGraph.Controls.Add(this.label3);
            this.tabGraph.Controls.Add(this.numHeight);
            this.tabGraph.Location = new System.Drawing.Point(4, 22);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(204, 362);
            this.tabGraph.TabIndex = 3;
            this.tabGraph.Text = "Graph";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Scale";
            // 
            // numScale
            // 
            this.numScale.DecimalPlaces = 1;
            this.numScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numScale.Location = new System.Drawing.Point(65, 25);
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(41, 20);
            this.numScale.TabIndex = 12;
            this.numScale.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numScale.ValueChanged += new System.EventHandler(this.change_GraphProperties);
            // 
            // numWidth
            // 
            this.numWidth.DecimalPlaces = 1;
            this.numWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWidth.Location = new System.Drawing.Point(63, 60);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(43, 20);
            this.numWidth.TabIndex = 10;
            this.numWidth.ValueChanged += new System.EventHandler(this.change_GraphProperties);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height";
            // 
            // numHeight
            // 
            this.numHeight.DecimalPlaces = 1;
            this.numHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numHeight.Location = new System.Drawing.Point(63, 81);
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(43, 20);
            this.numHeight.TabIndex = 11;
            this.numHeight.ValueChanged += new System.EventHandler(this.change_GraphProperties);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 593);
            this.Controls.Add(this.cmdNewEStyle);
            this.Controls.Add(this.lstStyles);
            this.Controls.Add(this.cmdSetStyle);
            this.Controls.Add(this.cmdDelStyle);
            this.Controls.Add(this.cmdNewVStyle);
            this.Controls.Add(this.tabProperties);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button6);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GraphToTikz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStyles.ResumeLayout(false);
            this.tabProperties.ResumeLayout(false);
            this.tabVertex.ResumeLayout(false);
            this.tabVertex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numlblpos)).EndInit();
            this.tabEdge.ResumeLayout(false);
            this.tabEdge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOutAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInAngle)).EndInit();
            this.tabVStyle.ResumeLayout(false);
            this.flowLPStyleProps.ResumeLayout(false);
            this.pnl_spName.ResumeLayout(false);
            this.pnl_spName.PerformLayout();
            this.pnl_spLineStyle.ResumeLayout(false);
            this.pnl_spLineStyle.PerformLayout();
            this.pnl_spInnerSep.ResumeLayout(false);
            this.pnl_spInnerSep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInner)).EndInit();
            this.pnl_spOuterSep.ResumeLayout(false);
            this.pnl_spOuterSep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOuter)).EndInit();
            this.pnl_spMinSize.ResumeLayout(false);
            this.pnl_spMinSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinsize)).EndInit();
            this.pnl_spDraw.ResumeLayout(false);
            this.pnl_spDraw.PerformLayout();
            this.pnl_spFill.ResumeLayout(false);
            this.pnl_spFill.PerformLayout();
            this.pnl_spShowX.ResumeLayout(false);
            this.pnl_spShowX.PerformLayout();
            this.pnl_spExtraFormat.ResumeLayout(false);
            this.pnl_spExtraFormat.PerformLayout();
            this.pnl_spShape.ResumeLayout(false);
            this.pnl_spShape.PerformLayout();
            this.pnl_spLineWidth.ResumeLayout(false);
            this.pnl_spLineWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLineWidth)).EndInit();
            this.pnl_spArrowTips.ResumeLayout(false);
            this.pnl_spArrowTips.PerformLayout();
            this.tabGraph.ResumeLayout(false);
            this.tabGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setLatexPathToolStripMenuItem;
        private System.Diagnostics.Process procPdfLatex;
        private System.Diagnostics.Process procDvipng;
        private System.Diagnostics.Process procLatex;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbGridsize;
        private System.Windows.Forms.ToolStripButton chkRadial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripComboBox cmbZoom;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton cmdSelectTool;
        private System.Windows.Forms.ToolStripButton cmdVertexTool;
        private System.Windows.Forms.ToolStripButton cmdEdgeTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton cmdPreview;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generateTikzCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton chkUseImgs;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Diagnostics.Process procMuPdf;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton chkAutoUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private Dotnetrix.Controls.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button cmdNewEStyle;
        private System.Windows.Forms.ListView lstStyles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button cmdSetStyle;
        private System.Windows.Forms.Button cmdDelStyle;
        private System.Windows.Forms.Button cmdNewVStyle;
        private System.Windows.Forms.TabControl tabProperties;
        private System.Windows.Forms.TabPage tabVertex;
        private System.Windows.Forms.NumericUpDown numlblpos;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TabPage tabEdge;
        private System.Windows.Forms.TabPage tabVStyle;
        private System.Windows.Forms.NumericUpDown numMinsize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbVertexType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdFill;
        private System.Windows.Forms.Button cmdDraw;
        private System.Windows.Forms.CheckBox chkShowX;
        private System.Windows.Forms.NumericUpDown numOuter;
        private System.Windows.Forms.NumericUpDown numInner;
        private System.Windows.Forms.CheckBox chkFill;
        private System.Windows.Forms.CheckBox chkDraw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numScale;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.FlowLayoutPanel flowLPStyleProps;
        private System.Windows.Forms.Panel pnl_spName;
        private System.Windows.Forms.Panel pnl_spInnerSep;
        private System.Windows.Forms.Panel pnl_spOuterSep;
        private System.Windows.Forms.Panel pnl_spMinSize;
        private System.Windows.Forms.Panel pnl_spDraw;
        private System.Windows.Forms.Panel pnl_spFill;
        private System.Windows.Forms.Panel pnl_spShowX;
        private System.Windows.Forms.Panel pnl_spExtraFormat;
        private System.Windows.Forms.Panel pnl_spShape;
        private System.Windows.Forms.Panel pnl_spLineWidth;
        private System.Windows.Forms.NumericUpDown numLineWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_spLineStyle;
        private System.Windows.Forms.ComboBox cmbDashStyle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnl_spArrowTips;
        private System.Windows.Forms.ComboBox cmbArrowTip;
        private System.Windows.Forms.ComboBox cmbArrowTail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshPreviewsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStyles;
        private System.Windows.Forms.ToolStripMenuItem addToStyleRepositoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVertexStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEdgeStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem assignToCurrentSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStyleRepositoryToolStripMenuItem;
        private System.Windows.Forms.ImageList styleStateImages;
        private Custompanel drawmepanel;
        private System.Windows.Forms.ToolStripButton cmdPathTool;
        private System.Windows.Forms.ToolStripButton cmdHandTool;
        private System.Windows.Forms.NumericUpDown numOutAngle;
        private System.Windows.Forms.NumericUpDown numInAngle;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkUseInOutAngles;
        private System.Windows.Forms.TextBox txtLabelBelow;
        private System.Windows.Forms.TextBox txtLabelAbove;

    }
}

