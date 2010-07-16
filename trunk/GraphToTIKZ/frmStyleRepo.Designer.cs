namespace GraphToTIKZ
{
    partial class frmStyleRepo
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStyleRepo));
            this.lstRepoStyles = new System.Windows.Forms.ListView();
            this.colDef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdRename = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdAddToGraph = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdDefault = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRepoStyles
            // 
            this.lstRepoStyles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRepoStyles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colType,
            this.colDef});
            this.lstRepoStyles.FullRowSelect = true;
            this.lstRepoStyles.HideSelection = false;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.lstRepoStyles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lstRepoStyles.LabelEdit = true;
            this.lstRepoStyles.Location = new System.Drawing.Point(12, 12);
            this.lstRepoStyles.Name = "lstRepoStyles";
            this.lstRepoStyles.Size = new System.Drawing.Size(300, 318);
            this.lstRepoStyles.TabIndex = 0;
            this.lstRepoStyles.UseCompatibleStateImageBehavior = false;
            this.lstRepoStyles.View = System.Windows.Forms.View.Details;
            this.lstRepoStyles.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstRepoStyles_AfterLabelEdit);
            this.lstRepoStyles.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstRepoStyles_ItemChecked);
            this.lstRepoStyles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstRepoStyles_KeyDown);
            // 
            // colDef
            // 
            this.colDef.Text = "Default";
            this.colDef.Width = 48;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 209;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 37;
            // 
            // cmdRename
            // 
            this.cmdRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRename.ImageIndex = 9;
            this.cmdRename.ImageList = this.imageList1;
            this.cmdRename.Location = new System.Drawing.Point(318, 74);
            this.cmdRename.Name = "cmdRename";
            this.cmdRename.Size = new System.Drawing.Size(35, 23);
            this.cmdRename.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmdRename, "Change Style name");
            this.cmdRename.UseVisualStyleBackColor = true;
            this.cmdRename.Click += new System.EventHandler(this.cmdRename_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDelete.ImageIndex = 8;
            this.cmdDelete.ImageList = this.imageList1;
            this.cmdDelete.Location = new System.Drawing.Point(318, 103);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(35, 23);
            this.cmdDelete.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cmdDelete, "Delete Style");
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdAddToGraph
            // 
            this.cmdAddToGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddToGraph.ImageIndex = 5;
            this.cmdAddToGraph.ImageList = this.imageList1;
            this.cmdAddToGraph.Location = new System.Drawing.Point(318, 179);
            this.cmdAddToGraph.Name = "cmdAddToGraph";
            this.cmdAddToGraph.Size = new System.Drawing.Size(35, 23);
            this.cmdAddToGraph.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmdAddToGraph, "Add to graph");
            this.cmdAddToGraph.UseVisualStyleBackColor = true;
            this.cmdAddToGraph.Click += new System.EventHandler(this.cmdAddToGraph_Click);
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
            // cmdDefault
            // 
            this.cmdDefault.Location = new System.Drawing.Point(318, 132);
            this.cmdDefault.Name = "cmdDefault";
            this.cmdDefault.Size = new System.Drawing.Size(35, 23);
            this.cmdDefault.TabIndex = 4;
            this.cmdDefault.Text = "Def";
            this.toolTip1.SetToolTip(this.cmdDefault, "Set/unset the selected style as default for new graphs");
            this.cmdDefault.UseVisualStyleBackColor = true;
            this.cmdDefault.Click += new System.EventHandler(this.cmdDefault_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.Location = new System.Drawing.Point(318, 307);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(35, 23);
            this.cmdOK.TabIndex = 5;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // frmStyleRepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 342);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdDefault);
            this.Controls.Add(this.cmdAddToGraph);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdRename);
            this.Controls.Add(this.lstRepoStyles);
            this.Name = "frmStyleRepo";
            this.Text = "frmStyleRepo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStyleRepo_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstRepoStyles;
        private System.Windows.Forms.ColumnHeader colDef;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.Button cmdRename;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdAddToGraph;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdDefault;
        private System.Windows.Forms.Button cmdOK;
    }
}