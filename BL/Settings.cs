using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock.BL
{
    internal interface ISettings
    {
        string PatchIP { get; }

        string GetFilelineTemplate(string commentSymbol, string host, object datemode, object dateFrom, object dateTo);
    }

    internal class Settings : ISettings
    {
        public string PatchIP => "127.0.0.1";
        public string GetFilelineTemplate(string commentSymbol, string host, object datemode, object dateFrom, object dateTo) 
            => $"{commentSymbol}{PatchIP} {host} #MyBlock DateMode:{datemode};From:{dateFrom};To:{dateTo};";
    }
}
