using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите х: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Введите радиус: ");
            double radius = double.Parse(Console.ReadLine());
            Round r = new Round(x, y, radius);
            Console.WriteLine("Площадь: " + r.Square() + " Длина: " + r.Length());
        }
    }
    class Round
    {
        protected int x;
        protected int y;
        private double r;
        public double Radius
        {
            get
            {
                return r;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Радиус != 0, не делай так больше!");
                }
                r = value;
            }
        }
        public Round(int X, int Y, double r)
        {
            x = X;
            y = Y;
            Radius = r;
        }
        public double Square()
        {
            double square = Math.PI * r * r;
            return Math.Round(square, 2);
        }
        public double Length()
        {
            double l = Math.PI * r * 2;
            return Math.Round(l, 2);
        }
    }
}
