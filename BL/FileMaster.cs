using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock.BL
{
    internal interface IFileMaster
    {
        List<string> GetFileLines();
        void SetFileLines(IEnumerable<string> lines);
    }

    internal class FileMaster : IFileMaster
    {
        const string Key = @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters";
        const string ValueName = "DataBasePath";
        const string hostsFileName = "hosts";
        private string HostsFilePath = @$"{(string?)Registry.GetValue(Key, ValueName, "")}\{hostsFileName}";        
        private void ChechAndCreateFile()
        {
            if (!File.Exists(HostsFilePath)) using (var file = File.Create(HostsFilePath)) ;
        }
        public List<string> GetFileLines()
        {
            ChechAndCreateFile();
            return File.ReadLines(HostsFilePath).ToList();
        }
        public void SetFileLines(IEnumerable<string> lines)
        {
            ChechAndCreateFile();
            File.WriteAllLines(HostsFilePath, lines);
        }
    }
}
