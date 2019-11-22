using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task111
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 0;
            string str = Console.ReadLine();
            char[] arr;
            arr = str.ToCharArray();
            foreach (char Chars in arr)
            {
                if (char.IsLetter(Chars))
                {
                    n++;
                }
            }
            Console.Write("Введена строка: ");
            Console.WriteLine(arr);
            Console.WriteLine("Всего букв:" + n);
            str = new string((from c in str
                              where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                              select c).ToArray());
            Console.WriteLine("Без знаков: "+str);
            string[] words = str.Split();

            foreach (var word in words)
            {

                if (!string.IsNullOrEmpty(word)) 
                {
                    Console.WriteLine($"<{word}>");
                    i++;
                }
            }
            Console.WriteLine("Всего слов:" + i);
            Console.WriteLine(n / i);
                           
        }
    }
}
