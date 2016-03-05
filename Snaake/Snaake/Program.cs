using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snaake
{
    class Program
    {
        public static int seed = 124, A = 39, B = 57;
        public static int[] dx = { 0, 0, -1, 1 };
        public static int[] dy = { 1, -1, 0, 0 };
        public static int[,] a = new int[100,100];
        public static int szx = 45, szy = 30;
        public static wall Wall, copyWall;
        public static food Food, copyFood;
        public static snake copyDragon;

        static public int getrand()
        {
            const int Mod = 1000000007;
            seed = seed * 239 % Mod;
            int x = (seed * A + B) % Mod;
            return x;

        }
        static bool playlevel(int level)
        {
            Console.SetWindowSize(szx, szy);
            Console.Clear();
            Console.WriteLine("Welcome to level {0}", level);
            Console.ReadKey();
            Console.SetCursorPosition(1, 1);
            snake dragon = new snake(1, 1);
            Wall = new wall();
            Food = new food();
            for(int i = 0; i < level+1; ++i)
            {
                pair t = new pair((getrand() % szx + szx) % szx, (getrand() % szy + szy) % szy);
                Food.add(t.x, t.y);
            }
            for (int i = 0; i < 4 * level; ++i)
            {
                pair t = new pair((getrand() % szx + szx) % szx, (getrand() % szy + szy) % szy);
                while(t.x == 1 && t.y == 1)
                    t = new pair((getrand() % szx + szx) % szx, (getrand() % szy + szy) % szy);
                Wall.add(t.x, t.y);
            }
            Draw risovanie = new Draw(dragon, Wall, Food);
            while (!risovanie.dragon.lose)
            {
                ConsoleKeyInfo button = Console.ReadKey();
                if(button.Key == ConsoleKey.UpArrow)
                {
                    dragon.makemove(0, -1, szx, szy, Food);
                }
                else if(button.Key == ConsoleKey.DownArrow)
                {
                    dragon.makemove(0, +1, szx, szy, Food);
                }
                else if (button.Key == ConsoleKey.RightArrow)
                {
                    dragon.makemove(1, 0, szx, szy, Food);
                }
                else if (button.Key == ConsoleKey.LeftArrow)
                {
                    dragon.makemove(-1, 0, szx, szy, Food);
                }
                if (dragon.body.Count % (level + 5) == 0)
                    return true;
                risovanie.Print();
            }
            if(dragon.lose)
            {
                Console.Clear();
                Console.WriteLine("You Lost");
                Console.ReadKey();
                return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            int level = 1;
            while (true)
            {
                bool qwer = playlevel(level);
                if (qwer) level++;
                else level = 1;
                if(level == 20)
                {
                    Console.Clear();
                    Console.WriteLine("You WON!!!");
                    return;
                }
            }
        }
    }
}
