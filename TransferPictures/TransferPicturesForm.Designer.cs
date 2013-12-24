namespace TransferPictures
{
    partial class TransferPicturesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferPicturesForm));
            this.btn_TransferMedia = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMedia = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.treeListView = new BrightIdeasSoftware.TreeListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDestination = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIsDir = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCurrentPath = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnFiles = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabControl1.SuspendLayout();
            this.tabMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TransferMedia
            // 
            this.btn_TransferMedia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TransferMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TransferMedia.Location = new System.Drawing.Point(12, 12);
            this.btn_TransferMedia.Name = "btn_TransferMedia";
            this.btn_TransferMedia.Size = new System.Drawing.Size(150, 33);
            this.btn_TransferMedia.TabIndex = 0;
            this.btn_TransferMedia.Text = "Transfer Media";
            this.btn_TransferMedia.UseVisualStyleBackColor = true;
            this.btn_TransferMedia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_TransferMedia_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabMedia);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 392);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMedia
            // 
            this.tabMedia.Controls.Add(this.treeListView);
            this.tabMedia.Location = new System.Drawing.Point(4, 22);
            this.tabMedia.Name = "tabMedia";
            this.tabMedia.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedia.Size = new System.Drawing.Size(806, 366);
            this.tabMedia.TabIndex = 0;
            this.tabMedia.Text = "Media Storage";
            this.tabMedia.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(169, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(653, 32);
            this.progressBar.TabIndex = 2;
            // 
            // treeListView
            // 
            this.treeListView.AllColumns.Add(this.olvColumnName);
            this.treeListView.AllColumns.Add(this.olvColumnDate);
            this.treeListView.AllColumns.Add(this.olvColumnDestination);
            this.treeListView.AllColumns.Add(this.olvColumnIsDir);
            this.treeListView.AllColumns.Add(this.olvColumnCurrentPath);
            this.treeListView.AllColumns.Add(this.olvColumnFiles);
            this.treeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName,
            this.olvColumnDate,
            this.olvColumnDestination,
            this.olvColumnIsDir,
            this.olvColumnCurrentPath,
            this.olvColumnFiles});
            this.treeListView.Location = new System.Drawing.Point(7, 7);
            this.treeListView.Name = "treeListView";
            this.treeListView.OwnerDraw = true;
            this.treeListView.ShowGroups = false;
            this.treeListView.Size = new System.Drawing.Size(793, 353);
            this.treeListView.TabIndex = 1;
            this.treeListView.UseCompatibleStateImageBehavior = false;
            this.treeListView.View = System.Windows.Forms.View.Details;
            this.treeListView.VirtualMode = true;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.CellPadding = null;
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 168;
            // 
            // olvColumnDate
            // 
            this.olvColumnDate.AspectName = "Date";
            this.olvColumnDate.CellPadding = null;
            this.olvColumnDate.Text = "Date";
            this.olvColumnDate.Width = 101;
            // 
            // olvColumnDestination
            // 
            this.olvColumnDestination.AspectName = "DestinationFolder";
            this.olvColumnDestination.CellPadding = null;
            this.olvColumnDestination.Text = "Destination";
            this.olvColumnDestination.Width = 118;
            // 
            // olvColumnIsDir
            // 
            this.olvColumnIsDir.AspectName = "IsDirectory";
            this.olvColumnIsDir.CellPadding = null;
            this.olvColumnIsDir.Text = "Directory";
            // 
            // olvColumnCurrentPath
            // 
            this.olvColumnCurrentPath.AspectName = "CurrentPath";
            this.olvColumnCurrentPath.CellPadding = null;
            this.olvColumnCurrentPath.Text = "Current Path";
            this.olvColumnCurrentPath.Width = 161;
            // 
            // olvColumnFiles
            // 
            this.olvColumnFiles.AspectName = "Files.Count";
            this.olvColumnFiles.CellPadding = null;
            this.olvColumnFiles.Text = "Files";
            // 
            // TransferPicturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 455);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_TransferMedia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferPicturesForm";
            this.Text = "Transfer Pictures";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransferPicturesForm_FormClosed);
            this.Load += new System.EventHandler(this.TransferPicturesForm_Load);
            this.Shown += new System.EventHandler(this.TransferPicturesForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabMedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TransferMedia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMedia;
        private BrightIdeasSoftware.TreeListView treeListView;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnDate;
        private BrightIdeasSoftware.OLVColumn olvColumnDestination;
        private BrightIdeasSoftware.OLVColumn olvColumnIsDir;
        private BrightIdeasSoftware.OLVColumn olvColumnCurrentPath;
        private BrightIdeasSoftware.OLVColumn olvColumnFiles;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

