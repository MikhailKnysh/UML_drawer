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


        public void OnMouseDown(AbstractFigure abstractFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        startPoint = e.Location;
                        endPoint = startPoint;

                        if (selectionObject != null)
                        {
                            DrawSelection(Brushes.White, selectionObject);
                            selectionObject = null;

                            foreach (var item in singltone.tables)
                            {
                                item.Selected = false;
                            }
                        }

                        if (selection.HitTest(e.Location))
                        {
                            selectionObject = singltone.tables.Where(item => item.Selected == true).ToList();
                        }
                    }
                    break;

                case MouseButtons.Right:
                    {
                        tmpPoint = e.Location;
                        break;
                    }
            }
        }


        public void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                endPoint = e.Location;

                switch (e.Button)
                {
                    case MouseButtons.Right:

                        if (selectionObject != null)
                        {
                            foreach (AbstractFigure item in selectionObject)
                            {
                                item.Move(e.X - tmpPoint.X, e.Y - tmpPoint.Y);
                                item.ReDrawRectangleBody();
                                item.Draw();
                            }
                        }

                        tmpPoint = e.Location;

                        foreach (var item in singltone.tables)
                        {
                            item.Selected = false;
                        }
                        break;
                }
            }
        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:

                    Rectangle r = new Rectangle(
                          Math.Min(startPoint.X, endPoint.X),
                          Math.Min(startPoint.Y, endPoint.Y),
                          Math.Abs(startPoint.X - endPoint.X),
                          Math.Abs(startPoint.Y - endPoint.Y));


                    if (selection.HitTest(r) == true)
                    {
                        selectionObject = singltone.tables.Where(item => item.Selected == true).ToList();
                    }

                    if (selectionObject != null)
                    {
                        DrawSelection(Brushes.Black, selectionObject);
                    }
                    break;

                case MouseButtons.Right:
                    if (selectionObject != null)
                    {
                        singltone.RebaseBitmap();

                        foreach (var item in singltone.tables)
                        {
                            item.ReDrawRectangleBody();
                            item.Draw();
                        }
                    }
                    break;
            }
        }

        public void OnPaint(AbstractFigure currentFigure, PaintEventArgs e)
        {
                Rectangle r = new Rectangle(
                  Math.Min(startPoint.X, endPoint.X),
                  Math.Min(startPoint.Y, endPoint.Y),
                  Math.Abs(startPoint.X - endPoint.X),
                  Math.Abs(startPoint.Y - endPoint.Y));

                e.Graphics.FillRectangle(_highlightBrush, r);
                e.Graphics.DrawRectangle(_highlightPen, r);

        }

        public IDTO OnToolStripMenuItemAddField_Click(StringDataForm stringDataForm)
        {
            throw new NotImplementedException();
        }

        private void DrawSelection(Brush brush, List<AbstractFigure> abstractFigures)
        {
            foreach (var abstractFigure in abstractFigures)
            {
                selection.DrawOverlay(brush, abstractFigure);
            }
        }
    }
}
