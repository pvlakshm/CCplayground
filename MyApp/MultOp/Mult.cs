using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddOp;

namespace MultOp
{
    public class Mult
    {
        public int multiplyByRepeatedAddition(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            else if (y == 1)
            {
                return x;
            }
            else if (y == -1)
            {
                return -x;
            }
            else
            {
                var m = new AddOp.Add();

                for (int k = 0; k < y; k++)
                {
                    x = m.add(x, y);
                }

                return x;
            }
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public int multiplyComplicated(int x, int y)
        {
            int tenx = x * 10;
            int teny = y * 10;

            int prod = tenx * teny;
            int val = prod / 100;

            return val;
        }
    }
}
