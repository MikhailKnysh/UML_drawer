using System.Windows.Forms;
using System.Windows.Forms;

namespace ArrowLine
{
    public interface IMouseHandler
    {
        void OnMouseDown(MouseEventArgs e);

        void OnMouseUp();

        void OnMouseMove();
        void OnPaint();


    }
}
