namespace Masasamjant.FileRenameManager
{
    partial class FolderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderForm));
            this.groupFolder = new System.Windows.Forms.GroupBox();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.folderFormImageList = new System.Windows.Forms.ImageList(this.components);
            this.textFolder = new System.Windows.Forms.TextBox();
            this.groupFiles = new System.Windows.Forms.GroupBox();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeaderFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupFileOptions = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textExclude = new System.Windows.Forms.TextBox();
            this.labelExclude = new System.Windows.Forms.Label();
            this.checkSelectAllFiles = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTipExclude = new System.Windows.Forms.ToolTip(this.components);
            this.groupFolder.SuspendLayout();
            this.groupFiles.SuspendLayout();
            this.groupFileOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFolder
            // 
            resources.ApplyResources(this.groupFolder, "groupFolder");
            this.groupFolder.Controls.Add(this.buttonFolder);
            this.groupFolder.Controls.Add(this.textFolder);
            this.groupFolder.Name = "groupFolder";
            this.groupFolder.TabStop = false;
            this.toolTipExclude.SetToolTip(this.groupFolder, resources.GetString("groupFolder.ToolTip"));
            // 
            // buttonFolder
            // 
            resources.ApplyResources(this.buttonFolder, "buttonFolder");
            this.buttonFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonFolder.ImageList = this.folderFormImageList;
            this.buttonFolder.Name = "buttonFolder";
            this.toolTipExclude.SetToolTip(this.buttonFolder, resources.GetString("buttonFolder.ToolTip"));
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.OnButtonFolderClick);
            // 
            // folderFormImageList
            // 
            this.folderFormImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("folderFormImageList.ImageStream")));
            this.folderFormImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.folderFormImageList.Images.SetKeyName(0, "Folder.png");
            this.folderFormImageList.Images.SetKeyName(1, "Refresh.png");
            // 
            // textFolder
            // 
            resources.ApplyResources(this.textFolder, "textFolder");
            this.textFolder.Name = "textFolder";
            this.textFolder.ReadOnly = true;
            this.toolTipExclude.SetToolTip(this.textFolder, resources.GetString("textFolder.ToolTip"));
            // 
            // groupFiles
            // 
            resources.ApplyResources(this.groupFiles, "groupFiles");
            this.groupFiles.Controls.Add(this.listViewFiles);
            this.groupFiles.Controls.Add(this.groupFileOptions);
            this.groupFiles.Name = "groupFiles";
            this.groupFiles.TabStop = false;
            this.toolTipExclude.SetToolTip(this.groupFiles, resources.GetString("groupFiles.ToolTip"));
            // 
            // listViewFiles
            // 
            resources.ApplyResources(this.listViewFiles, "listViewFiles");
            this.listViewFiles.CheckBoxes = true;
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFile});
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.OwnerDraw = true;
            this.toolTipExclude.SetToolTip(this.listViewFiles, resources.GetString("listViewFiles.ToolTip"));
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.OnListViewFilesDrawColumnHeader);
            this.listViewFiles.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.OnListViewFilesDrawItem);
            this.listViewFiles.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.OnListViewFilesDrawSubItem);
            // 
            // columnHeaderFile
            // 
            resources.ApplyResources(this.columnHeaderFile, "columnHeaderFile");
            // 
            // groupFileOptions
            // 
            resources.ApplyResources(this.groupFileOptions, "groupFileOptions");
            this.groupFileOptions.Controls.Add(this.buttonRefresh);
            this.groupFileOptions.Controls.Add(this.textExclude);
            this.groupFileOptions.Controls.Add(this.labelExclude);
            this.groupFileOptions.Controls.Add(this.checkSelectAllFiles);
            this.groupFileOptions.Name = "groupFileOptions";
            this.groupFileOptions.TabStop = false;
            this.toolTipExclude.SetToolTip(this.groupFileOptions, resources.GetString("groupFileOptions.ToolTip"));
            // 
            // buttonRefresh
            // 
            resources.ApplyResources(this.buttonRefresh, "buttonRefresh");
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRefresh.ImageList = this.folderFormImageList;
            this.buttonRefresh.Name = "buttonRefresh";
            this.toolTipExclude.SetToolTip(this.buttonRefresh, resources.GetString("buttonRefresh.ToolTip"));
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.OnButtonRefreshClick);
            // 
            // textExclude
            // 
            resources.ApplyResources(this.textExclude, "textExclude");
            this.textExclude.Name = "textExclude";
            this.toolTipExclude.SetToolTip(this.textExclude, resources.GetString("textExclude.ToolTip"));
            // 
            // labelExclude
            // 
            resources.ApplyResources(this.labelExclude, "labelExclude");
            this.labelExclude.Name = "labelExclude";
            this.toolTipExclude.SetToolTip(this.labelExclude, resources.GetString("labelExclude.ToolTip"));
            // 
            // checkSelectAllFiles
            // 
            resources.ApplyResources(this.checkSelectAllFiles, "checkSelectAllFiles");
            this.checkSelectAllFiles.Checked = true;
            this.checkSelectAllFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSelectAllFiles.Name = "checkSelectAllFiles";
            this.toolTipExclude.SetToolTip(this.checkSelectAllFiles, resources.GetString("checkSelectAllFiles.ToolTip"));
            this.checkSelectAllFiles.UseVisualStyleBackColor = true;
            this.checkSelectAllFiles.CheckedChanged += new System.EventHandler(this.OnCheckSelectAllFilesCheckedChanged);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.toolTipExclude.SetToolTip(this.buttonCancel, resources.GetString("buttonCancel.ToolTip"));
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // buttonAccept
            // 
            resources.ApplyResources(this.buttonAccept, "buttonAccept");
            this.buttonAccept.Name = "buttonAccept";
            this.toolTipExclude.SetToolTip(this.buttonAccept, resources.GetString("buttonAccept.ToolTip"));
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.OnButtonAcceptClick);
            // 
            // folderBrowserDialog
            // 
            resources.ApplyResources(this.folderBrowserDialog, "folderBrowserDialog");
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // FolderForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupFiles);
            this.Controls.Add(this.groupFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FolderForm";
            this.toolTipExclude.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.OnFolderFormLoad);
            this.groupFolder.ResumeLayout(false);
            this.groupFolder.PerformLayout();
            this.groupFiles.ResumeLayout(false);
            this.groupFileOptions.ResumeLayout(false);
            this.groupFileOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFolder;
        private System.Windows.Forms.TextBox textFolder;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.ImageList folderFormImageList;
        private System.Windows.Forms.GroupBox groupFiles;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.GroupBox groupFileOptions;
        private System.Windows.Forms.TextBox textExclude;
        private System.Windows.Forms.Label labelExclude;
        private System.Windows.Forms.CheckBox checkSelectAllFiles;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ColumnHeader columnHeaderFile;
        private System.Windows.Forms.ToolTip toolTipExclude;
        private System.Windows.Forms.Button buttonRefresh;
    }
}