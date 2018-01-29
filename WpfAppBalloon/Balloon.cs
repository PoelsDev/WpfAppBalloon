using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppBalloon
{
    class Balloon
    {
        private int x = 10;
        private int y = 10;
        private int diameter = 10;
        private Ellipse ellipse;      

        public Balloon()
        {
            CreateEllipse();
            UpdateEllipse();
        }
        
        public void MoveRight(int xStep)
        {
            x = x + xStep;
            UpdateEllipse();
        }

        public void MoveUp(int yStep)
        {
            y = y - yStep;
            UpdateEllipse();
        }

        public void ChangeColor()
        {
            Random rndGen = new Random();
            ellipse.Stroke = new SolidColorBrush(Color.FromRgb((byte) rndGen.Next(0,255), (byte)rndGen.Next(0,255), (byte)rndGen.Next(0,255)));
            ellipse.Fill = new SolidColorBrush(Color.FromRgb((byte)rndGen.Next(0, 255), (byte)rndGen.Next(0, 255), (byte)rndGen.Next(0, 255)));            
        }

        public void ChangeColor(Brush brush)
        {
            ellipse.Stroke = brush;
            ellipse.Fill = brush;
        }
        
        public void ChangeSize(int change)
        {
            diameter = diameter + change;
            UpdateEllipse();
        }

        public void DisplayOn(Canvas drawingArea)
        {
            drawingArea.Children.Add(ellipse);
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse();            
            ellipse.StrokeThickness = 5;
            ellipse.Stroke = new SolidColorBrush(Colors.BlueViolet);
        }

        private void UpdateEllipse()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);            
            ellipse.Height = diameter;
            ellipse.Width = diameter;
        }
        
    }
}
