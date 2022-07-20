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
    public partial class Date : UserControl
    {
        public DateTime Value
        {
            get => new DateTime(
            dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, dateTimePickerDate.Value.Day,
            dateTimePickerTime.Value.Hour, dateTimePickerTime.Value.Minute, 0);
            set => dateTimePickerDate.Value = dateTimePickerTime.Value = value;
        }
        public Date()
        {
            InitializeComponent();
        }
    }
}
