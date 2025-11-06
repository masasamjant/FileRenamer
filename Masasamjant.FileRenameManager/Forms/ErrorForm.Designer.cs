namespace Masasamjant.FileRenameManager
{
    partial class ErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBehavior = new System.Windows.Forms.ComboBox();
            this.labelBehavior = new System.Windows.Forms.Label();
            this.checkSkipPrompt = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.comboBehavior);
            this.groupBox1.Controls.Add(this.labelBehavior);
            this.groupBox1.Controls.Add(this.checkSkipPrompt);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // comboBehavior
            // 
            resources.ApplyResources(this.comboBehavior, "comboBehavior");
            this.comboBehavior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBehavior.FormattingEnabled = true;
            this.comboBehavior.Items.AddRange(new object[] {
            resources.GetString("comboBehavior.Items"),
            resources.GetString("comboBehavior.Items1"),
            resources.GetString("comboBehavior.Items2")});
            this.comboBehavior.Name = "comboBehavior";
            this.comboBehavior.SelectedIndexChanged += new System.EventHandler(this.OnComboBehaviorSelectedIndexChanged);
            // 
            // labelBehavior
            // 
            resources.ApplyResources(this.labelBehavior, "labelBehavior");
            this.labelBehavior.Name = "labelBehavior";
            // 
            // checkSkipPrompt
            // 
            resources.ApplyResources(this.checkSkipPrompt, "checkSkipPrompt");
            this.checkSkipPrompt.Name = "checkSkipPrompt";
            this.checkSkipPrompt.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OnButtonOKClick);
            // 
            // ErrorForm
            // 
            this.AcceptButton = this.buttonOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ErrorForm";
            this.Load += new System.EventHandler(this.OnErrorFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelBehavior;
        private System.Windows.Forms.CheckBox checkSkipPrompt;
        private System.Windows.Forms.ComboBox comboBehavior;
        private System.Windows.Forms.Button buttonOK;
    }
}