using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task5
{
    class Backup
    {
        public static void Write ()
        {
            string path = $@"C:\Users\{Environment.UserName}\Desktop\logs.txt";
            using (FileStream file = new FileStream(path, FileMode.Append))
            using (StreamWriter filewrite = new StreamWriter(file))
                filewrite.WriteLine(File.GetLastWriteTime(path));

                Console.WriteLine("worked");
        }
    }
}
