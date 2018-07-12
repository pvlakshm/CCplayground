﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MyApp;

namespace MyTests
{
    public class SubTests
    {
        [Fact]
        public void subTest1()
        {
            int x = 5;
            int y = 6;
            int res = -1;

            var val = new MyApp.Math().sub(x, y);
            Assert.Equal(res, val);
        }

        [Fact]
        public void subTest2()
        {
            int x = 5;
            int y = 6;
            int res = -1;

            var val = new MyApp.Math().sub(x, y);
            Assert.Equal(res, val);
        }
    }
}
