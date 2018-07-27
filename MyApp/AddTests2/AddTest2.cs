using System;
using System.Linq;
using Xunit;

namespace AddTests2
{
    public class AddTest2
    {
        [Fact]
        public void addTest2()
        {
            int x = 0;
            int y = 6;
            int sum = 6;

            var res = new AddOp.Add().add(x, y);
            Assert.Equal(sum, res);
        }
    }
}
