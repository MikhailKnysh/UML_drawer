using ArrowLine.Abstract;
using ArrowLine.Table.StringData;
using System.Windows.Forms;

namespace ArrowLine.Handler
{
    public interface IMouseHandler
    {

        void OnMouseDown(AbstractFigure currentFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip);

        void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e);
        void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e);

        void OnPaint(AbstractFigure currentFigure, PaintEventArgs e);
        IDTO OnToolStripMenuItemAddStringDataTable_Click(StringDataForm stringDataForm);


    }
}
