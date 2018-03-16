using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Mult
    {
        public int multiply(int x, int y)
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
                var m = new MyApp.Math();

                for (int k = 0; k < y; k++)
                {
                    x = m.add(x, y);
                }

                return x;
            }
        }
    }
}
