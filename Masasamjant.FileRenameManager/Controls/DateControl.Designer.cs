namespace Masasamjant.FileRenameManager
{
    partial class DateControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateControl));
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSelect = new System.Windows.Forms.RadioButton();
            this.radioToday = new System.Windows.Forms.RadioButton();
            this.labelFormat = new System.Windows.Forms.Label();
            this.comboDateTimeFormat = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.datePicker, "datePicker");
            this.datePicker.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.OnDatePickerValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSelect);
            this.groupBox1.Controls.Add(this.radioToday);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioSelect
            // 
            resources.ApplyResources(this.radioSelect, "radioSelect");
            this.radioSelect.Name = "radioSelect";
            this.radioSelect.UseVisualStyleBackColor = true;
            this.radioSelect.CheckedChanged += new System.EventHandler(this.OnRadioSelectCheckedChanged);
            // 
            // radioToday
            // 
            resources.ApplyResources(this.radioToday, "radioToday");
            this.radioToday.Checked = true;
            this.radioToday.Name = "radioToday";
            this.radioToday.TabStop = true;
            this.radioToday.UseVisualStyleBackColor = true;
            this.radioToday.CheckedChanged += new System.EventHandler(this.OnRadioTodayCheckedChanged);
            // 
            // labelFormat
            // 
            resources.ApplyResources(this.labelFormat, "labelFormat");
            this.labelFormat.Name = "labelFormat";
            // 
            // comboDateTimeFormat
            // 
            this.comboDateTimeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDateTimeFormat.FormattingEnabled = true;
            resources.ApplyResources(this.comboDateTimeFormat, "comboDateTimeFormat");
            this.comboDateTimeFormat.Name = "comboDateTimeFormat";
            this.comboDateTimeFormat.SelectedIndexChanged += new System.EventHandler(this.OnComboDateTimeFormatSelectedIndexChanged);
            // 
            // DateControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboDateTimeFormat);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datePicker);
            this.Name = "DateControl";
            this.Load += new System.EventHandler(this.DateControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSelect;
        private System.Windows.Forms.RadioButton radioToday;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.ComboBox comboDateTimeFormat;
    }
}
