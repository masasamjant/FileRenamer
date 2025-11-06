using System;

namespace Masasamjant.FileRenameManager
{
    public partial class DateControl : InsertUserControl
    {
        public DateControl()
            : this(null)
        { }

        public DateControl(FileRenameInsertParameters parameters)
            : base(parameters)
        {
            InitializeComponent();
        }

        private void DateControl_Load(object sender, EventArgs e)
        {
            if (!radioToday.Checked)
                radioToday.Checked = true;

            datePicker.Enabled = radioSelect.Checked;

            comboDateTimeFormat.Items.Add(FileRenameDateTimeFormat.yyyyMMdd);
            comboDateTimeFormat.Items.Add(FileRenameDateTimeFormat.ddMMyyyy);
            comboDateTimeFormat.SelectedIndex = 0;
            Parameters.DateTimeFormat = SelectedDateTimeFormat;
            Parameters.DateTime = SelectedDate;
            OnParametersChanged(EventArgs.Empty);
        }

        public DateTime SelectedDate
        {
            get { return datePicker.Value.Date; }
        }

        public string SelectedDateTimeFormat
        {
            get { return comboDateTimeFormat.Items[comboDateTimeFormat.SelectedIndex].ToString(); }
        }

        private void OnRadioTodayCheckedChanged(object sender, EventArgs e)
        {
            if (radioToday.Checked)
            {
                datePicker.Value = DateTime.Today;
                datePicker.Enabled = false;
                Parameters.DateTime = SelectedDate;
                OnParametersChanged(EventArgs.Empty);
            }
        }

        private void OnRadioSelectCheckedChanged(object sender, EventArgs e)
        {
            datePicker.Enabled = radioSelect.Checked;
        }

        private void OnDatePickerValueChanged(object sender, EventArgs e)
        {
            Parameters.DateTime = SelectedDate;
            OnParametersChanged(EventArgs.Empty);
        }

        private void OnComboDateTimeFormatSelectedIndexChanged(object sender, EventArgs e)
        {
            Parameters.DateTimeFormat = SelectedDateTimeFormat;
            OnParametersChanged(EventArgs.Empty);
        }
    }
}
