namespace Masasamjant.FileRenameManager
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textExcluceExtensions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericMaxFiles = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBrowseLogLocation = new System.Windows.Forms.Button();
            this.optionsImageList = new System.Windows.Forms.ImageList(this.components);
            this.textLogFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.logFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.checkShowFullFilePaths = new System.Windows.Forms.CheckBox();
            this.checkShowSingleFileNameColumn = new System.Windows.Forms.CheckBox();
            this.checkRememberLastSelectedFolder = new System.Windows.Forms.CheckBox();
            this.panelRestartMessage = new System.Windows.Forms.Panel();
            this.labelRestartMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxFiles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxOther.SuspendLayout();
            this.panelRestartMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textExcluceExtensions);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericMaxFiles);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textExcluceExtensions
            // 
            resources.ApplyResources(this.textExcluceExtensions, "textExcluceExtensions");
            this.textExcluceExtensions.Name = "textExcluceExtensions";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // numericMaxFiles
            // 
            resources.ApplyResources(this.numericMaxFiles, "numericMaxFiles");
            this.numericMaxFiles.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericMaxFiles.Name = "numericMaxFiles";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonBrowseLogLocation);
            this.groupBox2.Controls.Add(this.textLogFolder);
            this.groupBox2.Controls.Add(this.label4);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // buttonBrowseLogLocation
            // 
            this.buttonBrowseLogLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonBrowseLogLocation, "buttonBrowseLogLocation");
            this.buttonBrowseLogLocation.ImageList = this.optionsImageList;
            this.buttonBrowseLogLocation.Name = "buttonBrowseLogLocation";
            this.buttonBrowseLogLocation.UseVisualStyleBackColor = true;
            this.buttonBrowseLogLocation.Click += new System.EventHandler(this.OnButtonBrowseLogLocationClick);
            // 
            // optionsImageList
            // 
            this.optionsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("optionsImageList.ImageStream")));
            this.optionsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.optionsImageList.Images.SetKeyName(0, "Folder.png");
            // 
            // textLogFolder
            // 
            resources.ApplyResources(this.textLogFolder, "textLogFolder");
            this.textLogFolder.Name = "textLogFolder";
            this.textLogFolder.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.OnButtonOkClick);
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.Controls.Add(this.checkShowFullFilePaths);
            this.groupBoxOther.Controls.Add(this.checkShowSingleFileNameColumn);
            this.groupBoxOther.Controls.Add(this.checkRememberLastSelectedFolder);
            resources.ApplyResources(this.groupBoxOther, "groupBoxOther");
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.TabStop = false;
            // 
            // checkShowFullFilePaths
            // 
            resources.ApplyResources(this.checkShowFullFilePaths, "checkShowFullFilePaths");
            this.checkShowFullFilePaths.Name = "checkShowFullFilePaths";
            this.checkShowFullFilePaths.UseVisualStyleBackColor = true;
            this.checkShowFullFilePaths.CheckedChanged += new System.EventHandler(this.OnCheckShowFullFilePathsCheckedChanged);
            // 
            // checkShowSingleFileNameColumn
            // 
            resources.ApplyResources(this.checkShowSingleFileNameColumn, "checkShowSingleFileNameColumn");
            this.checkShowSingleFileNameColumn.Name = "checkShowSingleFileNameColumn";
            this.checkShowSingleFileNameColumn.UseVisualStyleBackColor = true;
            this.checkShowSingleFileNameColumn.CheckedChanged += new System.EventHandler(this.OnCheckShowSingleFileNameColumnCheckedChanged);
            // 
            // checkRememberLastSelectedFolder
            // 
            resources.ApplyResources(this.checkRememberLastSelectedFolder, "checkRememberLastSelectedFolder");
            this.checkRememberLastSelectedFolder.Name = "checkRememberLastSelectedFolder";
            this.checkRememberLastSelectedFolder.UseVisualStyleBackColor = true;
            // 
            // panelRestartMessage
            // 
            this.panelRestartMessage.Controls.Add(this.labelRestartMessage);
            this.panelRestartMessage.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panelRestartMessage, "panelRestartMessage");
            this.panelRestartMessage.Name = "panelRestartMessage";
            // 
            // labelRestartMessage
            // 
            resources.ApplyResources(this.labelRestartMessage, "labelRestartMessage");
            this.labelRestartMessage.Name = "labelRestartMessage";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // OptionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRestartMessage);
            this.Controls.Add(this.groupBoxOther);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionsForm";
            this.Load += new System.EventHandler(this.OnOptionsFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxFiles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxOther.ResumeLayout(false);
            this.groupBoxOther.PerformLayout();
            this.panelRestartMessage.ResumeLayout(false);
            this.panelRestartMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericMaxFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textExcluceExtensions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBrowseLogLocation;
        private System.Windows.Forms.ImageList optionsImageList;
        private System.Windows.Forms.TextBox textLogFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog logFolderDialog;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.CheckBox checkRememberLastSelectedFolder;
        private System.Windows.Forms.Panel panelRestartMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRestartMessage;
        private System.Windows.Forms.CheckBox checkShowSingleFileNameColumn;
        private System.Windows.Forms.CheckBox checkShowFullFilePaths;
    }
}