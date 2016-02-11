using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snaake 
{
    class Draw
    {
        public snake dragon;
        public wall Wall;
        public food Food;
        Draw()
        {
            dragon = new snake();
            Wall = new wall();
            Food = new food();
        }
        Draw(snake a, wall b, food c)
        {
            dragon = a, Wall = b, Food = c;
        }
        public static void out()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for(int i = 0; i < dragon.Body.Count; ++i)
            {
            
            }
        }
    }
}