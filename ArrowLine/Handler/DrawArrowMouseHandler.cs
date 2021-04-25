using ArrowLine.Abstract;
using ArrowLine.Table.StringData;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine.Handler
{
    public class DrawArrowMouseHandler : IMouseHandler
    {
        public void OnMouseDown(AbstractFigure currentFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {

            foreach (var item in CollectionFigure.collectionFigures)
            {
                if (item.Type == FigureType.Table)
                {
                    var rectangle = item as AbstractTable;

                    if (rectangle.Contains(e.Location))
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
                currentFigure.EndPoint = e.Location;
            }
        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            if (currentFigure != null && e.Button == MouseButtons.Left && currentFigure.StartPoint.X != 0 && currentFigure.StartPoint.Y != 0)
            {
                CollectionFigure.collectionFigures.Add(currentFigure);
            }
        }

        public void OnPaint(AbstractFigure currentFigure, PaintEventArgs e)
        {
            if (currentFigure.StartPoint.X != 0 && currentFigure.StartPoint.Y != 0)
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
            if (e.Location.X > item.StartPoint.X + 30
               && (Math.Abs(e.Location.Y - item.StartPoint.Y) < 30))
            {
                currentFigure.StartPoint = new Point(item.StartPoint.X + item.width / 2,
                    item.StartPoint.Y-10);
            }
            else if ((Math.Abs(e.Location.X - item.StartPoint.X) < 30)
                && e.Location.Y > item.StartPoint.Y)
            {
                currentFigure.StartPoint = new Point(item.StartPoint.X-10,
                    item.StartPoint.Y + item.height / 2);
            }
            else if (e.Location.X < item.StartPoint.X + item.width + 30
                && (e.Location.Y < item.StartPoint.Y + item.height / 2 + 30))
            {
                currentFigure.StartPoint = new Point(item.StartPoint.X + 10 + item.width,
                    item.StartPoint.Y + item.height / 2);
            }
            else
            {
                currentFigure.StartPoint = new Point(item.StartPoint.X + item.width / 2,
                   item.StartPoint.Y + item.height + 10);
            }

            currentFigure.EndPoint = e.Location;
        }
    }
}
