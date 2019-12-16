using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Hello,{0}", Environment.UserName + "! Choose mode:" + Environment.NewLine + "1. Read" + Environment.NewLine +
                 "2. Backup" + Environment.NewLine + "3. Clear" + Environment.NewLine + "0. Exit");

                if (!int.TryParse(Console.ReadLine(), out int mode))
                {
                    Console.WriteLine("wrong input");
                    continue;

                }
                if (mode > 3 || mode < 0)
                {
                    Console.WriteLine("Wrong number. Try again.");
                    continue;
                }
                switch (mode)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        break;
                    case 3:
                        Console.WriteLine("Case 3");
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("wrong case");
                        break;
                }
            }
        }
    }
}
