using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            FontStyleChange();
        }

        [Flags]
        enum Font : byte
        {
            None = 0,
            Bold = 0x01,
            Italic = 0x02,
            Underline = 0x04,
        }
        public static void FontStyleChange()
        {
            Font style = new Font();
            int n = 0;
            while (n < 1)
            {
                Console.WriteLine("Параметры надписи: " + style);
                Console.WriteLine("Введите:");
                Console.WriteLine("\t1: bold");
                Console.WriteLine("\t2: italic");
                Console.WriteLine("\t3: underline");
                if (Byte.TryParse(Console.ReadLine(), out byte number))
                {
                    if (number < 1 || number > 3)
                    {
                        Console.WriteLine("Такой цифры нет");
                        continue;
                    }
                    style ^= (Font)Math.Pow(2, number - 1);
                }
                else
                {
                    Console.WriteLine("Букавки нельзя!!!");
                    n--;
                }

            }
        }
    }
}
