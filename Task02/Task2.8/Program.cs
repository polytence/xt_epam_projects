using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8
{
    class Program
    {
        class Game
        {
            public Field Field { get; }
            public Player Player { get; }
            public Object Object { get; }
            public Monster Monster { get; }


            public Game(Field field, Player player)
            {
                Field = field;
                Player = player;
            }

        }
    }
}
