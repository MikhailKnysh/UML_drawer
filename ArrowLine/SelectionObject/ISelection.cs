using ArrowLine.Abstract;
using System.Drawing;

namespace ArrowLine.SelectionObject
{
    public interface ISelection
    {
        bool HitObjectArea(Point point);

        bool HitObjectArea(Rectangle rectangle);

        void DrawOverlay(Point point);

        void DrawOverlay(Brush brush, AbstractFigure objectRectangle);
    }
}
