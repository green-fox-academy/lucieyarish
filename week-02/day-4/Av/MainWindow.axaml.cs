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
            //DrawDiagonals(foxDraw);

            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.
            //GoToCenter(foxDraw);

            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the foxDraw
            // and draws a 50 long horizontal line from that point.
            // Draw at least 3 lines with that function using a loop.
            //HorizontalLines(foxDraw);

            // Draw a green 10x10 square to the canvas' center.
            //CenteredSquare(foxDraw);
            //CenteredSquareEasy(foxDraw);

            // draw four different size and color rectangles.
            // avoid code duplication.
            FourRectangles(foxDraw);


        }

        private void FourRectangles(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.White);
            foxDraw.SetFillColor(Colors.Red);
            int upperX = 0;
            int upperY = 0;
            int length = 50;
            Color[] colors = {Colors.Yellow, Colors.Green, Colors.Blue, Colors.Red};

            foxDraw.DrawRectangle(upperX, upperY, length, length);
            for (int i = 0; i < 4; i++)
            {
                foxDraw.SetFillColor(colors[i]);
                upperX = upperX + length;
                upperY = upperY + length;
                length += 50;
                foxDraw.DrawRectangle(upperX, upperY, length, length);
               

            }
            
        }

        private void CenteredSquareEasy(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.Salmon);
            foxDraw.SetFillColor(Colors.Salmon);
            foxDraw.DrawRectangle(245, 255, 10, 10);
        }

        private void CenteredSquare(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeThicknes(1);
            foxDraw.SetStrokeColor(Colors.Pink);
            foxDraw.SetFillColor(Colors.Pink);
            foxDraw.DrawLine(245, 245, 255, 245);
            foxDraw.DrawLine(255, 245, 255, 255);
            foxDraw.DrawLine(255, 255, 245, 255);
            foxDraw.DrawLine(245, 255, 245, 245);
        }

        private void HorizontalLines(FoxDraw foxDraw)
        {
            var upperY = 100;
            var bottomY = 100;
            foxDraw.DrawLine(0, upperY, 50, bottomY);

            for (int i = 1; i < 3; i++)
            {
                upperY += 100;
                bottomY += 100;
                foxDraw.DrawLine(0, upperY, 50, bottomY);
            }

        }

        private void GoToCenter(FoxDraw foxDraw)
        {
            int upperX = 0;
            int upperY = 0;
            foxDraw.DrawLine(upperX, upperY, 250, 250);

            for (int i = 1; i < 3; i++)
            {
                upperY += 250;
                foxDraw.DrawLine(upperX, upperY, 250, 250);

            }
        }

        private void DrawDiagonals(FoxDraw foxDraw)
        {
            int upperX = 0;
            int upperY = 0;
            int bottomX = 0;
            int bottomY = 0;
            foxDraw.DrawLine(upperX, upperY, bottomX, bottomY);

            if (upperX == 0 && upperY == 0)
            {
                foxDraw.SetStrokeColor(Colors.Green);
                foxDraw.DrawLine(upperX, upperY, 500, 500);
            }else
            {
                foxDraw.SetStrokeColor(Colors.Red);
                foxDraw.DrawLine(500, upperY, bottomX, 500);
            }
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
