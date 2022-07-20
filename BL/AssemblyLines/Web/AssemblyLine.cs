using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBlock.BL.AssemblyLines.Web
{
    internal interface IAssemblyLine : IBaseAssemblyLine
    {
        IValidationInfo SetDateRange(ForbiddenDateModes datemode, DateTime? from, DateTime? to);
        IValidationInfo SetUrl(string url, IEnumerable<string> forbiddenHosts);
    }
    internal class AssemblyLine : BaseAssemblyLine<IAssamblyTable>, IAssemblyLine
    {
        private IValidationInfo UrlCheck()
        {
            IValidationInfo validationInfo = new ValidationInfo();
            if (string.IsNullOrEmpty(Table.Url)) return validationInfo.GetInvalidate("Url can't be empty!");
            if (!Uri.IsWellFormedUriString(Table.Url, UriKind.Absolute)) return validationInfo.GetInvalidate("Url invalid!");
            Table.Uri = new Uri(Table.Url);
            if (Table.ForbiddenHosts.Contains(Table.Uri.Host)) return validationInfo.GetInvalidate("This url was already forbidden!");
            return validationInfo.GetValidate();
        }
        private IValidationInfo DateRangeCheck()
        {
            IValidationInfo validationInfo = new ValidationInfo();
            if (Table.Result.ForbiddenDateMode == ForbiddenDateModes.FromTo && Table.Result.ToDate.Value<= Table.Result.FromDate.Value)
                return validationInfo.GetInvalidate("'From' date can't be later then 'To' date!");
            if (Table.Result.ForbiddenDateMode!=ForbiddenDateModes.Forever && (DateTime.Now - Table.Result.ToDate.Value).TotalMinutes > 0) 
                return validationInfo.GetInvalidate("'To' date can't be in past!");
            return validationInfo.GetValidate();
        }
        protected override IAssamblyTable CreateTable()
        {
            var table= new AssamblyTable();
            table.Result.IsForbidden = true;
            return table;
        }
        protected override void InitBuilders()
        {
            Builders.AddRange(new IBuilder[] { new BuilderHost(), new BuilderHtml(), new BuilderName(),
                new BuilderFaviconUrl(), new BuilderLoadFavicon() });
        }        
        public IValidationInfo SetUrl(string url, IEnumerable<string> forbiddenHosts)
        {
            Table.Url = url;
            Table.ForbiddenHosts = forbiddenHosts;
            return UrlCheck();
        }
        public IValidationInfo SetDateRange(ForbiddenDateModes datemode, DateTime? from, DateTime? to)
        {
            Table.Result.FromDate = from;
            Table.Result.ToDate = to;
            Table.Result.ForbiddenDateMode = datemode;
            return DateRangeCheck();
        }

    }
}
