using MyBlock.BL;
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

namespace MyBlock
{
    public partial class DateForm : Form
    {
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
        public IPresenter Presenter { get; set; }
        public DateForm()
        {
            InitializeComponent();
            FromDate = DateTime.Now;
            ToDate = DateTime.Now.AddHours(1);
        }
    }
}
