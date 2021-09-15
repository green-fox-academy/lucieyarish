using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

namespace DrawingApplication
{
    public class MainWindow : Window
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
            foxDraw.SetFillColor(Colors.Blue);

            foxDraw.DrawPolygon(new List<Point> 
            {
               new Point(Width / 2, 20),
               new Point(Width / 2 - 50, 100),
               new Point(Width / 2, 180),
               new Point(Width / 2 + 50, 100) 
            });

         
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}