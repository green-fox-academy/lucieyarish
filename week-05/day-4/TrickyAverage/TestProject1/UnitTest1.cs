using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            double[] input1 = {1, 3};
            double expected1 = 2;

            //Act
            double actual1 = TrickyAverage.Program.GetTrickyAvg(input1);

            //Assert
            //Fails because no even number is present
            Assert.Equal(expected1, actual1);
        }
        
        [Fact]
        public void Test2()
        {
            //Arrange
            double[] input2 = {1, 2, 3};
            double expected2 = 1.5;

            //Act
            double actual2 = TrickyAverage.Program.GetTrickyAvg(input2);

            //Assert
            //Fails because no even number is present
            Assert.Equal(expected2, actual2);
        }
    }
}