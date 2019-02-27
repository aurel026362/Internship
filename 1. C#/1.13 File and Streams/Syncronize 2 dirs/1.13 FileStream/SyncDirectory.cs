using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1._13_FileStream
{
    class SyncDirectory
    {
        string _path1;

        string _path2;

        string newWay;

        string[] files;
        string[] directories;

        public SyncDirectory(string newPath1, string newPath2)
        {
            _path1 = newPath1;

            _path2 = newPath2;

            directories = Directory.GetDirectories(_path1, "*", SearchOption.AllDirectories);
            files = Directory.GetFiles(_path1, "*", SearchOption.AllDirectories);

            CheckDirectories();
            CheckSubdirectories();
            DeleteFilesFromDir2();
            CheckContent();
            
        }

        private async void CheckContent()
        {
            directories = Directory.GetDirectories(_path1, "*", SearchOption.AllDirectories);
            files = Directory.GetFiles(_path1, "*", SearchOption.AllDirectories);

            string[] textFormat = { ".txt", ".doc", ".docx", ".html", ".css" };

            foreach (string file in files)
            {
                newWay = file.Replace(_path1, _path2);

                if (textFormat.Contains(Path.GetExtension(file)))
                {
                    StringBuilder stringBuilder1 = new StringBuilder();
                    StringBuilder stringBuilder2 = new StringBuilder();

                    using (StreamReader sr = new StreamReader(file))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            await Task.Run(() => stringBuilder1.Append((line + Environment.NewLine)));
                        }
                    }

                    using (StreamReader sr = new StreamReader(newWay))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            await Task.Run(() => stringBuilder2.Append((line + Environment.NewLine)));
                        }
                    }

                    if (!stringBuilder1.Equals(stringBuilder2))
                    {
                        using (StreamWriter sw = new StreamWriter( newWay, false, System.Text.Encoding.Default))
                        {
                            await Task.Run(() => sw.WriteLine((stringBuilder1)));
                        }
                    }
                }
                else
                {
                    if (file.GetHashCode() != newWay.GetHashCode())
                    {
                        File.Copy(file, newWay, true);
                    }
                }
            }
        }

        private void CheckSubdirectories()
        {
            directories = Directory.GetDirectories(_path1, "*", SearchOption.AllDirectories);
            files = Directory.GetFiles(_path1, "*", SearchOption.AllDirectories);

            foreach (string directory in directories)
            {
                newWay = directory.Replace(_path1, _path2);
                
                if (!Directory.Exists(newWay))
                {
                    Directory.CreateDirectory(newWay);
                }
            }

            foreach (string file in files)
            {
                newWay = file.Replace(_path1, _path2);

                if (!File.Exists(newWay))
                {
                    File.Copy(file, newWay);
                }
            }
        }

        private void DeleteFilesFromDir2()
        {
            string[] directories2 = Directory.GetDirectories(_path2, "*", SearchOption.AllDirectories);
            string[] files2 = Directory.GetFiles(_path2, "*", SearchOption.AllDirectories);

            foreach (string file in files2)
            {
                newWay = file.Replace(_path2, _path1);

                if (!File.Exists(newWay))
                {
                    File.Delete(file);
                }
            }

            foreach (string dir in directories2)
            {
                newWay = dir.Replace(_path2, _path1);
                
                if (!Directory.Exists(newWay))
                {
                    Directory.Delete(dir);
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
