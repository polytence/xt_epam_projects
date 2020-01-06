using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int N = Convert.ToInt32(Console.ReadLine());
            Task02(N);
        }
        public static void Task02(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (n / 2 == i && n / 2 == j)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                        
                }
                Console.WriteLine();
            }
        }
    }
}
