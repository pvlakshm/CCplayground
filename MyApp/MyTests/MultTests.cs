using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MyApp;


namespace MyTests
{
    public class MultTests
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
            int y =0;
            int res = 30;

            var val = new MyApp.Mult().multiply(x, y);
            Assert.Equal(res, val);
        }
    }
}
