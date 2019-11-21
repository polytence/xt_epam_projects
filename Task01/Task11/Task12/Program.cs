using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            int N = 0; 
            Ins(ref N);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < (i + 1); j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.Write(N);
        }
        public static int Ins(ref int n)
        {
            do
            {
                var ins = Console.ReadLine();
                if (Int32.TryParse(ins, out n))
                {
                    return n;
                }
            }
            while (true);
        }
    }
}
