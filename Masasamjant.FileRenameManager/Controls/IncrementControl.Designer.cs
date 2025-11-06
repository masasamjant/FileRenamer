namespace Masasamjant.FileRenameManager
{
    partial class IncrementControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncrementControl));
            this.labelInitial = new System.Windows.Forms.Label();
            this.numericInitial = new System.Windows.Forms.NumericUpDown();
            this.labelIncrement = new System.Windows.Forms.Label();
            this.numericIncrement = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIncrement)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInitial
            // 
            resources.ApplyResources(this.labelInitial, "labelInitial");
            this.labelInitial.Name = "labelInitial";
            // 
            // numericInitial
            // 
            resources.ApplyResources(this.numericInitial, "numericInitial");
            this.numericInitial.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericInitial.Name = "numericInitial";
            this.numericInitial.ValueChanged += new System.EventHandler(this.OnNumericInitialValueChanged);
            // 
            // labelIncrement
            // 
            resources.ApplyResources(this.labelIncrement, "labelIncrement");
            this.labelIncrement.Name = "labelIncrement";
            // 
            // numericIncrement
            // 
            resources.ApplyResources(this.numericIncrement, "numericIncrement");
            this.numericIncrement.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericIncrement.Name = "numericIncrement";
            this.numericIncrement.ValueChanged += new System.EventHandler(this.OnNumericIncrementValueChanged);
            // 
            // IncrementControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericIncrement);
            this.Controls.Add(this.labelIncrement);
            this.Controls.Add(this.numericInitial);
            this.Controls.Add(this.labelInitial);
            this.Name = "IncrementControl";
            ((System.ComponentModel.ISupportInitialize)(this.numericInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIncrement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInitial;
        private System.Windows.Forms.NumericUpDown numericInitial;
        private System.Windows.Forms.Label labelIncrement;
        private System.Windows.Forms.NumericUpDown numericIncrement;
    }
}
