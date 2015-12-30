using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApplication1.Controls
{
    public class GridCanvas : Canvas
    {
        private const int defaultWidth = 20;


        /// <summary>
        /// Grille
        /// </summary>
        private Grid _grid;

        /// <summary>
        /// List des objets contenus dans la grille
        /// </summary>
        private Dictionary<Point, IDrawable> _drawables;

        /// <summary>
        /// Constructeur
        /// </summary>
        public GridCanvas() : base()
        {
            _grid = new Grid(this, defaultWidth);
            _drawables = new Dictionary<Point, IDrawable>();

            this.SizeChanged += GridCanvas_SizeChanged;
        }

        /// <summary>
        /// Redessine la grille au changement de taille du canvas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            _grid.Draw();
        }

        /// <summary>
        /// Ajout au canvas d'un objet drawable
        /// </summary>
        /// <param name="position"></param>
        /// <param name="drawable"></param>
        public void AddDrawable(Point position, IDrawable drawable)
        {
            var gridPosition = _grid.GridPosition(position);

            if (!_drawables.ContainsKey(gridPosition))
            {
                drawable.SetWidth(_grid.Width);
                drawable.Draw(gridPosition);
                this.Children.Add(drawable.GetUIElement());

                _drawables.Add(gridPosition, drawable);
            }
        }

        public void RemoveDrawable(Point position)
        {
            var gridPosition = _grid.GridPosition(position);

            if (_drawables.ContainsKey(gridPosition))
            {
                var drawable = _drawables[gridPosition];
                this.Children.Remove(drawable.GetUIElement());
                _drawables.Remove(gridPosition);
            }
        }

        public void GridPlus()
        {
            int step = 10;
            _grid.Width = Math.Min(_grid.Width + step, (int)Height);
            _grid.Draw();
        }

        public void GridMinus()
        {
            int step = 10;
            _grid.Width = Math.Max(_grid.Width - step, 10);
            _grid.Draw();
        }
    }
}
