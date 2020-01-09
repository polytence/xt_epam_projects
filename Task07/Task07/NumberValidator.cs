using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    class NumberValidator
    {
        public static bool IsUsusal(string input)
        {
            Regex regex = new Regex(@"^-?\d+(\.\d+)?$");
            return regex.IsMatch(input);
        }

        public static bool IsScient(string input)
        {
            Regex regex = new Regex(@"^-?[1-9](\.[1-9]|\.\d+[1-9])?e-?[1-9](\d+)?$");
            return regex.IsMatch(input);
        }

        public static void reg()
        {
            Console.WriteLine("Enter the number.");
            string number = Console.ReadLine();
            if (IsUsusal(number))
            {
                Console.WriteLine("This is a number in the usual notation.");
            }
            else if (IsScient(number))
            {
                Console.WriteLine("This is a number in the scientific notation.");
            }
            else
            {
                Console.WriteLine("This is not a number.");
            }
        }
    }
}
