using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    class Ring
    {
        private Round inRing;
        private Round outRing;
        public Ring(int x, int y, double radiusIn, double radiusOut)
        {
            inRing = new Round(x, y, radiusIn);
            outRing = new Round(x, y, radiusOut);
        }
        public double RSquare // Пока не работает idk
        {
            get
            {
                return outRing.Square() - inRing.Square();
            }
        }
        public double RLength
        {
            get
            {
                return inRing.Length() + outRing.Length();
            }
        }
    }
}
