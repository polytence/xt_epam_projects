using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    class HtmlReplacer
    {
        public static string ReplaceTags(string input)
        {
            Regex regex = new Regex("<.+?>");
            return regex.Replace(input, "_");
        }

        public static void reg()
        {
            Console.WriteLine("Enter string:");
            string text = Console.ReadLine();

            Console.WriteLine("Text without html tags:");
            Console.WriteLine(ReplaceTags(text));
        }
    }
}
