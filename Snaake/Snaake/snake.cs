using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snaake
{
    class snake : Program
    {
        public List<pair> body;
        public bool lose;
        public bool badmove(pair w)
        {
            for(int i = 0; i < Program.Wall.body.Count; ++i)
            {
                if (Program.Wall.body[i].x == w.x && Program.Wall.body[i].y == w.y)
                    return true;
            }
            for(int i = 0; i < body.Count; ++i)
            {
                if (body[i].x == w.x && body[i].y == w.y) return true;
            }
            return false;
        }
        public void makemove(int addx, int addy, int szx, int szy, food Food)
        {
            pair t = new pair((body[0].x + addx + szx) % szx, (body[0].y + addy + szy) % szy);
            if (badmove(t))
            {
                lose = true;
                return;
            }
            bool bigger = false;
            int pos = -1;
            for (int i = 0; i < Food.body.Count; ++i)
                if (Food.body[i].x == t.x && Food.body[i].y == t.y)
                {
                    bigger = true;
                    pos = i;
                }
            pair v = new pair();
            v = body[body.Count - 1];
            for (int i = body.Count - 1; i > 0; --i)
                body[i] = body[i - 1];
            if (bigger)
            {
                body.Add(v);
                Food.body.Remove(Food.body[pos]);
                pair w = new pair((getrand() % szx + szx) % szx, (getrand() % szy + szy) % szy);
                Food.add(w.x, w.y);
            }
            body[0] = t;
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
