using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task44
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 11, 55 };
            double[] b = { 5.45 };
            double c = a.Sum() + b.Sum();
            Console.WriteLine(c);
        }
    }
    public static class Operation
    {
        public static int Sum(this int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}

    

