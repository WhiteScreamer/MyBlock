using MyBlock.BL.AssemblyLines.Web;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyBlock.BL.AssemblyLines
{
    internal interface IBuilder
    {
        void Build(IAssamblyTable table);
    }    
}
