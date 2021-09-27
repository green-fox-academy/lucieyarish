using System;

namespace Anagram
{
    public class AnagramClass
    {
        public bool IsAnagram(string input1, string input2)
        {
            // string[] inputArr = new[] {input1, input2};
            if (input1.Length == input2.Length)
            {
                return true;
            }

            char[] input1Arr = input1.ToCharArray();
            char[] input2Arr = input2.ToCharArray();
            
            Array.Sort(input1Arr);
            Array.Sort(input2Arr);

            input1 = new string(input1Arr);
            input2 = new string(input2Arr);

            return input1 == input2;
        }
    }
}