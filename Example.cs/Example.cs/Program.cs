using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Example.cs
{
    class point
    {
        public int x, y;
        public point() { x = 0;  y = 0; }
        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static point operator +(point a, point b)
        {
            return new point(Convert.ToInt32(Math.Sqrt(a.x * a.x + b.x * b.x + 0.0)), Convert.ToInt32(Math.Sqrt(a.y * a.y + b.y * b.y)));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int x, y;
            x = Convert.ToInt32(s[0]); y = Convert.ToInt32(s[1]);
            point a = new point(x, y);
            s = Console.ReadLine().Split();
            x = Convert.ToInt32(s[0]); y = Convert.ToInt32(s[1]);
            point b = new point(x, y);

            a = a + b;
            Console.WriteLine("(" + a.x + ", " + a.y + ")");
            Console.WriteLine("Hello world!");
            Console.ReadKey();
        }
    }
}
