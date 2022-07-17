using MyBlock.BL.AssemblyLines;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock.BL
{
    internal interface ICache
    {
        void Load(ISiteModel site);
        void Save(ISiteModel site);
        void Delete(ISiteModel site);
    }
    internal abstract class CacheBase
    {
        protected const string cachedirName = "Cache";
        protected virtual string GetPath(ISiteModel site) => $"{cachedirName}\\{site.Host}";
        protected void CreateDirIfNotExist()
        {
            if (!Directory.Exists(cachedirName)) Directory.CreateDirectory(cachedirName);
        }
        protected bool IsExistFile(ISiteModel site) => File.Exists(GetPath(site));
        public abstract void Load(ISiteModel site);
        public virtual void Save(ISiteModel site)
        {
            CreateDirIfNotExist();
            Delete(site);
        }
        public void Delete(ISiteModel site)
        {
            if (!IsExistFile(site)) return; 
            try
            {
                File.Delete(GetPath(site));
            }catch(IOException ex)
            {

            }
        }
    }
    internal class CacheIcon : CacheBase, ICache
    {
        public override void Load(ISiteModel site)
        {
            if (!IsExistFile(site)) return;
            site.Favicon = Image.FromFile(GetPath(site));
        }
        public override void Save(ISiteModel site)
        {
            base.Save(site);
            site.Favicon.Save(GetPath(site));
        }
    }
    internal class CacheName : CacheBase, ICache
    {
        protected override string GetPath(ISiteModel site)=>base.GetPath(site)+".txt";        
        public override void Load(ISiteModel site)
        {
            if (!IsExistFile(site)) return;
            site.Name = File.ReadAllText(GetPath(site));
        }
        public override void Save(ISiteModel site)
        {
            base.Save(site);
            File.WriteAllText(GetPath(site), site.Name);
        }
    }
}
