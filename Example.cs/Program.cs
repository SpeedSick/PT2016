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
        public static point operator + (point a, point b)
        {
            return new point (int32(Math.Sqrt(a.x * a.x + b.x * b.x + 0.0)), Math.Sqrt(a.y * a.y + b.y * b.y));   
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int x, y;
            x = int.Parse(s); y = int.Parse(s);
            point a = new point(x, y);
            s = Console.ReadLine();
            x = int.Parse(s); y = int.Parse(s);
            point b = new point(x, y);
            a = a + b;
            Console.WriteLine('(' + a.x + ", " + a.y + ')');

        }
    }
}
