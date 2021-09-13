using System;

namespace UrlFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit.
            // It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component,
            // find out what it is and insert it too!
            // Try to solve it more than once using different
            // string functions!

            //Adding colon:
            url = url.Insert(5, ":");

            // Change part of string with .Replace
            url = url.Replace("bots", "odds");

            Console.WriteLine(url);
        }
    }
}
