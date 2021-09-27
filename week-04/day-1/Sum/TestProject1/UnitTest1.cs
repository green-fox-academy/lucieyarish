using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Sum;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int expected = 6;
            List<int> input = new List<int> {3, 3};

            var listOfNum = new Summing();
            int actual = listOfNum.SumAll(input);

            Assert.Equal(expected, actual);
        }

        // [Theory]
        // [InlineData(List<int>{0}, List<int>{0})]
        //
        // public void Test2(List<int> input, List<int> expected)
        // {
        //     Summing summing = new Summing();
        //     summing.SumAll(input);
        //
        //
        // }

    }
}