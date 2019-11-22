using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task112
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первая строка:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Вторая строка:");
            string str2 = Console.ReadLine();
            string doublingstr = "";
            foreach (char sym in str1)
                if (!str2.Contains(sym))
                    doublingstr += sym;
                else
                {
                    doublingstr += sym;
                    doublingstr += sym;
                }
            Console.WriteLine("Удвоениеее:" + doublingstr);
        }
    }
}
