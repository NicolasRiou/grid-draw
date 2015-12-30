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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
                return;

            _canvas.AddDrawable(e.GetPosition(_canvas), new Square(_canvas.Grid.Width));
        }

        private void _canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
        }

        private void _canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _canvas.AddDrawable(e.GetPosition(_canvas), new Square(_canvas.Grid.Width));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int step = 10;
            _canvas.Grid.Width = Math.Min(_canvas.Grid.Width + step, (int)_canvas.Height);
            _canvas.Grid.Draw();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int step = 10;
            _canvas.Grid.Width = Math.Max(_canvas.Grid.Width - step, 10);
            _canvas.Grid.Draw();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            _canvas.Grid.Draw();
        }
    }
}
