using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    class Rectangle
    {
        private int x;
        private int y;

        public Rectangle(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public double RectangleSquard()
        {
              return x * y;  
        }
    }
}
