using MyBlock.BL.AssemblyLines;
using MyBlock.BL.AssemblyLines.File;
using MyBlock.BL.AssemblyLines.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock.BL
{
    public interface IPresenter
    {
        IAssemblyFromWebLine AssemblyFromWebLine { get; set; }
        IAssemblyFromFileLine AssemblyFromFileLine { get; set; }
        List<ISiteRecord> ForbiddenList { get; }
        List<ISiteRecord> AllowList { get; }
        IRoleCheck RoleCheck { get; }
        void LoadFromFile();        
        void MoveItems(IEnumerable<ISiteRecord> records, bool forbid);    
        void Remove(ISiteRecord record);
    }

    internal class Presenter : IPresenter
    {
        ICache CacheIcon = new CacheIcon();
        ICache CacheName = new CacheName();
        private IForbidder Forbidder { get; init; } = new Forbidder();
        private IFileMaster FileMaster { get; init; } = new FileMaster();
        private void AssamblyFromWebLine_BuildingComplete(object? sender, ISiteRecord record)
        {
            ForbiddenList.Add(record);
            Forbidder.Forbid(record);
        }
        private void AssemblyFromFileLine_BuildingComplete(object? sender, ISiteRecord record)
        {
            if (record.IsForbidden) ForbiddenList.Add(record);
            else AllowList.Add(record);
        }       
        private IEnumerable<ISiteRecord> MoveItems(List<ISiteRecord> source, List<ISiteRecord> target, IEnumerable<ISiteRecord> items)
        {
            foreach (var item in items)
                source.Remove(item);
            foreach (var item in items)
                target.Add(item);
            return items;
        }
        public Presenter()
        {
            AssemblyFromWebLine.BuildingComplete += AssamblyFromWebLine_BuildingComplete;
            AssemblyFromFileLine.BuildingComplete += AssemblyFromFileLine_BuildingComplete;
        }


        public List<ISiteRecord> ForbiddenList { get; init; } = new List<ISiteRecord>();
        public List<ISiteRecord> AllowList { get; init; } = new List<ISiteRecord>();
        public IRoleCheck RoleCheck { get; init; } = new RoleCheck();        
        public IAssemblyFromWebLine AssemblyFromWebLine { get; set; } = new AssemblyFromWebLine();
        public IAssemblyFromFileLine AssemblyFromFileLine { get; set; } = new AssemblyFromFileLine();
        public void LoadFromFile()
        {
            foreach (var line in FileMaster.GetFileLines())
            {                
                if (!AssemblyFromFileLine.SetStringLine(line)) continue;
                AssemblyFromFileLine.StartAssembly();
            }            
        }

        public void MoveItems(IEnumerable<ISiteRecord> records, bool forbid)
        {
            if (forbid)
            {
                MoveItems(ForbiddenList, AllowList, records);
                Forbidder.Forbid(records);
                return;
            }
            MoveItems(AllowList, ForbiddenList, records);
            Forbidder.Allow(records);
        }

        public void Remove(ISiteRecord record)
        {
            AllowList.Remove(record);
            CacheIcon.Delete(record.SiteModel);
            CacheName.Delete(record.SiteModel);
        }
    }
}
