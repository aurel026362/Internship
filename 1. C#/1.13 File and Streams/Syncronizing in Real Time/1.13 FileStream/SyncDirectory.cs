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

            //filesystemwatcher watcher2 = new filesystemwatcher(_path2);

            //watcher2.notifyfilter = notifyfilters.lastaccess | notifyfilters.lastwrite |
            //    notifyfilters.filename | notifyfilters.directoryname;



            //watcher2.includesubdirectories = true;

            //watcher2.changed += checkcontent;
            //watcher2.created += deletefilesfromdir2;
            //watcher2.deleted += deletefilesfromdir2;
            //watcher2.renamed += checksubdirectories;
            //watcher2.enableraisingevents = true;
        }

        private async void CheckContent(object obj, FileSystemEventArgs e)
        {
            Console.WriteLine("Check content");
            files = Directory.GetFiles(_path1, "*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                newWay = file.Replace(_path1, _path2);

                using (var from = new FileStream(file, FileMode.Open))
                using (var to = new FileStream(newWay, FileMode.Open))
                {
                    if (!IsEquals(from, to))
                    {
                        from.Close();
                        to.Close();
                        File.Delete(newWay);
                        File.Copy(file, newWay);
                        break;
                    }
                }
            }
        }

        bool IsEquals(Stream from, Stream to)
        {
            if (from.Length != to.Length)
            {
                return false;
            }
            else
            {
                var fromBytes = new byte[from.Length];
                var toBytes = new byte[to.Length];

                for (var i = 0; i < from.Length; i += 100)
                {
                    from.Read(fromBytes, 0, i);
                    to.Read(toBytes, 0, i);
                    if (!fromBytes.SequenceEqual(toBytes))
                    {
                        return false;
                    }
                    if (i < from.Length)
                        i = (int)from.Length;
                }
            }

            return true;
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
                    while (true)
                    {
                        try
                        {
                            File.Copy(file, newWay);
                            break;
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
