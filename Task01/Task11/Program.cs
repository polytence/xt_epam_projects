using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Ins(ref a);
            Ins(ref b);
            if (a > 1 && b > 1) 
            {
            Console.Write("Площадь равна:" + a*b);
            }
            else 
            { 
            Console.Write("Ошибка, попробуй еще раз. ;)");
            }
            
        }
        public static int Ins(ref int n)
            {
            do
                {
                Console.Write("> ");
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
