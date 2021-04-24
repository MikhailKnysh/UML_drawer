using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ArrowLine.Table.StringData;

namespace ArrowLine
{
    public class DrawMouseHandler : IMouseHandler
    {
        public bool isArrow;

        public DataPictureBox singltone = DataPictureBox.GetInstance();
        private IDTO _idto;

        public void OnMouseDown(AbstractFigure currentFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        if (currentFigure.Type == FigureType.Arrow)
                        {
                            foreach (var item in singltone.tables)
                            {
                                if (item.Type == FigureType.Table)
                                {
                                    var rectangle = item as AbstractTable;
                                    if (rectangle.Contain(e.Location))
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
                                        return;
                                    }

                                }
                            }
                        }
                        else
                        {
                            currentFigure.startPoint = e.Location;
                            currentFigure.endPoint = e.Location;
                        }
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
            if (e.Button == MouseButtons.Left)
            {
                if (currentFigure.Type == FigureType.Arrow)
                {
                    foreach (var item in singltone.tables)
                    {
                        if (item.Type == FigureType.Table)
                        {
                            var rectangle = item as AbstractTable;
                            if (rectangle.Contain(e.Location))
                            {
                                if (e.Location.X > item.startPoint.X + 30
                                    && (Math.Abs(e.Location.Y - item.startPoint.Y) < 30))
                                {
                                    currentFigure.endPoint = new Point(item.startPoint.X + item.width / 2,
                                        item.startPoint.Y);
                                }
                                else if ((Math.Abs(e.Location.X - item.startPoint.X) < 30)
                                    && e.Location.Y > item.startPoint.Y)
                                {
                                    currentFigure.endPoint = new Point(item.startPoint.X,
                                        item.startPoint.Y + item.height / 2);
                                }
                                else if (e.Location.X < item.startPoint.X + item.width + 30
                                    && (e.Location.Y < item.startPoint.Y + item.height / 2 + 30))
                                {
                                    currentFigure.endPoint = new Point(item.startPoint.X + item.width,
                                        item.startPoint.Y + item.height / 2);
                                }
                                else
                                {
                                    currentFigure.endPoint = new Point(item.startPoint.X + item.width / 2,
                                       item.startPoint.Y + item.height);
                                }
                            }
                        }
                    }
                }
                else
                {
                    currentFigure.endPoint = e.Location;
                }
            }
        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            if (currentFigure != null && e.Button == MouseButtons.Left && currentFigure.startPoint.X != 0 && currentFigure.startPoint.Y != 0)
            {
                singltone.tables.Add(currentFigure);
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
            stringDataForm.ShowDialog();
            _idto = stringDataForm.Create();
            return _idto;
        }
    }
}
