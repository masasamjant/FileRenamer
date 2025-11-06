using System;

namespace Masasamjant.FileRenameManager
{
    public partial class IncrementControl : InsertUserControl
    {
        public IncrementControl()
            : this(null)
        { }

        public IncrementControl(FileRenameInsertParameters parameters)
            : base(parameters)
        {
            InitializeComponent();
        }

        public int Increment
        {
            get { return Convert.ToInt32(numericIncrement.Value); }
        }

        public int Initial
        {
            get { return Convert.ToInt32(numericInitial.Value); }
        }

        private void OnNumericInitialValueChanged(object sender, EventArgs e)
        {
            Parameters.IncrementInitial = Initial;
            OnParametersChanged(EventArgs.Empty);
        }

        private void OnNumericIncrementValueChanged(object sender, EventArgs e)
        {
            Parameters.Increment = Increment;
            OnParametersChanged(EventArgs.Empty);
        }
    }
}
