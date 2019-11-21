using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,,] Array = new int[3, 3, 3];
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int k = 0; k < Array.GetLength(2); k++)
                    {
                        Array[i, j, k] = random.Next(-100, 100);
                    }
                }
            }
            View(Array);
            Positiveto0(Array);
            View(Array);
        }
        public static void View(int[,,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int k = 0; k < Array.GetLength(2); k++)
                    {
                        Console.Write(Array[i, j, k] + ",");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
        public static void Positiveto0(int[,,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int k = 0; k < Array.GetLength(2); k++)
                    {
                        if (Array[i,j,k] > 0) Array[i,j,k] = 0;
                    }
                }
            }

        }
    }
}
