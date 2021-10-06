using System;
using System.Collections.Generic;
using Xunit;
using UniqueNumbers;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int[,] input = {{ 10}, {11}, {11}};
            List<int> expected = new List<int>{10, 11};

            //Act
            List<int> actual = Program.UniqueNumbersGenerator(input);

            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Test2()
        {
            //Arrange
            int[,] input = {{4}, {10}, {11}, {4}, {-10}, {-10}, {16}};
            List<int> expected = new List<int>{4, 10, 11, -10, 16};

            //Act
            List<int> actual = Program.UniqueNumbersGenerator(input);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}