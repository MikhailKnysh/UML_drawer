using ArrowLine.Table.StringData;
using System.Windows.Forms;

namespace ArrowLine
{
    public interface IMouseHandler
    {
        void OnMouseDown(AbstractFigure abstractFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip);

        void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e);
        void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e);

        void OnPaint(AbstractFigure currentFigure, PaintEventArgs e);
        IDTO OnToolStripMenuItemAddField_Click(StringDataForm stringDataForm);


    }
}
