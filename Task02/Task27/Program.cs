using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите цифру фигуры чтобы выбрать: 1) Прямоугольник 2)Линия 3)Окружность 4)Круг 5)Кольцо");
            int n = int.Parse(Console.ReadLine());
            switch (n) 
            {
                case 1:
                    Rectangle a = new Rectangle(x, y);
                    Console.WriteLine("Тип" + Rectangle.GetType());
                    Console.WriteLine(a.RectangleSquard());
                    Console.WriteLine("x= "+ x +" y = "+y);
                    break;
                case 2:
                    Line b = new Line(x, y)
                    Console.WriteLine("Case 1");
                    Console.WriteLine("x= "+ x + " y = " + y);
                    break;
                case 3:
                    Console.WriteLine("Введите радиус");
                    int radius = int.Parse(Console.ReadLine());
                    Circle c = new Circle(radius);
                    Console.WriteLine("Case 1");
                    Console.WriteLine("x= "+ x + " y = " + y);
                    break;
                case 4:
                    Console.WriteLine("Введите радиус");
                    int radius1 = int.Parse(Console.ReadLine());
                    Round d = new Round(x, y, radius1);
                    Console.WriteLine("Case 1");
                    break;
                case 5:
                    Console.WriteLine("Введите внутрений радиус");
                    int radiusIn = int.Parse(Console.ReadLine()); 
                    Console.WriteLine("Введите внешний радиус");
                    int radiusOut = int.Parse(Console.ReadLine());
                    Ring f = new Ring(x, y, radiusIn, radiusOut);
                    Console.WriteLine("Case 1");
                    break;
            }
        }
    }
}
