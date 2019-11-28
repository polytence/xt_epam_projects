using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            int c = int.Parse(Console.ReadLine());
            Triangle t = new Triangle(a, b, c);
            Console.WriteLine("Периметр: " + t.Perimeter() + " Площадь: " + Math.Round(t.Square(),2));
        }
    }
    class Triangle
    {
        protected int a;
        protected int b;
        protected int c;
        public int A1
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Не корректные значения, не делай так больше!");
                }
                a = value;
            }
        }
        public int B1
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Не корректные значения, не делай так больше!");
                }
                b = value;
            }
        }
        public int C1
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0 || value >= (b + a))
                {
                    throw new ArgumentException("Не корректные значения, не делай так больше!");
                }
                c = value;
            }
        }
        public Triangle(int A, int B, int C)
        {
            A1 = A;
            B1 = B;
            C1 = C;
        }
        public int Perimeter()
        {
            return a + b + c;
        }
        public double Square()
        {
            int HalfP = Perimeter() / 2;
            double square = HalfP * (HalfP - a) * (HalfP - b) * (HalfP - c);
            return Math.Sqrt(square);
        }
    }
}