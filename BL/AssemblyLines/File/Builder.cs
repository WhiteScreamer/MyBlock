using System;

namespace MyBlock.BL.AssemblyLines.File
{
    internal abstract class Builder
    {
        protected IAssamblyTable FileTable { get; set; }
        public virtual void Build(AssemblyLines.IBaseAssamblyTable table)
        {
            FileTable = (IAssamblyTable)table;
        }
    }
    internal class BuilderSite : Builder, IBuilder
    {
        public override void Build(AssemblyLines.IBaseAssamblyTable table)
        {
            base.Build(table);
            if (FileTable.MatchStringLine.Groups[1].Value != "#") FileTable.Result.IsForbidden = true;
            FileTable.Result.SiteModel.Host = FileTable.MatchStringLine.Groups[2].Value;
            FileTable.Result.ForbiddenDateMode = Enum.Parse<ForbiddenDateModes>(FileTable.MatchStringLine.Groups[3].Value);
            var fromDateStr = FileTable.MatchStringLine.Groups[4].Value;
            FileTable.Result.FromDate = string.IsNullOrEmpty(fromDateStr) ? null : DateTime.Parse(fromDateStr);
            var toDateStr = FileTable.MatchStringLine.Groups[5].Value;
            FileTable.Result.ToDate = string.IsNullOrEmpty(toDateStr) ? null : DateTime.Parse(toDateStr);
        }
    }
    internal class BuilderName : Builder, IBuilder
    {
        ICache Cache = new CacheName();
        public override void Build(AssemblyLines.IBaseAssamblyTable table)
        {
            base.Build(table);
            Cache.Load(FileTable.Result.SiteModel);
        }
    }
    internal class BuilderFavIcon : Builder, IBuilder
    {
        ICache Cache = new CacheIcon();
        public override void Build(AssemblyLines.IBaseAssamblyTable table)
        {
            base.Build(table);
            Cache.Load(FileTable.Result.SiteModel);
        }
    }
}
