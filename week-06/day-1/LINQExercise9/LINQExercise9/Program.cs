using System;
using System.Linq;
using System.Threading.Channels;

namespace LINQExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] myCharArr = new[] {'h', 'e', 'y'};
            var convertCharArrToStrLambda = string.Join("", myCharArr.Select(c => c.ToString()));
        }
    }
}