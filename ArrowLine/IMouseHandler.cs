using System.Windows.Forms;

namespace ArrowLine
{
    public interface IMouseHandler
    {
        void OnMouseDown(AbstractFigure figure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip);

        void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e);
        void OnMouseUp(AbstractFigure currentFigure);

        void OnPaint(AbstractFigure currentFigure);


    }
}
