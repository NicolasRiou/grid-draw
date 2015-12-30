using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApplication1.Controls;

namespace WpfApplication1
{
    public class SquareMaker : IDrawingTool
    {
        private GridCanvas _canvas;


        public SquareMaker(GridCanvas canvas)
        {
            _canvas = canvas;
        }


        public void MouseDown(object sender, MouseButtonEventArgs e)
        {
            _canvas.AddDrawable(e.GetPosition(_canvas), new Square());
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
                return;

            _canvas.AddDrawable(e.GetPosition(_canvas), new Square(20));
        }

        public void MouseUp(object sender, MouseButtonEventArgs e)
        {
            return;
        }
    }
}
