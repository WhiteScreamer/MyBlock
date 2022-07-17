using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock.BL.AssemblyLines
{
    internal interface IAssemblyLine
    {
        event EventHandler<ISiteRecord> BuildingComplete;
        void StartAssembly();
        void InitTable();
    }

    internal abstract class AssemblyLine
    {
        protected IAssamblyTable _table;
        protected List<IBuilder> Builders { get; init; } = new List<IBuilder>();
        protected abstract void InitBuilders();
        public AssemblyLine()
        {
            InitBuilders();
        }
        public abstract void InitTable();
        public void StartAssembly()
        {
            foreach (var builder in Builders)
                builder.Build(_table);
            BuildingComplete.Invoke(this, _table.Result);
        }
        public event EventHandler<ISiteRecord> BuildingComplete;
    }
      
}
