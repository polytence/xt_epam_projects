using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Print(list);
            bool del = false;
            while (list.Count > 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (del) list.RemoveAt(i--);
                    del = !del;
                }
                Print(list);
            }
        }
        static void Print(IEnumerable<int> list)
        {
            foreach (var item in list)
            Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
