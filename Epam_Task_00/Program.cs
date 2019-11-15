using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Task_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N:");
            int N = Convert.ToInt32(Console.ReadLine());
            Task01(N);
        }
        public static void Task01(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i != n)
                {
                    Console.Write(i + ",");
                } else
                {
                    Console.Write(i);
                }
            }
        }
    }
}
