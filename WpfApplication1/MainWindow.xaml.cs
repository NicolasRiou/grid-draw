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
using WpfApplication1.DrawingTools;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDrawingTool _tool;

        private SquareMaker _squareMaker;
        private Eraser _eraser;


        public MainWindow()
        {
            InitializeComponent();
            _squareMaker = new SquareMaker(_canvas);
            _eraser = new Eraser(_canvas);
            _tool = _squareMaker;
        }

        private void _canvas_MouseMove(object sender, MouseEventArgs e)
        {
            _tool.MouseMove(sender, e);
        }

        private void _canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _tool.MouseUp(sender, e);
        }

        private void _canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _tool.MouseDown(sender, e);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            _canvas.GridPlus();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            _canvas.GridMinus();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            _tool = _squareMaker;
        }

        private void button2_Copy_Click(object sender, RoutedEventArgs e)
        {
            _tool = _eraser;
        }
    }
}
