using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8
{
    class Rock : Object
    {
        public int Heal { get; private set; }
        public Rock(int heal, int x, int y)
            : base(x, y)
        {
        
        }
    }
}
