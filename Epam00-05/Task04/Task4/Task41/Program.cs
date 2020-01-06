using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task41
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 10, 2, 33, 90, 6 };
            Sort.BubbleSort<int>(array, Swap, Compare);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
        static bool Compare(int a, int b)
        {
            if (a > b)
                return true;
            else if (a < b)
                return false;
            else
                return false;
        }
    }
    public delegate void Swap<T>(ref T x, ref T y);
    public delegate bool Compare<T>(T x, T y);
    public static class Sort
    {
        public static void BubbleSort<T>(T[] array, Swap<T> swap, Compare<T> compare)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (compare.Invoke(array[j], array[j + 1]))
                    {
                        swap.Invoke(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

    }
}
