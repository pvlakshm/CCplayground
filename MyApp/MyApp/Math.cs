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
            else if (y == 0)
                return x;
            else
                return x + y;
        }

        public int sub(int x, int y)
        {
            if (y == 0)
                return x;

            return add(x, (-y));
        }

        public int div(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException();

            return x / y;
        }
    }
}
