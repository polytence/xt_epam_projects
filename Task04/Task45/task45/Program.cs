using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task45
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "7";
            Console.WriteLine(str.StrPositive());
        }
    }
    public static class Positive
    {
        public static bool StrPositive(this string i) => i.All(char.IsDigit);
    }
}
