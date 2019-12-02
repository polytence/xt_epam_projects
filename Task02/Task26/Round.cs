using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    class Round
    { 
        public int x;
        public int y;
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
           // проверка Console.WriteLine(x+ " "+y + " "+Radius + " ");
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


