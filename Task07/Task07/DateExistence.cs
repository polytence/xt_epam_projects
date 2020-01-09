using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    class DateExistence
    {

        public static bool IfDateExists(string input)
        {
            Regex regex = new Regex(@"\b([0-2][0-9]|3[01])-(1[012]|0[1-9])-\d{4}\b");
            Match match = regex.Match(input);
            while (match.Success)
            {
                if (DateTime.TryParse(match.Value, out DateTime date))
                {
                    return true;
                }
            }
            return false;
        }

        public static void reg()
        {
            Console.WriteLine("Enter string.");
            string text = Console.ReadLine();
            if (IfDateExists(text))
            {
                Console.WriteLine($@"Text {text} contains dates.");
            }
            else
            {
                Console.WriteLine($@"Text {text} does not contain dates.");
            }
        }
    }
}
