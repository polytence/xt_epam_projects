using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task42
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> array = new List<string> { "aaa", "xxx", "yy", "zzz", "cxc", "ccx", "absb", "asdhajksnd", "utuerui" };
            array.Sort(Compare);
            OrderBy(array);
            foreach (string s in array)
                Console.WriteLine("{0} ", s);
        }
        private static int Compare(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)

                {
                    return 1;
                }
                else
                {
                    int i = x.Length.CompareTo(y.Length);

                    if (i != 0)
                    {

                        return i;
                    }
                    else
                    {

                        return x.CompareTo(y);
                    }
                }
            }
        }
            static void OrderBy(List<string> array)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < array.Count - 1; ++i)
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        string temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        flag = true;
                    }
            }
        }
    }
}
