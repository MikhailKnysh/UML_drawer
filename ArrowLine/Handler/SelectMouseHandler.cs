using ArrowLine.Abstract;
using ArrowLine.Handler;
using ArrowLine.SelectionObject;
using ArrowLine.Table.StringData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowLine
{
    public class SelectMouseHandler : IMouseHandler
    {
        DataPictureBox singltone = DataPictureBox.GetInstance();
        Point startPoint;
        Point endPoint;
        Point tmpPoint;
        List<AbstractFigure> selectionObject;
        ISelection selection = new Selection();
        private Brush _highlightBrush;
        private Pen _highlightPen;

        public SelectMouseHandler()
        {
            _highlightBrush = new SolidBrush(Color.FromArgb(50, Color.Aquamarine));
            _highlightPen = new Pen(Color.Navy);
            _highlightPen.DashStyle = DashStyle.Dash;
        }

        public void OnMouseDown(AbstractFigure currentFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {
            startPoint = e.Location;
            endPoint = startPoint;
            tmpPoint = e.Location;
        }

        public void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e)
        {
            if (singltone.isMoving)
            {
                endPoint = e.Location;

                if (selectionObject != null && selection.HitTest(e.Location) == true)
                {
                    foreach (AbstractFigure item in selectionObject)
                    {
                        item.Move(e.X - tmpPoint.X, e.Y - tmpPoint.Y);

                        if (item.Type == FigureType.Table)
                        {
                            (item as AbstractTable).ReDrawRectangleBody();
                        }

                        item.Draw();
                    }
                }

                tmpPoint = e.Location;
            }
        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            if (selectionObject != null)
            {
                singltone.RebaseBitmap();

                foreach (var item in CollectionFigure.tables)
                {
                    if (item.Type == FigureType.Table)
                    {
                        (item as AbstractTable).ReDrawRectangleBody();
                    }

                    item.Draw();
                }
            }

            if (currentFigure.Selected == false || selection.HitTest(e.Location) == false)
            {
                DrawSelection(Brushes.White, selectionObject);
                selectionObject = null;

                foreach (var item in CollectionFigure.tables)
                {
                    item.Selected = false;
                }
            }

            if (e.Button == MouseButtons.Left)
            {
                Rectangle r = new Rectangle(
                          Math.Min(startPoint.X, endPoint.X),
                          Math.Min(startPoint.Y, endPoint.Y),
                          Math.Abs(startPoint.X - endPoint.X),
                          Math.Abs(startPoint.Y - endPoint.Y));

                if (selection.HitTest(e.Location) || selection.HitTest(r) == true)
                {
                    selectionObject = CollectionFigure.tables.Where(item => item.Selected == true).ToList();
                }

                if (selectionObject != null)
                {
                    DrawSelection(Brushes.Black, selectionObject);
                }
            }
        }

        public void OnPaint(AbstractFigure currentFigure, PaintEventArgs e)
        {
            if (selectionObject == null)
            {
                Rectangle r = new Rectangle(
                 Math.Min(startPoint.X, endPoint.X),
                 Math.Min(startPoint.Y, endPoint.Y),
                 Math.Abs(startPoint.X - endPoint.X),
                 Math.Abs(startPoint.Y - endPoint.Y));

                e.Graphics.FillRectangle(_highlightBrush, r);
                e.Graphics.DrawRectangle(_highlightPen, r);
            }
        }

        public IDTO OnToolStripMenuItemAddStringDataTable_Click(StringDataForm stringDataForm)
        {
            throw new NotImplementedException();
        }

        private void DrawSelection(Brush brush, List<AbstractFigure> abstractFigures)
        {
            if (abstractFigures != null)
            {
                foreach (var abstractFigure in abstractFigures)
                {
                    if (abstractFigure.Type == FigureType.Arrow)
                    {
                        selection.DrawOverlay(abstractFigure.startPoint);
                    }
                    if (abstractFigure.Type == FigureType.Table)
                    {
                        selection.DrawOverlay(brush, abstractFigure);
                    }
                }
            }
        }
    }
}
