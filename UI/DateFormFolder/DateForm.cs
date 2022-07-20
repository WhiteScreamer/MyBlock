using MyBlock.BL.AssemblyLines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBlock.DateFormFolder
{
    public partial class DateForm : Form
    {
        private Control CheckedControl
        {
            get
            {
                if (radioButtonTo.Checked) return radioButtonTo;
                return radioButtonFromTo;
            }
        }

        private ForbiddenDateModes ForbiddenDateMode
        {
            get
            {
                if (radioButtonForever.Checked) return ForbiddenDateModes.Forever;
                if (radioButtonTo.Checked) return ForbiddenDateModes.ToDate;
                return ForbiddenDateModes.FromTo;
            }
            set
            {
                radioButtonForever.Checked = value == ForbiddenDateModes.Forever;
                radioButtonTo.Checked = value == ForbiddenDateModes.ToDate;
                radioButtonFromTo.Checked = value == ForbiddenDateModes.FromTo;
            }
        }
        private DateTime? FromDate
        {
            get => radioButtonFromTo.Checked ? dateFromToFrom.Value : null;
            set => dateFromToFrom.Value = value ?? dateFromToFrom.Value;
        }
        private DateTime? ToDate
        {
            get => radioButtonFromTo.Checked ? dateFromToFrom.Value : radioButtonTo.Checked ? dateTo.Value : null;
            set => dateTo.Value = dateFromToTo.Value = value ?? dateFromToTo.Value;
        }
        private IPresenter Presenter { get; set; } = new Presenter();
        public DateForm()
        {
            InitializeComponent();
            FromDate = DateTime.Now;
            ToDate = DateTime.Now.AddHours(1);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (myErrorProvider.ValidatePipe(CheckedControl, Presenter.AssemblyLine.SetDateRange(ForbiddenDateMode, FromDate, ToDate))) return;
        }
    }
}
