using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public class Square : IDrawable
    {
        private Rectangle _rectangle;
        private int _width;

        public Square()
        {

        }

        public Square(int width)
        {
            _width = width;
        }

        public void Draw(Point position)
        {
            _rectangle = new Rectangle()
            {
                Fill = new SolidColorBrush(Colors.Black),
                Stroke = new SolidColorBrush(Colors.Black),
                Width = _width,
                Height = _width
            };

            Canvas.SetLeft(_rectangle, position.X);
            Canvas.SetTop(_rectangle, position.Y);
        }

        public UIElement GetUIElement()
        {
            return _rectangle;
        }

        public void SetWidth(int width)
        {
            _width = width;
        }
    }
}
