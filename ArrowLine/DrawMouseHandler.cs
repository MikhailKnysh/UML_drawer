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
                                        currentFigure.startPoint = item.startPoint;
                                    }
                                }
                                else
                                {
                                    
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
                currentFigure.endPoint = e.Location;
            }

        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            if (currentFigure != null && e.Button == MouseButtons.Left)
            {
                singltone.tables.Add(currentFigure);
            }
        }

        public void OnPaint(AbstractFigure currentFigure, PaintEventArgs e)
        {
            if(currentFigure.startPoint.X != 0 && currentFigure.startPoint.Y != 0)
                currentFigure.Draw();

            
        }

        public IDTO OnToolStripMenuItemAddField_Click(StringDataForm stringDataForm)
        {
            stringDataForm.ShowDialog();
            _idto = stringDataForm.Create();
            return _idto;
        }


        //public bool DrawArrow(Point pt)
        //{
        //    foreach (var item in singltone.tables)
        //    {
        //        if (item is AbstractTable)
        //        {
        //            var rectangle = item as AbstractTable;
        //            if (rectangle.Contain(pt))
        //            {
        //                return true;
        //            }

        //        }
        //    }
        //    return false;
        //}



    }
}
