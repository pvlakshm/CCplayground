using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Add
    {
        public int add(int x, int y)
        {
            if (x == 0)
                return y;
            else if (y == 0)
                return x;
            else
                return x + y;
        }
    }
}
