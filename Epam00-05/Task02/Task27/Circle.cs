using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    class Circle
    {
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
            public Circle(double r)
            {
                Radius = r;
                // проверка Console.WriteLine(x+ " "+y + " "+Radius + " ");
            }
            
            public double Length()
            {
                double l = Math.PI * r * 2;
                return Math.Round(l, 2);
            }
    }
}
