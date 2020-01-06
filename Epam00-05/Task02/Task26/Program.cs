using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты центра кольца, внутренний и внешний радиус ");
            Console.Write("Координата х: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Координата y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Внутренний радиус: ");
            double radiusIn = double.Parse(Console.ReadLine());
            Console.Write("Внешний радиус: ");
            double radiusOut = double.Parse(Console.ReadLine());

            Ring r = new Ring(x, y, radiusIn, radiusOut);
            Console.WriteLine("Площадь кольца: " + r.RSquare + " Суммарная длина окружностей: " + r.RLength);     
        }
    }
}
