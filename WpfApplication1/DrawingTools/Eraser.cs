using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApplication1.Controls;

namespace WpfApplication1.DrawingTools
{
    public class Eraser : IDrawingTool
    {
        private GridCanvas _canvas;

        public Eraser(GridCanvas canvas)
        {
            _canvas = canvas;
        }

        public void MouseDown(object sender, MouseButtonEventArgs e)
        {
            _canvas.RemoveDrawable(e.GetPosition(_canvas));
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
                return;

            _canvas.RemoveDrawable(e.GetPosition(_canvas));
        }

        public void MouseUp(object sender, MouseButtonEventArgs e)
        {
            return;
        }
    }
}
