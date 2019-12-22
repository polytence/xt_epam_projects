using System;
using System.Collections.Generic;
using System.Globalization;
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
            XmlLog("Renamed",
                            oldName: "",
                            e.Name,
                            e.ChangeType.ToString(),
                            e.FullPath);
            Console.WriteLine("File:" + e.FullPath + " " + e.ChangeType + " ");
            //Backup.Write(e.FullPath);
        }
        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            XmlLog("Renamed",
                            e.OldName,
                            e.Name,
                            e.ChangeType.ToString(),
                            e.FullPath);

            Console.WriteLine(e.ChangeType);
        }
        public static void XmlLog(string eventName,
                                           string oldName,
                                           string name,
                                           string changeType,
                                           string fullPath)
        {
            using (FileStream file = new FileStream(fullPath, FileMode.Open))
            using (StreamReader fileRead = new StreamReader(file))
            {
                var dataChange = (File.GetLastWriteTime(fullPath)); //не нашел как через watcher взять время. 
                //var Text = new List<string>();
                string Text1 = "";
                while (!fileRead.EndOfStream)
                {
                    //var line = fileRead.ReadLine();
                    Text1 += fileRead.ReadLine();
                    //Text.Add(line);
                    //Console.WriteLine(Text[Text.Count - 1]);
                }
                WriteXML.Write(name, fullPath, dataChange, Text1);
            }

        }

    }
}
