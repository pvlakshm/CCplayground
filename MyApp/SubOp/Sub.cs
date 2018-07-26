using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddOp;

namespace SubOp
{
    public class Sub
    {
        public int sub(int x, int y)
        {
            if (y == 0)
                return x;

            return new AddOp.Add().add(x, (-y));
        }
    }
}
