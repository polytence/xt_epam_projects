using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8
{
    class Cherry : Bonus
    {
        public int Heal { get; private set; }
        public Cherry(int heal, int x, int y)
            : base(x, y)
        {
            Heal = heal;
        }
    }
}
