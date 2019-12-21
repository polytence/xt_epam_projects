using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class History
    {
        public static void ReadHistory()
        {
            string Directory1 = $@"C:\Users\{Environment.UserName}\Desktop\";
            string path = $@"C:\Users\{Environment.UserName}\Desktop\logs.txt";
            using (FileStream file = new FileStream(path, FileMode.Open))
            using (StreamReader fileRead = new StreamReader(file))
            {
                string[] fileEntries = Directory.GetFiles(Directory1);
                foreach (string fileName in fileEntries)
                    Console.WriteLine(fileName);
                var list = new List<string>();
                Console.WriteLine("Dates:");
                while (!fileRead.EndOfStream)
                {
                    string line = fileRead.ReadLine();
                    list.Add(line);
                    Console.WriteLine(list[list.Count - 1]);
                }
            }


        }
    }
}
