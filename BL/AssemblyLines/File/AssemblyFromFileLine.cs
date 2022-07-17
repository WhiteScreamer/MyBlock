using System.Text.RegularExpressions;

namespace MyBlock.BL.AssemblyLines.File
{
    internal interface IAssemblyFromFileLine : IAssemblyLine
    {
        bool SetStringLine(string s);
    }
    internal class AssemblyFromFileLine : AssemblyLine, IAssemblyFromFileLine
    {
        private ISettings Settings { get; init; } = new Settings();
        protected IAssamblyTableFromFile FileTable => (IAssamblyTableFromFile)_table;
        protected override void InitBuilders()
        {
            Builders.AddRange(new IBuilder[] { new BuilderSite(), new BuilderName(), new BuilderFavIcon()});
        }
        public override void InitTable()
        {
            _table = new AssamblyTableFromFile();
        }

        public bool SetStringLine(string line)
        {
            var template = Settings.GetFilelineTemplate("(#?)", "(.*?)", "(.*?)", "(.*?)", "(.*?)");
            var match = Regex.Match(line, template);
            if (!match.Success) return false;
            InitTable();
            FileTable.MatchStringLine = match;
            return true;
        }

    }
}
