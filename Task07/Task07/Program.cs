using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            regex();
        }
        private static void regex()
        {
            while (true)
            {
                Console.Clear();
                Menu();
                if (!int.TryParse(Console.ReadLine(), out int Mode))
                {
                    Console.WriteLine("Incorrect input. Try again:");
                    continue;
                }

                switch (Mode)
                {
                    case 1:
                        {
                            Console.Clear();
                            DateExistence.reg();
                            Console.WriteLine("Press any key to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            HtmlReplacer.reg();
                            Console.WriteLine("Press any key to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            EmailFinder.reg();
                            Console.WriteLine("Press any key to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            NumberValidator.reg();
                            Console.WriteLine("Press any key to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            TimeCounter.reg();
                            Console.WriteLine("Press any key to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input.");
                            break;
                        }
                }

                if (Mode == 0)
                {
                    break;
                }
            }
        }
        private static void Menu()
        {
            Console.WriteLine("Select the number regex.");
            Console.WriteLine("1. Date existence.");
            Console.WriteLine("2. HTML replacer.");
            Console.WriteLine("3. Email finder.");
            Console.WriteLine("4. Number valiadtor.");
            Console.WriteLine("5. Time counter.");
            Console.WriteLine("0. Exit.");
        }
    }
}
