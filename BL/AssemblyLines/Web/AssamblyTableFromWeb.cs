using System;
using System.Collections.Generic;

namespace MyBlock.BL.AssemblyLines.Web
{
    internal interface IAssamblyTableFromWeb : IAssamblyTable
    {
        #region Outer params                 
        IEnumerable<string> ForbiddenHosts { get; set; }
        string Url { get; set; }
        #endregion
        string FaviconUrl { get; set; }
        string PageHtml { get; set; }
        Uri Uri { get; set; }
        string RootUrl { get; set; }
    }
    internal class AssamblyTableFromWeb : AssamblyTable, IAssamblyTableFromWeb
    {        
        public string PageHtml { get; set; }
        public string FaviconUrl { get; set; }
        public Uri Uri { get; set; }        
        public string RootUrl { get; set; }
        public IEnumerable<string> ForbiddenHosts { get; set; }
        public string Url { get; set; }
    }
}
