using Microsoft.Win32;
using MyBlock.BL.AssemblyLines;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock.BL
{
    internal interface IForbidder
    {
        void Allow(ISiteRecord record);
        void Allow(IEnumerable<ISiteRecord> record);
        void Forbid(ISiteRecord record);
        void Forbid(IEnumerable<ISiteRecord> record);
    }

    internal class Forbidder : IForbidder
    {
        private ISettings Settings { get; init; } = new Settings();
        private string GetForbiddenLine(ISiteRecord record) => 
            Settings.GetFilelineTemplate("", record.SiteModel.Host, record.ForbiddenDateMode, record.FromDate, record.ToDate);
        private string GetAllowLine(ISiteRecord record) => $"#{GetForbiddenLine(record)}";
        private IFileMaster FileMaster = new FileMaster();
        private void FlushCache()
        {
            ProcessStartInfo psi = new ProcessStartInfo("CMD.EXE")
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true
            };
            var proc = Process.Start(psi);
            using (StreamWriter sw = proc.StandardInput)
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("ipconfig /flushdns");
                    sw.WriteLine("exit");
                }
            proc?.WaitForExit();
        }
        private void ReplaceString(string oldline, string newline)
        {
            var allLines = FileMaster.GetFileLines();
            var targetLineIndex = allLines.IndexOf(newline);
            if (targetLineIndex >= 0) return;
            targetLineIndex = allLines.IndexOf(oldline);
            if (targetLineIndex < 0) allLines.Add(newline);
            else allLines[targetLineIndex] = newline;
            FileMaster.SetFileLines(allLines);
            FlushCache();
        }
        public void Forbid(ISiteRecord record) => ReplaceString(GetAllowLine(record), GetForbiddenLine(record));
        public void Allow(ISiteRecord record) => ReplaceString(GetForbiddenLine(record), GetAllowLine(record));
        public void Allow(IEnumerable<ISiteRecord> record)
        {
            foreach (var item in record)
                Allow(item);
        }
        public void Forbid(IEnumerable<ISiteRecord> record)
        {
            foreach (var item in record)
                Forbid(item);
        }
    }
}
