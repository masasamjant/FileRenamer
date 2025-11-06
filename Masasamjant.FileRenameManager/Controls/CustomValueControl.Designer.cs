namespace Masasamjant.FileRenameManager
{
    partial class CustomValueControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomValueControl));
            this.labelValue = new System.Windows.Forms.Label();
            this.textValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelValue
            // 
            resources.ApplyResources(this.labelValue, "labelValue");
            this.labelValue.Name = "labelValue";
            // 
            // textValue
            // 
            resources.ApplyResources(this.textValue, "textValue");
            this.textValue.Name = "textValue";
            this.textValue.TextChanged += new System.EventHandler(this.OnTextValueTextChanged);
            // 
            // CustomValueControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.labelValue);
            this.Name = "CustomValueControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TextBox textValue;
    }
}
