using System;

namespace MyBlock.BL.AssemblyLines.File
{
    internal abstract class BuilderFromFile
    {
        protected IAssamblyTableFromFile FileTable { get; set; }
        public virtual void Build(IAssamblyTable table)
        {
            FileTable = (IAssamblyTableFromFile)table;
        }
    }
    internal class BuilderSite : BuilderFromFile, IBuilder
    {
        public override void Build(IAssamblyTable table)
        {
            base.Build(table);
            if (FileTable.MatchStringLine.Groups[1].Value != "#") FileTable.Result.IsForbidden = true;
            FileTable.Result.SiteModel.Host = FileTable.MatchStringLine.Groups[2].Value;
            FileTable.Result.ForbiddenDateMode =Enum.Parse<ForbiddenDateModes>(FileTable.MatchStringLine.Groups[3].Value);
            FileTable.Result.FromDate = DateTime.Parse(FileTable.MatchStringLine.Groups[4].Value);
            FileTable.Result.ToDate = DateTime.Parse(FileTable.MatchStringLine.Groups[5].Value);            
        }
    }
    internal class BuilderName : BuilderFromFile, IBuilder
    {
        ICache Cache = new CacheName();
        public override void Build(IAssamblyTable table)
        {
            base.Build(table);
            Cache.Load(FileTable.Result.SiteModel);
        }
    }
    internal class BuilderFavIcon : BuilderFromFile, IBuilder
    {
        ICache Cache = new CacheIcon();
        public override void Build(IAssamblyTable table)
        {
            base.Build(table);
            Cache.Load(FileTable.Result.SiteModel);
        }
    }
}
