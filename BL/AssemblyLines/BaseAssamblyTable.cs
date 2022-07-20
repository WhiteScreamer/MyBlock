using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MyBlock.BL.AssemblyLines
{
    internal interface IBaseAssamblyTable
    {
        ISiteRecord Result { get; init; }       
    }
    internal abstract class BaseAssamblyTable
    {
        public ISiteRecord Result { get; init; } = new SiteRecord() { SiteModel = new SiteModel() };        
    }      
}
