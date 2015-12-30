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
    public class Grid
    {
        private List<Line> _lines;

        private Canvas _canvas;

        /// <summary>
        /// Largeur des cases de la grille
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="canvas"></param>
        public Grid(Canvas canvas)
        {
            _lines = new List<Line>();
            _canvas = canvas;
            Width = 20;
        }


        /// <summary>
        /// Supprime la grille
        /// </summary>
        public void Clear()
        {
            foreach (var item in _lines)
            {
                _canvas.Children.Remove(item);
            }

            _lines.Clear();
        }


        /// <summary>
        /// Dessine la grille sur le canvas
        /// </summary>
        public void Draw()
        {

            Clear();

            for (int i = 0; i < _canvas.Width; i += Width)
            {
                _lines.Add(new Line()
                {
                    Stroke = Brushes.LightGray,
                    StrokeThickness = 1,
                    X1 = i,
                    Y1 = 0,
                    X2 = i,
                    Y2 = _canvas.Height
                });
            }

            for (int i = 0; i < _canvas.Height; i += Width)
            {
                _lines.Add(new Line()
                {
                    Stroke = Brushes.LightGray,
                    StrokeThickness = 1,
                    X1 = 0,
                    Y1 = i,
                    X2 = _canvas.Width,
                    Y2 = i
                });
            }

            foreach (var item in _lines)
            {
                _canvas.Children.Add(item);
            }
        }

        /// <summary>
        /// Calcul la position d'un point dans la grille
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public Point GridPosition(Point point)
        {
            return new Point()
            {
                X = (point.X - (point.X % Width)),
                Y = (point.Y - (point.Y % Width))
            };
        }


    }
}
