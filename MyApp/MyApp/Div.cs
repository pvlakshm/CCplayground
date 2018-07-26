using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Div
    {
        public int div2(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException();

            return x / y;
        }
    }
}
