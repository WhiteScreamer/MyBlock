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
        bool CheckAdministratrRole();
    }
    internal class RoleCheck : IRoleCheck
    {
        public bool CheckAdministratrRole()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
    }
}
