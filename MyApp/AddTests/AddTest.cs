﻿using System;
using System.Linq;
using Xunit;

namespace AddTests
{
    public class AddTest
    {
        [Fact]
        public void addTest1()
        {
            int x = 5;
            int y = 6;
            int sum = 11;

            var res = new AddOp.Add().add(x, y);
            Assert.Equal(sum, res);
        }
    }
}
