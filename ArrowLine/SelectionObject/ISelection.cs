using ArrowLine.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
