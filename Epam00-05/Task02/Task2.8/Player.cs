using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8
{
    class Player : IMoveable
    {
        public int Health { get; }
        public int Mana { get; }

        public Player()
        {
            Health = 100;
            Mana = 100;
        }

    }
}
