﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snaake
{
    class pair
    {
        public int x, y;
        public pair()
        {
            x = y = 0;
        }
        public pair(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return x + " " + y;
        }
    }
}
