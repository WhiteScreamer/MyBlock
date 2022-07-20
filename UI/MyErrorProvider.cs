using MyBlock.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBlock.UI
{
    public class MyErrorProvider:ErrorProvider
    {
        public bool ValidatePipe(Control control, IValidationInfo validateInfo)
        {
            this.Clear();
            if (validateInfo.IsValid) return true;
            this.SetError(control, validateInfo.Message);
            MessageBox.Show(validateInfo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public bool ValidatePipe(IValidationInfo validateInfo) => ValidatePipe(null, validateInfo);
    }
}
