using UMLDrawer.Abstract;
using UMLDrawer.Handler;
using UMLDrawer.SelectionObject;
using UMLDrawer.Table.StringData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using UMlDrawer.Abstract;

namespace UMLDrawer
{
    public class SelectAndMoveMouseHandler : IMouseHandler
    {
        DataPictureBox dataPictureBox = DataPictureBox.GetInstance();
        Point startPoint;
        Point endPoint;
        Point tmpPoint;
        List<AbstractFigure> selectedObjects;
        ISelection selection = new Selection();
        private Brush _highlightBrush;
        private Pen _highlightPen;

        public SelectAndMoveMouseHandler()
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
            if (dataPictureBox.isMoving)
            {
                endPoint = e.Location;

                if (selectedObjects != null && selection.HitObjectArea(e.Location) == true)
                {
                    foreach (AbstractFigure item in selectedObjects)
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
            if (selectedObjects != null)
            {
                dataPictureBox.RebaseBitmap();

                foreach (var item in CollectionFigure.collectionFigures)
                {
                    if (item.Type == FigureType.Table)
                    {
                        (item as AbstractTable).ReDrawRectangleBody();
                    }

                    item.Draw();
                }
            }

            if (currentFigure.Selected == false || selection.HitObjectArea(e.Location) == false)
            {
                DrawSelection(Brushes.White, selectedObjects);

                selectedObjects = null;

                foreach (var item in CollectionFigure.collectionFigures)
                {
                    item.Selected = false;
                }
            }

            if (e.Button == MouseButtons.Left)
            {
                Rectangle rectangle = new Rectangle(
                          Math.Min(startPoint.X, endPoint.X),
                          Math.Min(startPoint.Y, endPoint.Y),
                          Math.Abs(startPoint.X - endPoint.X),
                          Math.Abs(startPoint.Y - endPoint.Y));

                if (selection.HitObjectArea(e.Location) || selection.HitObjectArea(rectangle) == true)
                {
                    selectedObjects = CollectionFigure.collectionFigures.Where(item => item.Selected == true).ToList();
                }

                if (selectedObjects != null)
                {
                    DrawSelection(Brushes.Black, selectedObjects);
                }
            }
        }

        public void OnPaint(AbstractFigure currentFigure, PaintEventArgs e)
        {
            if (selectedObjects == null)
            {
                Rectangle rectangle = new Rectangle(
                 Math.Min(startPoint.X, endPoint.X),
                 Math.Min(startPoint.Y, endPoint.Y),
                 Math.Abs(startPoint.X - endPoint.X),
                 Math.Abs(startPoint.Y - endPoint.Y));

                e.Graphics.FillRectangle(_highlightBrush, rectangle);
                e.Graphics.DrawRectangle(_highlightPen, rectangle);
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
                        selection.DrawOverlay(abstractFigure.StartPoint);
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
