using System.Collections.Generic;
namespace Sum
{
    public class Summing
    {
        public int SumAll (List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum = sum + numbers[i];
            }
            return sum;
        }
    }
}