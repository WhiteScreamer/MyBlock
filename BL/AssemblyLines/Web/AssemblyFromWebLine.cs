using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBlock.BL.AssemblyLines.Web
{
    internal interface IAssemblyFromWebLine : IAssemblyLine
    {
        IValidationInfo SetDateRange(ForbiddenDateModes datemode, DateTime? from, DateTime? to);
        IValidationInfo SetUrl(string url, IEnumerable<string> forbiddenHosts);
    }
    internal class AssemblyFromWebLine : AssemblyLine, IAssemblyFromWebLine
    {
        private IValidationInfo UrlCheck()
        {
            IValidationInfo validationInfo = new ValidationInfo();
            if (string.IsNullOrEmpty(WebTable.Url)) return validationInfo.GetInvalidate("Url can't be empty!");
            if (!Uri.IsWellFormedUriString(WebTable.Url, UriKind.Absolute)) return validationInfo.GetInvalidate("Url invalid!");
            WebTable.Uri = new Uri(WebTable.Url);
            if (WebTable.ForbiddenHosts.Contains(WebTable.Uri.Host)) return validationInfo.GetInvalidate("This url was already forbidden!");
            return validationInfo.GetValidate();
        }
        private IValidationInfo DateRangeCheck()
        {
            IValidationInfo validationInfo = new ValidationInfo();
            if (WebTable.Result.ForbiddenDateMode == ForbiddenDateModes.FromTo && WebTable.Result.ToDate.Value<= WebTable.Result.FromDate.Value)
                return validationInfo.GetInvalidate("'From' date can't be later then 'To' date!");
            if (WebTable.Result.ForbiddenDateMode!=ForbiddenDateModes.Forever && (DateTime.Now - WebTable.Result.ToDate.Value).TotalMinutes > 0) 
                return validationInfo.GetInvalidate("'To' date can't be in past!");
            return validationInfo.GetValidate();
        }
        protected IAssamblyTableFromWeb WebTable => (IAssamblyTableFromWeb)_table;
        protected override void InitBuilders()
        {
            Builders.AddRange(new IBuilder[] { new BuilderHost(), new BuilderHtml(), new BuilderName(),
                new BuilderFaviconUrl(), new BuilderLoadFavicon() });
        }
        public override void InitTable()
        {
            _table = new AssamblyTableFromWeb();
            _table.Result.IsForbidden = true;
        }
        public IValidationInfo SetUrl(string url, IEnumerable<string> forbiddenHosts)
        {
            WebTable.Url = url;
            WebTable.ForbiddenHosts = forbiddenHosts;
            return UrlCheck();
        }
        public IValidationInfo SetDateRange(ForbiddenDateModes datemode, DateTime? from, DateTime? to)
        {
            WebTable.Result.FromDate = from;
            WebTable.Result.ToDate = to;
            WebTable.Result.ForbiddenDateMode = datemode;
            return DateRangeCheck();
        }
    }
}
