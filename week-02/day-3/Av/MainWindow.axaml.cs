using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace Av
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);


            foxDraw.SetBackgroundColor(Colors.Black);
            foxDraw.SetFillColor(Colors.White);
            foxDraw.SetStrokeColor(Colors.White);
            foxDraw.SetStrokeThicknes(5);


            // draw a red horizontal line to the canvas' middle
            //DrawRedHorizontalLine(foxDraw);

            // draw a green vertical line to the canvas' middle.
            //DrawGreenVerticalLine(foxDraw);

            // Draw a box that has different colored lines on each edge.
            //DrawColorfulBox(foxDraw);

            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner
            // it should be green, otherwise it should be red.
            DrawDiagonals(foxDraw);
        }

        private void DrawDiagonals(FoxDraw foxDraw)
        {
            foxDraw.DrawLine
           
        }

        private void DrawColorfulBox(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor (Colors.Green);
            foxDraw.DrawLine(new Point(100, 100), new Point(400, 100));
            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(new Point(100, 100), new Point(100, 400));
            foxDraw.SetStrokeColor(Colors.Yellow);
            foxDraw.DrawLine(new Point(100, 400), new Point(400, 400));
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(new Point(400, 100), new Point(400, 400));

        }

        private void DrawGreenVerticalLine(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(new Point(250, 0), new Point(250, 500));
        }

        private void DrawRedHorizontalLine(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(new Point(0, 250), new Point(500, 250));
        }

        

        

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
