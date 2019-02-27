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
            CheckSubdirectories(null, null);
            DeleteFilesFromDir2(null, null);
            CheckContent(null, null);

            FileSystemWatcher watcher = new FileSystemWatcher(_path1);

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                NotifyFilters.FileName | NotifyFilters.DirectoryName;

            

            watcher.IncludeSubdirectories = true;
            
            watcher.Changed += CheckContent;
            watcher.Created += CheckSubdirectories;
            watcher.Deleted += DeleteFilesFromDir2;
            watcher.Renamed += CheckSubdirectories;
            watcher.EnableRaisingEvents = true;


            //FileSystemWatcher watcher2 = new FileSystemWatcher(_path2);

            //watcher2.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite |
            //    NotifyFilters.FileName | NotifyFilters.DirectoryName;

            //watcher2.IncludeSubdirectories = true;

            //watcher2.Changed += CheckContent;
            //watcher2.Created += CheckSubdirectories;
            //watcher2.Deleted += DeleteFilesFromDir2;
            //watcher2.Renamed += CheckSubdirectories;
            //watcher2.EnableRaisingEvents = true;
        }

        private async void CheckContent(object obj, FileSystemEventArgs e)
        {
            directories = Directory.GetDirectories(_path1, "*", SearchOption.AllDirectories);
            files = Directory.GetFiles(_path1, "*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                newWay = file.Replace(_path1, _path2);

                if (file.GetHashCode() != newWay.GetHashCode())
                {
                    bool executed = false;
                    while (executed == false)
                    {
                        try
                        {
                            File.Copy(file, newWay, true);
                            executed = true;
                        }
                        catch
                        {
                            Thread.Sleep(1000);
                        }
                    }
                }
            }
                
        }

        private void CheckSubdirectories(object obj, FileSystemEventArgs e)
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
                    bool executed = false;
                    while (executed == false)
                    {
                        try
                        {
                            File.Copy(file, newWay);
                            executed = true;
                        }
                        catch
                        {
                            Thread.Sleep(1000);
                        }
                    }
                }
            }
        }

        private void DeleteFilesFromDir2(object obj, FileSystemEventArgs e)
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
                Console.WriteLine("Don't exist file " + _path1);
            }

            if (!Directory.Exists(_path2))
            {
                Directory.CreateDirectory(_path2);
            }
        }
    }
}
