using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snaake
{
    class wall
    {
        public List<pair> body;
        public wall()
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
