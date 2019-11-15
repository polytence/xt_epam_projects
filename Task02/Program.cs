using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
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
            bool Simple = true;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                {
                    Simple = false;
                    break;
                }
            if (Simple)
                Console.Write("Простое");
            else
                Console.Write("Не простое");
        }
    }
}

