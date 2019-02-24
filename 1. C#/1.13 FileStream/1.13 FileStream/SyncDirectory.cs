using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._13_FileStream
{
    class SyncDirectory
    {
        string _path1 = @"C:\user\Aurel\Desktop\Dir1";
        string _path2 = @"C:\user\Aurel\Desktop\Dir2";

        public SyncDirectory()
        {
            CheckDirectories();
            CheckStructure();
            CheckContent();
        }

        private void CheckContent()
        {
            string[] files = Directory.GetFiles(_path1);
            string[] files2 = Directory.GetFiles(_path2);
            
            foreach (string f in files)
            {

            }
        }

        private void CheckStructure()
        {
            string[] files = Directory.GetFiles(_path1);
            string[] files2 = Directory.GetFiles(_path2);

            string[] directories = Directory.GetDirectories(_path1);
            string[] directories2 = Directory.GetDirectories(_path2);

            foreach (string d in directories)
            {
                if (!Directory.Exists(d.Replace("Dir1", "Dir2")))
                {
                    Directory.CreateDirectory(d.Replace("Dir1", "Dir2"));
                }
            }

            foreach (string f in files)
            {
                if (!File.Exists(f.Replace("Dir1", "Dir2"))) 
                {
                    File.Copy(f, f.Replace("Dir1", "Dir2"));
                }
            }
            
        }
        

        private void CheckDirectories()
        {
            if (!Directory.Exists(_path1))
            {
                Directory.CreateDirectory(_path1);
            }

            if (!Directory.Exists(_path2))
            {
                Directory.CreateDirectory(_path2);
            }
        }
    }
}
