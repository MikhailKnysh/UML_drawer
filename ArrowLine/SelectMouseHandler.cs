using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowLine
{
    public class SelectMouseHandler : IMouseHandler
    {
        public void OnMouseDown(AbstractFigure abstractFigure,MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {
            throw new NotImplementedException();
        }

        public void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnMouseUp(AbstractFigure currentFigure)
        {
            throw new NotImplementedException();
        }

        public void OnPaint(AbstractFigure currentFigure)
        {
            throw new NotImplementedException();
        }
    }
}
