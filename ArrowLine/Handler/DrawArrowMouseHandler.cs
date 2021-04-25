using ArrowLine.Abstract;
using ArrowLine.Table.StringData;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine.Handler
{
    public class DrawArrowMouseHandler : IMouseHandler
    {

        public DataPictureBox singltone = DataPictureBox.GetInstance();


        public void OnMouseDown(AbstractFigure currentFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {

            foreach (var item in CollectionFigure.tables)
            {
                if (item.Type == FigureType.Table)
                {
                    var rectangle = item as AbstractTable;

                    if (rectangle.Contain(e.Location))
                    {
                        CheckStartPointLocation(rectangle, currentFigure, e);
                        return;
                    }
                }
            }

        }

        public void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentFigure.endPoint = e.Location;
            }
        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            if (currentFigure != null && e.Button == MouseButtons.Left && currentFigure.startPoint.X != 0 && currentFigure.startPoint.Y != 0)
            {
                CollectionFigure.tables.Add(currentFigure);
            }
        }

        public void OnPaint(AbstractFigure currentFigure, PaintEventArgs e)
        {
            if (currentFigure.startPoint.X != 0 && currentFigure.startPoint.Y != 0)
            {

                currentFigure.Draw();
            }
        }

        public IDTO OnToolStripMenuItemAddStringDataTable_Click(StringDataForm stringDataForm)
        {
            throw new Exception("Чот не туда зашло");
        }

        private void CheckStartPointLocation(AbstractTable item, AbstractFigure currentFigure, MouseEventArgs e)
        {
            if (e.Location.X > item.startPoint.X + 30
                                            && (Math.Abs(e.Location.Y - item.startPoint.Y) < 30))
            {
                currentFigure.startPoint = new Point(item.startPoint.X + item.width / 2,
                    item.startPoint.Y);
            }
            else if ((Math.Abs(e.Location.X - item.startPoint.X) < 30)
                && e.Location.Y > item.startPoint.Y)
            {
                currentFigure.startPoint = new Point(item.startPoint.X,
                    item.startPoint.Y + item.height / 2);
            }
            else if (e.Location.X < item.startPoint.X + item.width + 30
                && (e.Location.Y < item.startPoint.Y + item.height / 2 + 30))
            {
                currentFigure.startPoint = new Point(item.startPoint.X + item.width,
                    item.startPoint.Y + item.height / 2);
            }
            else
            {
                currentFigure.startPoint = new Point(item.startPoint.X + item.width / 2,
                   item.startPoint.Y + item.height);
            }
        }
    }
}
