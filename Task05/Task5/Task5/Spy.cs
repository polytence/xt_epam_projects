using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Spy
    {
        public static void SpyChanged()
        {
            var path = $@"C:\Users\{Environment.UserName}\Desktop\backup\test";
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            watcher.NotifyFilter =
                NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.DirectoryName | NotifyFilters.FileName;
            watcher.Filter = "*.txt";
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
            Console.WriteLine("Press \'q\' to quit");
            while (Console.Read() != 'q') ;
        }
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File:" + e.FullPath + " " + e.ChangeType + " " + NotifyFilters.LastWrite);
            //Backup.Write(e.FullPath);
        }
        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
            Backup.Write(e.Name);
        }

    }
}
