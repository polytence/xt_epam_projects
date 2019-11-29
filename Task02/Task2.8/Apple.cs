using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8
{
    public class Apple : Bonus
    {
        public int Heal { get; private set; }
        public Apple(int heal, int x, int y)
            : base(x, y)
        {
            Heal = heal;
        }

        
    }
}
