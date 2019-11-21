using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] Array = new int[10];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(-100, 100);
            }
            ViewArray(Array);
            Console.WriteLine();
            Positivesum(Array);
        }
        
        public static void ViewArray(int[] arr)
        {
            Console.WriteLine(); ;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
        }
        public static void Positivesum(int[] arr)
        {
            int sum = 0;
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        sum += arr[i];
                    }
                }
            Console.Write("сумма: " + sum);
        }
        
    }
}
