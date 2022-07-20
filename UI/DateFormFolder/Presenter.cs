using MyBlock.BL.AssemblyLines.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock.DateFormFolder
{
    internal interface IPresenter
    {
        IAssemblyLine AssemblyLine { get; set; }
    }

    internal class Presenter : IPresenter
    {
        public IAssemblyLine AssemblyLine { get; set; } = new AssemblyLine();
    }
}
