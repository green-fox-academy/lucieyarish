using System.Linq;
using Frontend.Models;
using Microsoft.Extensions.Logging.EventSource;

namespace Frontend.Services
{
    public class SithReverserService
    {
        public string ReverseText(string textToReverse)
        {

            string toBeReversed = textToReverse;
            for (int i = toBeReversed.Length - 1; i >= 0; i--)
            {
                var c = toBeReversed[i];
            }
            return toBeReversed;
            // string[] words = textToReverse.Split(' ');
            // string temp;
            // int j = words.Length - 1;
            // for (int i = 0; i < j; i++)
            // {
            //     temp = words[i];
            //     words[i] = words[j];
            //     words[j] = temp;
            // }
            // var reversedArr = words.Reverse().Select(c => new string(c.Reverse().ToArray())).ToArray();
            // string reversedText = string.Join(' ', reversedArr);
        }
        

        
    }
}