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
        string _path1 = @"D:\Dir1";
        string _path2 = @"D:\Dir2";

        public SyncDirectory()
        {
            CheckDirectories();
            CheckStructure();
            CheckContent();
        }

        private async void CheckContent()
        {
            string[] files = Directory.GetFiles(_path1);
            string[] files2 = Directory.GetFiles(_path2);
            
            foreach (string f in files)
            {
                StringBuilder s1 = new StringBuilder();
                StringBuilder s2 = new StringBuilder();

                using (StreamReader sr = new StreamReader(f))
                {
                    s1.Append(sr.ReadToEnd());
                }
                using (StreamReader sr = new StreamReader(f.Replace(@"\Dir1", @"\Dir2")))
                {
                    s2.Append(sr.ReadToEnd());
                }
                if (!s1.Equals(s2))
                {
                    using (StreamWriter sw = new StreamWriter(f.Replace(@"\Dir1",@"\Dir2"), false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(s1.ToString());
                    }

                }
            }
        }

        private void CheckStructure()
        {
            string[] files = Directory.GetFiles(_path1);
            string[] files2 = Directory.GetFiles(_path2);

            string[] directories = Directory.GetDirectories(_path1);
            string[] directories2 = Directory.GetDirectories(_path2);


            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("---------");
            foreach (string s in files2)
            {
                Console.WriteLine(s);
            }

            foreach (string d in directories)
            {
                if (!Directory.Exists(d.Replace(@"\Dir1", @"\Dir2")))
                {
                    Directory.CreateDirectory(d.Replace(@"\Dir1", @"\Dir2"));
                }
            }

            foreach (string f in files)
            {
                if (!File.Exists(f.Replace(@"\Dir1", @"\Dir2"))) 
                {
                    File.Copy(f, f.Replace(@"\Dir1", @"\Dir2"));
                }
            }

            foreach(string f in files2)
            {
                if (!File.Exists(f.Replace(@"\Dir2", @"\Dir1")))
                {
                    File.Delete(f);
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
