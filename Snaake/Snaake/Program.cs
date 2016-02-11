using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snaake
{
    class Program
    {
        public static int[] dx = { 0, 0, -1, 1 };
        public static int[] dy = { 1, -1, 0, 0 };
        public static int[,] a = new int[100,100];
        public static int szx = 45, szy = 30;
        static void draw(int[,] a, snake dragon)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < szx; ++i)
                for (int j = 0; j < szy; ++j)
                    a[i, j] = 0;
            for (int i = 0; i < dragon.body.Count; ++i)
            {
                Console.SetCursorPosition(dragon.body[i].x, dragon.body[i].y);
                Console.Write('*');

            }
        }
        static void playlevel(int level)
        {
            Console.SetWindowSize(szx, szy);
            Console.WriteLine("Welcome to level {0}", level);
            Console.SetCursorPosition(1, 1);
            snake dragon = new snake(1, 1);
            Console.Clear();
            draw(a, dragon);
            while (!dragon.lose)
            {
                ConsoleKeyInfo button = Console.ReadKey();
                if(button.Key == ConsoleKey.UpArrow)
                {
                    dragon.makemove(0, -1, szx, szy);
                }
                else if(button.Key == ConsoleKey.DownArrow)
                {
                    dragon.makemove(0, +1, szx, szy);
                }
                else if (button.Key == ConsoleKey.RightArrow)
                {
                    dragon.makemove(1, 0, szx, szy);
                }
                else if (button.Key == ConsoleKey.LeftArrow)
                {
                    dragon.makemove(-1, 0, szx, szy);
                }
                Console.Clear();
                draw(a, dragon);
            }
            if(dragon.lose)
            {
                Console.WriteLine("You Lost");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            int level = 1;
            while (true)
            {
                playlevel(level);
            }
        }
    }
}
