using System;
using System.Drawing;
using System.Windows.Forms;
using ArrowLine.Table;

namespace ArrowLine
{
    public class DrawMouseHandler : IMouseHandler
    {
        public DataPictureBox singltone = DataPictureBox.GetInstance();

        //Form1 form1 = new Form1();
        //public AbstractFigure currentFigure= new AgregationEndArrow();
        //public AbstractTable table = new InterfaceTable();
        

        public void OnMouseDown(AbstractFigure currentFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        currentFigure.startPoint = e.Location;
                        currentFigure.endPoint = e.Location;
                        //table.startPoint = e.Location;
                    }
                    break;
                case MouseButtons.Right:
                    {
                        singltone.isMoving = false;
                        contextMenuStrip.Show(form, new Point(e.X + 120, e.Y));
                        break;
                    }
            }
        }

        public void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e)
        {
            currentFigure.endPoint = e.Location;

        }

        public void OnMouseUp(AbstractFigure currentFigure)
        {
            if (currentFigure != null)
            {
                singltone.tables.Add(currentFigure);
            }
        }

        public void OnPaint(AbstractFigure currentFigure)
        {
            currentFigure.Draw();
        }
    }
}
