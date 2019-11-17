using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите размерность массива N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] SizeStepArray = new int[N];
            for (int i = 0; i < SizeStepArray.Length; i++)
            {
                Console.WriteLine("Введите число размерности " + i + " подмассива");
                SizeStepArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(" " + SizeStepArray[i]);
            }
            Console.WriteLine();

            Bubble(SizeStepArray);

            for (int i = 0; i < N; i++)
            {
                Console.Write(" " + SizeStepArray[i]);
            }
            Console.WriteLine();



            int[][] myArr = new int[N][];
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = new int[SizeStepArray[i]];
            }

            for (int i = 0; i < myArr.Length; i++)
            {
                for (int j = 0; j < myArr[i].Length; j++)
                {
                    myArr[i][j] = random.Next(0, 100);
                }
            }


            viewArray(myArr);
            SortArray(myArr);
            Console.WriteLine();
            Console.Write("Сортированный");
            viewArray(myArr);
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
        public static void viewArray(int[][] arr)
        {
            Console.WriteLine();
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + ",");
                }
                Console.Write("},");
            }
            Console.Write("}.");
        }


        public static void SortArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr[i]);
            }

        }

    }
}


