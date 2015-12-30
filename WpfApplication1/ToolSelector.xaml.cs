using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour ToolSelector.xaml
    /// </summary>
    public partial class ToolSelector : UserControl
    {

        int height = 60;

        private List<IDrawable> _drawables;

        public ToolSelector()
        {
            InitializeComponent();
            _drawables = new List<IDrawable>();

            _drawables.Add(new Square(20));
        }


        public void Draw()
        {
            foreach (var item in _drawables)
            {
                item.Draw(new Point(0,0));
                pnl.Children.Add(item.GetUIElement());
            }
        }
    }
}
