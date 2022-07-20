using System.Text.RegularExpressions;

namespace MyBlock.BL.AssemblyLines.File
{
    internal interface IAssamblyTable : IBaseAssamblyTable
    {
        Match MatchStringLine { get; set; }
    }
    internal class AssamblyTable : AssemblyLines.BaseAssamblyTable, IAssamblyTable
    {
        public Match MatchStringLine { get; set; }
    }
}
