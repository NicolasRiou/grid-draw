using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public class Shape
    {
        private Rectangle _rectangle;
        private Point _startPoint;

        public void MouseDown(Canvas canvas, Point mousePosition)
        {

            _startPoint = mousePosition;

            _rectangle = new Rectangle()
            {
                Stroke = Brushes.Aqua,
                StrokeThickness = 2
            };

            Canvas.SetLeft(_rectangle, _startPoint.X);
            Canvas.SetRight(_rectangle, _startPoint.Y);
            canvas.Children.Add(_rectangle);
        }


        public void MouseMove(MouseEventArgs e, Canvas canvas, Point mousePosition)
        {
            if (e.LeftButton == MouseButtonState.Released)
                return;

            if (_rectangle != null)
            {
                var x = Math.Min(mousePosition.X, _startPoint.X);
                var y = Math.Min(mousePosition.Y, _startPoint.Y);

                var w = Math.Max(mousePosition.X, _startPoint.X) - x;
                var h = Math.Max(mousePosition.Y, _startPoint.Y) - y;

                _rectangle.Width = w;
                _rectangle.Height = h;

                Canvas.SetLeft(_rectangle, x);
                Canvas.SetTop(_rectangle, y);
            }
        }

        public void MouseUp()
        {
            _rectangle = null;
        }
    }
}
