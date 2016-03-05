using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snaake
{
    class food
    {
        public List<pair> body;
        public food(int x, int y)
        {
            body = new List<pair>();
        }
        public food()
        {
            body = new List<pair>();
        }
        public void add(int x, int y)
        {
            pair t = new pair(x, y);
            body.Add(t);
        }
    }
}
