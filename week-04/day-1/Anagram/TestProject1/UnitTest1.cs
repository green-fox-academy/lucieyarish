using System;
using Anagram;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string input1 = "dog";
            string input2 = "god";
            bool expected = true;

            AnagramClass myAnagram = new AnagramClass();
            bool actual = myAnagram.IsAnagram(input1, input2);
        }
    }
}