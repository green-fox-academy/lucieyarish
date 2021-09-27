using System;
using Apples;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string expected = "apple";
            Apple apple = new Apple();

            string actual = apple.GetApple();

            Assert.Equal(expected, actual);
        }
    }
}