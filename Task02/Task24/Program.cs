using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString string1 = new MyString(new char[] { 'I', 'l', 'o', 'v', 'e' });
            MyString string2 = new MyString(new char[] { 'C', 'o', 'o', 'k', 'e', 's' });
            Console.WriteLine(string1 + string2);
            Console.WriteLine(string1 != string2);
            Console.WriteLine(string1 == string2);
            Console.WriteLine(string1.SearchChar('e'));
        }
    }
}
