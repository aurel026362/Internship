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
            files = Directory.GetFiles(_path1, "*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                newWay = file.Replace(_path1, _path2);
                if (isDifferent(file))
                {
                    File.Copy(file, newWay, true);
                }
            }
        }

        private bool isDifferent(string file)
        {
            using (var from = new FileStream(file, FileMode.Open))
            using (var to = new FileStream(newWay, FileMode.Open))
            {
                return !IsEquals(from, to);
            }
        }
        
        bool IsEquals(Stream from, Stream to) 
        {
            if (from.Length != to.Length)
            {
                return false;
            }

            var isEqual = from.Equals(new BinaryReader(from).BaseStream);

            int bsize = 1024 * 1024;

            var fromBytes = new byte[bsize];
            var toBytes = new byte[bsize];
            
            while ((from.Read(fromBytes, 0, bsize) != 0) 
                && (to.Read(toBytes, 0, bsize) != 0))
            {
                if (!fromBytes.SequenceEqual(toBytes))
                {
                    return false;
                }
            }
            return true;
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
