﻿using System.IO;
using Arma3BattlEye.Web.Core.Data.Contract;

namespace Arma3BattlEye.Web.Core.Data
{
    public class MultRepository<T, TKey> : FileBasedRepository<T, TKey> where T : IEntity<TKey>, new()
    {

        protected override string GetFilename(TKey key)
        {
            return Path.Combine(FolderName, string.Format("{0}.xml", key));
        }

        protected override string[] GetFilenames()
        {
            return Directory.GetFiles(FolderName, "*.xml");
        }

        protected override void EnsureDirectoryExists(string filename)
        {

        }

        public MultRepository(string folderName, ILog log)
            : base(folderName, log)
        {

        }
    }
}