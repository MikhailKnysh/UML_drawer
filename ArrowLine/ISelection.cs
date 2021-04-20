using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    interface ISelection
    {
     
        bool HitTest(Point pt);

        bool HitTest(Rectangle r);

        void DrawOverlay(Brush brush, AbstractFigure objectRectangle);
    }
}
