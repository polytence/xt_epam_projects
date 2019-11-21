using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task110
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] Array = new int[4, 4];
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = random.Next(0, 100);
                }
            }
            ViewArray(Array);
            Sum(Array);
        }
        public static void ViewArray(int[,] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + ",");
                }
                Console.WriteLine();
            }
        }

        public static void Sum(int[,] arr)
        {
            int sum = 0;
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    int n = i + j;
                    if (n % 2 == 0 && n != 0)
                    {
                        Console.Write(" " + arr[i, j] + " [" + i + ", " + j+"]");
                        sum += arr[i, j];
                    }

                }
                Console.WriteLine();

            }
            Console.Write("Сумма: " + sum);
            Console.WriteLine();
        }
    }
}
