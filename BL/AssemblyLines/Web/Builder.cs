using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace MyBlock.BL.AssemblyLines.Web
{
    internal abstract class Builder
    {
        protected IAssamblyTable WebTable { get; set; }
        public virtual void Build(IBaseAssamblyTable table)
        {
            WebTable = (IAssamblyTable)table;
        }
    }

    internal class BuilderHost : Builder, IBuilder
    {
        public override void Build(IBaseAssamblyTable table)
        {
            base.Build(table);
            WebTable.Result.SiteModel.Host = WebTable.Uri.Host;
            WebTable.RootUrl = $"{WebTable.Uri.Scheme}://{WebTable.Uri.Host}";
        }
    }    
    internal class BuilderHtml : Builder, IBuilder
    {
        
        public override void Build(IBaseAssamblyTable table)
        {
            base.Build(table);
            try
            {
                using (var client = new WebClient())
                {
                    WebTable.PageHtml = client.DownloadString(WebTable.RootUrl);
                }
            }
            catch (WebException ex)
            {
                WebTable.PageHtml = "";                
            }
        }
    }
    internal class BuilderName : Builder, IBuilder
    {
        ICache Cache = new CacheName();
        public override void Build(IBaseAssamblyTable table)
        {
            base.Build(table);
            if (string.IsNullOrEmpty(WebTable.PageHtml))
            {
                Cache.Load(WebTable.Result.SiteModel);
                return;
            }
            var match = Regex.Match(WebTable.PageHtml, "<title>(.*?)</title>");
            WebTable.Result.SiteModel.Name = match.Success ? match.Groups[1].Value : WebTable.Result.SiteModel.Host;
            Cache.Save(WebTable.Result.SiteModel);
        }
    }
    internal class BuilderFaviconUrl : Builder, IBuilder
    {
        public override void Build(IBaseAssamblyTable table)
        {
            base.Build(table);
            WebTable.FaviconUrl = $"{WebTable.RootUrl}/favicon.ico";
        }
    }
    internal class BuilderLoadFavicon : Builder, IBuilder
    {
        ICache Cache = new CacheIcon();
        public override void Build(IBaseAssamblyTable table)
        {
            base.Build(table);
            try
            {
                using (var client = new WebClient())
                {
                    var data = client.DownloadData(new Uri(WebTable.FaviconUrl));
                    var icon = new Icon(new MemoryStream(data));
                    WebTable.Result.SiteModel.Favicon = icon.ToBitmap();
                    Cache.Save(WebTable.Result.SiteModel);
                }
            }
            catch (WebException ex)
            {
                WebTable.Result.SiteModel.Favicon = null;
                Cache.Load(WebTable.Result.SiteModel);
            }
        }
    }    
}
