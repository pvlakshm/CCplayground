using System;
using System.Linq;
using Xunit;

namespace MultTests
{
    public class MultTest
    {
        [Fact]
        public void multTest1()
        {
            int x = 5;
            int y = 6;
            int res = 30;

            var val = new MyApp.Mult().multiply(x, y);
            Assert.Equal(res, val);
        }

        [Fact]
        public void multTest2()
        {
            int x = 5;
            int y = 0;
            int res = 30;

            var val = new MyApp.Mult().multiply(x, y);
            Assert.Equal(res, val);
        }
    }
}
