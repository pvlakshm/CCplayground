using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SubTests
{
    public class SubTest
    {
        [Fact]
        public void subTest1()
        {
            int x = 5;
            int y = 6;
            int res = -1;

            var val = new SubOp.Sub().sub(x, y);
            Assert.Equal(res, val);
        }

        [Fact]
        public void subTest2()
        {
            int x = 5;
            int y = 6;
            int res = -1;

            var val = new SubOp.Sub().sub(x, y);
            Assert.Equal(res, val);
        }
    }
}
