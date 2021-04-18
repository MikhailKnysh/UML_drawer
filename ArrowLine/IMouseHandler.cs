using ArrowLine.Arrow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowLine
{
    public interface IMouseHandler
    {
        AbstractFigure currentFigure;
        void OnMouseDown(MouseEventArgs e);

        void OnMouseUp();

        void OnMouseMove();
        void OnPaint();


    }
}
