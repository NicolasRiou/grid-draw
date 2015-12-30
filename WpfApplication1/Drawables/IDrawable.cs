using System.Windows;

namespace WpfApplication1
{
    public interface IDrawable
    {
        UIElement GetUIElement();
        void Draw(Point position);
        void SetWidth(int width);
    }
}