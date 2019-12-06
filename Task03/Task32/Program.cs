using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello bro. How you men. Iam fine bro. How you. Iam fine too bro. Bro bro bro bro bro";
            List<string> list = text.ToLower().Split(new char[] { ' ', '.'}).ToList();
            Print(list);

            Dictionary<string, double> Value = ValueWord(list);

            foreach (var item in Value)
            {
                Console.WriteLine("Value word {0}: {1}", item.Key, item.Value);
            }
        }
        static void Print(IEnumerable<string> list)
        {
            foreach (var item in list)
                Console.WriteLine($"{item} ");
            Console.WriteLine();
        }
        static Dictionary<string, double> ValueWord(List<string> list)
        {
            Dictionary<string, double> Value = new Dictionary<string, double>();
            HashSet<string> uniqWords = new HashSet<string>();
            foreach (string word in list)
            {
                uniqWords.Add(word);
            }
            foreach (string word in uniqWords)
            {
                double value = (double)list.FindAll(t => t == word).Count / list.Count;
                Value.Add(word, Math.Round(value, 3));
            }
            return Value;
        }
    }
}
