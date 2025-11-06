using System;
using System.Windows.Forms;

namespace Masasamjant.FileRenameManager
{
    public partial class DateTimeControl : InsertUserControl
    {
        public DateTimeControl()
            : this(null)
        { }

        public DateTimeControl(FileRenameInsertParameters parameters)
            : base(parameters)
        {
            InitializeComponent();
        }

        public DateTime SelectedDateTime
        {
            get { return dateTimePicker.Value; }
        }

        public FileRenameInsertTimeAccuracy SelectedTimeAccuracy
        {
            get
            {
                if (radioSecond.Checked)
                    return FileRenameInsertTimeAccuracy.Second;

                return FileRenameInsertTimeAccuracy.Minute;
            }
        }

        public string SelectedDateTimeFormat
        {
            get { return comboDateTimeFormat.Items[comboDateTimeFormat.SelectedIndex].ToString(); }
        }

        private void OnDateTimeControlLoad(object sender, EventArgs e)
        {
            SetDateTimePickerFormat();
            SetComboFormats();

            if (!radioNow.Checked)
                radioNow.Checked = true;

            dateTimePicker.Enabled = radioSelect.Checked;
            Parameters.DateTime = SelectedDateTime;
            OnParametersChanged(EventArgs.Empty);
        }

        private void OnRadioNowCheckedChanged(object sender, EventArgs e)
        {
            if (radioNow.Checked)
            {
                dateTimePicker.Value = DateTime.Now;
                dateTimePicker.Enabled = false;
                Parameters.DateTime = SelectedDateTime;
                OnParametersChanged(EventArgs.Empty);
            }
        }

        private void OnRadioSelectCheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = radioSelect.Checked;
        }

        private void SetDateTimePickerFormat()
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = GetCustomFormat();
        }

        private string GetCustomFormat()
        {
            bool secondAccuracy = (SelectedTimeAccuracy == FileRenameInsertTimeAccuracy.Second);

            if (CultureHelper.IsFinnishCulture)
            {
                return secondAccuracy ? FileRenameDateTimeFormat.FinnishFormatSecondAccuracy : FileRenameDateTimeFormat.FinnishFormatMinuteAccuracy;
            }

            return secondAccuracy ? FileRenameDateTimeFormat.DefaultFormatSecondAccuracy : FileRenameDateTimeFormat.DefaultFormatMinuteAccuracy;
        }

        private void OnRadioSecondCheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = GetCustomFormat();
            SetComboFormats();
            Parameters.TimeAccuracy = SelectedTimeAccuracy;
            OnParametersChanged(EventArgs.Empty);
        }

        private void OnRadioMinuteCheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = GetCustomFormat();
            SetComboFormats();
            Parameters.TimeAccuracy = SelectedTimeAccuracy;
            OnParametersChanged(EventArgs.Empty);
        }

        private void SetComboFormats()
        {
            bool secondAccuracy = (SelectedTimeAccuracy == FileRenameInsertTimeAccuracy.Second);

            comboDateTimeFormat.Items.Clear();

            if (secondAccuracy)
            {
                comboDateTimeFormat.Items.Add(FileRenameDateTimeFormat.yyyyMMdd_HHmmss);
                comboDateTimeFormat.Items.Add(FileRenameDateTimeFormat.ddMMyyyy_HHmmss);
                comboDateTimeFormat.Items.Add(FileRenameDateTimeFormat.yyyyMMddHHmmss);
                comboDateTimeFormat.Items.Add(FileRenameDateTimeFormat.ddMMyyyyHHmmss);
            }
            else
            {
                comboDateTimeFormat.Items.Add(FileRenameDateTimeFormat.yyyyMMdd_HHmm);
                comboDateTimeFormat.Items.Add(FileRenameDateTimeFormat.ddMMyyyy_HHmm);
                comboDateTimeFormat.Items.Add(FileRenameDateTimeFormat.yyyyMMddHHmm);
                comboDateTimeFormat.Items.Add(FileRenameDateTimeFormat.ddMMyyyyHHmm);
            }

            comboDateTimeFormat.SelectedIndex = 0;
            Parameters.DateTimeFormat = SelectedDateTimeFormat;
        }

        private void OnDateTimePickerValueChanged(object sender, EventArgs e)
        {
            Parameters.DateTime = SelectedDateTime;
            OnParametersChanged(EventArgs.Empty);
        }

        private void OnComboDateTimeFormatSelectedIndexChanged(object sender, EventArgs e)
        {
            Parameters.DateTimeFormat = SelectedDateTimeFormat;
            OnParametersChanged(EventArgs.Empty);
        }
    }
}
