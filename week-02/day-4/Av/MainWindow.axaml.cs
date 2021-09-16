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
            //FourRectangles(foxDraw);

            // create a function that draws one square and takes 3 parameters:
            // the x and y coordinates of the square's top left corner
            // and the foxDraw and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.
            //PositionSquare(foxDraw);

            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.
            //CenterBoxFunction(foxDraw);

            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the
            // center of the canvas.
            // Create a loop that fills the canvas with rainbow
            // colored squares (red, orange, yellow, green, blue, indigo, violet).
            //RainbowBoxFunction(foxDraw);

            //PurpleSteps(foxDraw);

            //PurpleSteps3D(foxDraw);

            // UNFINISHED Fill the canvas with a checkerboard pattern. 
            //Checkerboard(foxDraw);

            // Create a function that draws a single line and takes 3 parameters:
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.
            //FunctionToCenter(foxDraw);

            // UNFINISHED Create a function that takes 2 parameters:
            // A list of (x, y) points and foxDraw
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}

            // UNFINISED Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

            // Line play
            LinePlay(foxDraw);

        }

        private void LinePlay(FoxDraw foxDraw)
        {
            int upperX = 0;
            int upperY = 60;
            int bottomX = 0;
            int bottomY = 500;
            foxDraw.SetStrokeThicknes(1);
            foxDraw.SetStrokeColor(Colors.Yellow);
            for (int i = 0; i < 10; i++)
            {
                upperY += 40;
                bottomX += 40;
                foxDraw.DrawLine(upperX, upperY, bottomX, bottomY);
            }

            foxDraw.SetStrokeColor(Colors.Purple);
            upperX = 60;
            upperY = 0;
            bottomX = 500;
            bottomY = 0;

            for (int i = 0; i < 10; i++)
            {
                upperX += 40;
                bottomY += 40;
                foxDraw.DrawLine(upperX, upperY, bottomX, bottomY);
            }

        }


        private void FunctionToCenter(FoxDraw foxDraw)
        {
            int upperX = 0;
            int upperY = 0;
            foxDraw.SetStrokeThicknes(1);
            foxDraw.SetStrokeColor(Colors.Azure);
            foxDraw.DrawLine(upperX, upperY, 250, 250);

            for (int i = 1; i < 25; i++)
            {
                upperY += 20;
                foxDraw.DrawLine(upperX, upperY, 250, 250);
            }
        }

        private void Checkerboard(FoxDraw foxDraw)
        {
            
            foxDraw.SetStrokeThicknes(2);
            foxDraw.SetStrokeColor(Colors.Purple);
            foxDraw.SetFillColor(Colors.Purple);
            int upperX = 0;
            int upperY = 0;
            int length = 50;
            foxDraw.DrawRectangle(upperX, upperY, length, length);
            for (int i = 0; i < 4; i++)
            {
                upperY += 100;
                foxDraw.DrawRectangle(upperX, upperY, length, length);
            }
            
        }

        private void PurpleSteps3D(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.Purple);
            foxDraw.SetFillColor(Colors.Purple);
            foxDraw.SetStrokeThicknes(2);
            int upperX = 10;
            int upperY = 10;
            int length = 15;

            foxDraw.DrawRectangle(upperX, upperY, length, length);
            for (int i = 0; i < 6; i++)
            {
                upperX = upperX + length;
                upperY = upperY + length;
                length += 15;
                foxDraw.DrawRectangle(upperX, upperY, length, length);
            }
        }

        private void PurpleSteps(FoxDraw foxDraw)
        {
            int upperX = 25;
            int upperY = 25;
            int length = 10;
            foxDraw.SetStrokeColor(Colors.Purple);
            foxDraw.SetStrokeThicknes(1);
            foxDraw.SetFillColor(Colors.MediumPurple);

            foxDraw.DrawRectangle(upperX, upperY, length, length);
            for (int i = 1; i < 20; i++)
            {
                upperX += 10;
                upperY += 10;
                foxDraw.DrawRectangle(upperX, upperY, length, length);
            }
        }

        private void RainbowBoxFunction(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.Black);
            foxDraw.SetStrokeThicknes(3);
            foxDraw.SetFillColor(Colors.Red);
            int upperX = 100;
            int upperY = 100;
            int length = 300;
            Color[] colors = { Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet };

            foxDraw.DrawRectangle(upperX, upperY, length, length);
            for (int i = 1; i <= 5; i++)
            {
                foxDraw.SetFillColor(colors[i]);
                upperX += 25;
                upperY += 25;
                length -= 50;
                
                foxDraw.DrawRectangle(upperX, upperY, length, length);
            }
        }

        private void CenterBoxFunction(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.Black);
            foxDraw.SetStrokeThicknes(3);
            foxDraw.SetFillColor(Colors.Salmon);
            int upperX = 175;
            int upperY = 175;
            int length = 150;
            Color[] colors = { Colors.Salmon, Colors.White, Colors.Gray };

            foxDraw.DrawRectangle(upperX, upperY, length, length);
            for (int i = 1; i < 3; i++)
            {
                foxDraw.SetFillColor(colors[i]);
                upperX += 25;
                upperY += 25;
                for (int j = 1; j < 3; j++)
                {
                    length -= 25;
                }
                foxDraw.DrawRectangle(upperX, upperY, length, length);
            }
        }

        private void PositionSquare(FoxDraw foxDraw)
        {
            int upperX = 0;
            int upperY = 0;
            int length = 50;
            foxDraw.DrawRectangle(upperX, upperY, length, length);
            for (int i = 1; i < 3; i++)
            {
                upperX += 50;
                upperY += 50;
                foxDraw.DrawRectangle(upperX, upperY, length, length);
            }
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
