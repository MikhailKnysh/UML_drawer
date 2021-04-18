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
        public AbstractFigure currentFigure { get ; set ; }

        public void OnMouseDown(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnMouseMove()
        {
            throw new NotImplementedException();
        }

        public void OnMouseUp()
        {
            throw new NotImplementedException();
        }

        public void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}
