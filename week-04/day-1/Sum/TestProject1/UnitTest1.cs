using System;
using System.Collections.Generic;
using System.Linq;
using Sum;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int expected = 15;
            List<int> input = new List<int>{5, 10};

            var listOfNum = new Summing();
            int actual = listOfNum.SumAll(input);

            Assert.Equal(expected, actual);
        }
    }
}