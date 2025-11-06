namespace Masasamjant.FileRenameManager
{
    partial class DateTimeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateTimeControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSelect = new System.Windows.Forms.RadioButton();
            this.radioNow = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioMinute = new System.Windows.Forms.RadioButton();
            this.radioSecond = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.comboDateTimeFormat = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSelect);
            this.groupBox1.Controls.Add(this.radioNow);
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
            // radioNow
            // 
            resources.ApplyResources(this.radioNow, "radioNow");
            this.radioNow.Checked = true;
            this.radioNow.Name = "radioNow";
            this.radioNow.TabStop = true;
            this.radioNow.UseVisualStyleBackColor = true;
            this.radioNow.CheckedChanged += new System.EventHandler(this.OnRadioNowCheckedChanged);
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.OnDateTimePickerValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioMinute);
            this.groupBox2.Controls.Add(this.radioSecond);
            this.groupBox2.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // radioMinute
            // 
            resources.ApplyResources(this.radioMinute, "radioMinute");
            this.radioMinute.Name = "radioMinute";
            this.radioMinute.UseVisualStyleBackColor = true;
            this.radioMinute.CheckedChanged += new System.EventHandler(this.OnRadioMinuteCheckedChanged);
            // 
            // radioSecond
            // 
            resources.ApplyResources(this.radioSecond, "radioSecond");
            this.radioSecond.Checked = true;
            this.radioSecond.Name = "radioSecond";
            this.radioSecond.TabStop = true;
            this.radioSecond.UseVisualStyleBackColor = true;
            this.radioSecond.CheckedChanged += new System.EventHandler(this.OnRadioSecondCheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // DateTimeControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboDateTimeFormat);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Name = "DateTimeControl";
            this.Load += new System.EventHandler(this.OnDateTimeControlLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSelect;
        private System.Windows.Forms.RadioButton radioNow;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioMinute;
        private System.Windows.Forms.RadioButton radioSecond;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.ComboBox comboDateTimeFormat;
    }
}
