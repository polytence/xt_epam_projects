using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    class MyString 
    {
        private char[] chars;

        public static MyString operator +(MyString str1, MyString str2)
        {
            return new MyString(str1.ToString() + str2.ToString());
        }

        public static bool operator !=(MyString str1, MyString str2)
        {
            return str1.GetHashCode() != str2.GetHashCode();
        }

        public static bool operator ==(MyString str1, MyString str2)
        {
            return !(str1 != str2);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public MyString(params char[] symbols)
        {
            chars = symbols;
        }

        public MyString(string str)
        {
            chars = str.ToCharArray();
        }

        public override string ToString()
        {
            return new string(chars);
        }

        public int SearchChar(char a)
        {
            if (chars.Contains(a))
            {
                return Array.IndexOf(chars, a);
            }
            else
            {
                Console.WriteLine("Такого символа нет");
                return -1;
            }
        }

        public char[] ToCharArray()
        {
            return chars;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
