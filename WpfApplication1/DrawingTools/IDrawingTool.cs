using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{
    public interface IDrawingTool
    {
        void MouseMove(object sender, MouseEventArgs e);
        void MouseUp(object sender, MouseButtonEventArgs e);
        void MouseDown(object sender, MouseButtonEventArgs e);

    }
}
