using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock.BL
{
    internal interface IRoleCheck
    {
        IValidationInfo CheckAdministratrRole();
    }
    internal class RoleCheck : IRoleCheck
    {
        public IValidationInfo CheckAdministratrRole()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                var validateInfo=new ValidationInfo();
                if (principal.IsInRole(WindowsBuiltInRole.Administrator)) return validateInfo.GetValidate();
                return validateInfo.GetInvalidate("Run this program 'as Administrator'!");
            }
        }
    }
}
