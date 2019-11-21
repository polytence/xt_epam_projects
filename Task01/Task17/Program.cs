using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] Array = new int[10];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(0, 100);
            }
            ViewArray(Array);
            Console.WriteLine();
            Bubble(Array);
            ViewArray(Array);
            Console.WriteLine();
            MaxArray(Array);
            Console.WriteLine();
            MinArray(Array);
        }
        public static void Bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];

                        arr[j] = arr[j + 1];

                        arr[j + 1] = tmp;
                    }
                }
            }

        }
        public static void ViewArray(int[] arr)
        {
            Console.WriteLine(); ;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
        }
        public static void MaxArray(int[] arr)
        {
            int max = arr[0];
            Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max) max = arr[i];
                }
            Console.Write("Max: " + max);
        }
        public static void MinArray(int[] arr)
        {
            int min = arr[0];
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            Console.Write("Min: " + min);
        }
    }
}
