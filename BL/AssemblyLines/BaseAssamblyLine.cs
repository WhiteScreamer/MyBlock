using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock.BL.AssemblyLines
{
    internal interface IBaseAssemblyLine
    {
        event EventHandler<ISiteRecord> BuildingComplete;
        void StartAssembly();
    }

    internal abstract class BaseAssemblyLine<T> where T : IBaseAssamblyTable
    {
        static T _table;
        protected List<IBuilder> Builders { get; init; } = new List<IBuilder>();
        protected abstract void InitBuilders();
        protected abstract T CreateTable();
        protected T Table
        {
            get
            {
                if (_table == null) _table = CreateTable();
                return _table;
            }
        }
        public BaseAssemblyLine()
        {
            InitBuilders();
        }        
        public void StartAssembly()
        {
            foreach (var builder in Builders)
                builder.Build(_table);
            BuildingComplete.Invoke(this, _table.Result);
            _table = default(T);
        }
        public event EventHandler<ISiteRecord> BuildingComplete;
    }

}
