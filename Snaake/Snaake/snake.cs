using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snaake
{
    class snake
    {
        public List<pair> body;
        public bool lose;
        public void makemove(int addx, int addy, int szx, int szy)
        {
            for (int i = 1; i < body.Count; ++i)
                body[i] = body[i - 1];
            body[0].x = (body[0].x + addx + szx) % szx;
            body[0].y = (body[0].y + addy + szy) % szy;
        }
        public snake()
        {
            lose = false;
            body = new List<pair>();
        }
        public snake (int x, int y)
        {
            lose = false;
            body = new List<pair>();
            body.Add(new pair(x, y));
        }
    }
}
