using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine
{
    public class DrawMouseHandler : IMouseHandler
    {
        public AbstractFigure currentFigure ;

            Form1 form1 = new Form1();
        public void OnMouseDown(MouseEventArgs e)
        {
            
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        currentFigure._startPoint = e.Location;
                        currentFigure._endPoint = e.Location;
                    }
                    break;
                case MouseButtons.Right:
                    {
                        form1.ContextMenuStrip.Show(form1, new Point(e.X + 120, e.Y));
                       
                        break;
                    }
            }
            //    table.startPoint = e.Location;
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
