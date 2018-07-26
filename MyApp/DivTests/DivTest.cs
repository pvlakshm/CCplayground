using System;
using System.Linq;
using Xunit;

namespace DivTests
{
    public class DivTest
    {
        [Fact]
        public void divTest1()
        {
            int x = 6;
            int y = 6;
            int div = 1;

            var res = new DivOp.Div().div2(x, y);
            Assert.Equal(div, res);
        }
    }
}
