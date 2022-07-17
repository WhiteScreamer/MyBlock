using System.Text.RegularExpressions;

namespace MyBlock.BL.AssemblyLines.File
{
    internal interface IAssamblyTableFromFile : IAssamblyTable
    {
        Match MatchStringLine { get; set; }
    }
    internal class AssamblyTableFromFile : AssamblyTable, IAssamblyTableFromFile
    {
        public Match MatchStringLine { get; set; }
    }
}
