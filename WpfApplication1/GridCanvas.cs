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
        /// <summary>
        /// Grille
        /// </summary>
        public Grid Grid { get; set; }

        /// <summary>
        /// List des objets contenus dans la grille
        /// </summary>
        private Dictionary<Point, IDrawable> _drawables;

        /// <summary>
        /// Constructeur
        /// </summary>
        public GridCanvas() : base()
        {
            Grid = new Grid(this);
            _drawables = new Dictionary<Point, IDrawable>();

            this.SizeChanged += GridCanvas_SizeChanged;
        }

        private void GridCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Grid.Draw();
        }

        public override void EndInit()
        {
            base.EndInit();
            Grid.Draw();
        }

        /// <summary>
        /// Ajout au canvas d'un objet drawable
        /// </summary>
        /// <param name="position"></param>
        /// <param name="drawable"></param>
        public void AddDrawable(Point position, IDrawable drawable)
        {
            var gridPosition = Grid.GridPosition(position);

            if (!_drawables.ContainsKey(gridPosition))
            {
                _drawables.Add(gridPosition, drawable);
                drawable.Draw(gridPosition);
                this.Children.Add(drawable.GetUIElement());
            }
        }
    }
}
