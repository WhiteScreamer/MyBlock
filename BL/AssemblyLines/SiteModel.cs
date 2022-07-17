using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock.BL.AssemblyLines
{
    public enum ForbiddenDateModes
    {
        Forever,
        ToDate,
        FromTo
    }
    internal interface ISiteModel
    {
        Image Favicon { get; set; }
        string Host { get; set; }
        string Name { get; set; }
    }

    internal class SiteModel : ISiteModel
    {
        public string Host { get; set; }
        public string Name { get; set; }
        public Image Favicon { get; set; }
    }

    internal interface ISiteRecord
    {
        ISiteModel SiteModel { get; set; }
        DateTime? FromDate { get; set; }
        DateTime? ToDate { get; set; }
        bool IsForbidden { get; set; }
        ForbiddenDateModes ForbiddenDateMode { get; set; }
        string TimeLeft { get; }

    }

    internal class SiteRecord : ISiteRecord
    {
        public ISiteModel SiteModel { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public ForbiddenDateModes ForbiddenDateMode { get; set; }
        public bool IsForbidden { get; set; }
        private string GetLeftToAllowString(int val, string name) => val > 0 ? $"{val} {name} " : "";
        private string GetLeftToAllowString(TimeSpan left) =>
            $"{GetLeftToAllowString(left.Days, "day(s)")}{GetLeftToAllowString(left.Hours, "hour(s)")}{GetLeftToAllowString(left.Minutes, "minute(s)")}";
        private string GetLeftToAllowString(ISiteRecord record) => record.ForbiddenDateMode==ForbiddenDateModes.Forever ? "inf" : GetLeftToAllowString(record.ToDate.Value - DateTime.Now);
        public string TimeLeft => GetLeftToAllowString(this);
    }
}
