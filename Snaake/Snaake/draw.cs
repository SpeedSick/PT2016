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
        public Draw()
        {
            dragon = new snake();
            Wall = new wall();
            Food = new food();
        }
        public Draw(snake a, wall b, food c)
        {
            dragon = a; Wall = b; Food = c;
        }
        public void Print()
        {
            Console.Clear();
          //  Console.BackgroundColor = ConsoleColor.DarkCyan;
          //  Console.WriteLine(dragon.body.Count);

            for (int i = 0; i < dragon.body.Count; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(dragon.body[i].x, dragon.body[i].y);
                Console.Write('*');
            }
            for(int i = 0; i < Wall.body.Count; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(Wall.body[i].x, Wall.body[i].y);
                Console.Write('#');
            }
            for(int i = 0; i < Food.body.Count; ++i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(Food.body[i].x, Food.body[i].y);
                Console.Write('@');
            }
        }
        
    }
}