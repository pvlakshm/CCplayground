using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Math
    {
        public int add(int x, int y)
        {
            if (x == 0)
                return y;
            else
                return x + y;
        }
    }
}
