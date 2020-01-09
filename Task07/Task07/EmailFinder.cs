using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    class EmailFinder
    {
        public static void FindEmails(string input)
        {
            Regex regex = new Regex(@"\b[\w.]+@[\w]+(\.[\w]+){1,}\b");
            MatchCollection matches = regex.Matches(input);
            if (matches.Count == 0)
            {
                Console.WriteLine("Text not have emails.");
            }
            else
            {
                Console.WriteLine("Email Addresses Found:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }

        public static void reg()
        {
            Console.WriteLine("Enter text.");
            string text = Console.ReadLine();
            FindEmails(text);
        }
    }
}
