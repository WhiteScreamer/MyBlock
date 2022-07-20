using System.Text.RegularExpressions;

namespace MyBlock.BL.AssemblyLines.File
{
    internal interface IAssemblyLine : IBaseAssemblyLine
    {
        bool SetStringLine(string s);
    }
    internal class AssemblyLine : BaseAssemblyLine<IAssamblyTable>, IAssemblyLine
    {
        private ISettings Settings { get; init; } = new Settings();        
        protected override void InitBuilders()
        {
            Builders.AddRange(new IBuilder[] { new BuilderSite(), new BuilderName(), new BuilderFavIcon()});
        }       

        public bool SetStringLine(string line)
        {
            var template = Settings.GetFilelineTemplate("(#?)", "(.*?)", "(.*?)", "(.*?)", "(.*?)");
            var match = Regex.Match(line, template);
            if (!match.Success) return false;           
            Table.MatchStringLine = match;
            return true;
        }

        protected override IAssamblyTable CreateTable() => new AssamblyTable();
    }
}
