using System;
namespace PostIt
{
    public class PostIt
    {
        private string BackgroundColor;
        private string Text;
        private string TextColor;

        public PostIt(string backgroundColor, string text, string textColor)
        {
            BackgroundColor = backgroundColor;
            Text = text;
            TextColor = textColor;
        }

        public void PrintPostItColor()
        {
            Console.WriteLine($"My background is { BackgroundColor }, my text is { TextColor }, and I say { Text }");
        }
    }
}
