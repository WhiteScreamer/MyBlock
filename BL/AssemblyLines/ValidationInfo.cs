using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock.BL
{
    internal interface IValidationInfo
    {
        bool IsValid { get; set; }
        string Message { get; set; }
        IValidationInfo GetInvalidate(string message);
        IValidationInfo GetValidate();
    }

    internal class ValidationInfo : IValidationInfo
    {
        public string Message { get; set; }
        public bool IsValid { get; set; }
        public IValidationInfo GetInvalidate(string message)
        {
            this.IsValid = false;
            this.Message = message;
            return this;
        }
        public IValidationInfo GetValidate()
        {
            this.IsValid = true;
            this.Message = "";
            return this;
        }
    }
}
