using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MyBlock.BL.AssemblyLines
{
    internal interface IAssamblyTable
    {
        ISiteRecord Result { get; init; }       
    }
    internal abstract class AssamblyTable
    {
        public ISiteRecord Result { get; init; } = new SiteRecord() { SiteModel = new SiteModel() };        
    }      
}
