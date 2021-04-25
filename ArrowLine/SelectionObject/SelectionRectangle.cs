using ArrowLine.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ArrowLine
{
    public class SelectionRectangle : ISelection
    {
        public DataPictureBox singltone = DataPictureBox.GetInstance();
        public bool StartPoint { get; set; }
        public bool EndPoint { get; set; }

        public bool HitTest(Point point)
        {
            foreach (AbstractFigure item in CollectionFigure.tables)
            {
                if (item.Type == FigureType.Table)
                {
                    var itemRec = item as AbstractTable;
                    if (point.X > itemRec.startPoint.X && point.X < itemRec.startPoint.X + itemRec.width
                        && point.Y > itemRec.startPoint.Y && point.Y < itemRec.startPoint.Y + itemRec.height)
                    {
                        item.Selected = true;
                        return true;
                    }
                }

                if (item.Type == FigureType.Arrow)
                {
                    if (new Rectangle(item.startPoint.X - 5, item.startPoint.Y - 5, 10, 10).Contains(point))
                    {
                        StartPoint = true;
                        item.Selected = true;
                       
                    }
                    if (new Rectangle(item.endPoint.X - 5, item.endPoint.Y - 5, 10, 10).Contains(point))
                    {
                        EndPoint = true;
                        item.Selected = true;
                       
                    }
                }
            }
            return false;
        }

        public bool HitTest(Rectangle rectangle)
        {

            foreach (AbstractFigure item in CollectionFigure.tables)
            {
                if (item.Type == FigureType.Table)
                {
                    var itemRec = item as AbstractTable;
                    if (rectangle.Contains(new Rectangle(itemRec.startPoint.X, itemRec.startPoint.Y, itemRec.width, itemRec.height)))
                    {
                        item.Selected = true;

                    }
                }

                if(item.Type == FigureType.Arrow)
                {
                    foreach (AbstractFigure abstractFigure in CollectionFigure.tables)
                    {

                        if (rectangle.Contains(abstractFigure.startPoint))
                        {
                            StartPoint = true;
                            item.Selected = true;
                           
                        }

                        if (rectangle.Contains(abstractFigure.endPoint))
                        {
                            EndPoint = true;
                            item.Selected = true;
                           
                        }
                    }
                }
            }

            foreach (AbstractFigure item in CollectionFigure.tables)
            {
                if (item.Selected == true)
                {
                    return true;
                }

            }

            return false;
        }

        public List<Rectangle> RectanglesPoint(AbstractFigure objectRectangle)
        {
            var objRec = objectRectangle as AbstractTable;
            return new List<Rectangle>()
            {
                new Rectangle(objRec.startPoint.X - 8, objRec.startPoint.Y - 8, 8, 8),
                new Rectangle(objRec.startPoint.X + objRec.width, objRec.startPoint.Y - 8, 8, 8),
                new Rectangle(objRec.startPoint.X - 8, objRec.startPoint.Y + objRec.height, 8, 8),
                new Rectangle(objRec.startPoint.X + objRec.width, objRec.startPoint.Y + objRec.height, 8, 8),

                new Rectangle(objRec.startPoint.X + objRec.width/2 - 4, objRec.startPoint.Y - 9, 8, 8),
                new Rectangle(objRec.startPoint.X - 9, objRec.startPoint.Y + objRec.height/2 - 4, 8, 8),
                new Rectangle(objRec.startPoint.X + objRec.width/2 - 4, objRec.startPoint.Y + objRec.height + 1, 8, 8 ),
                new Rectangle(objRec.startPoint.X + objRec.width + 1, objRec.startPoint.Y + objRec.height/2 - 4, 8, 8)

            };
        }

        public void DrawOverlay(Brush brushes, Point point)
        {
            GraficPictureBox.Graphics.FillRectangle(brushes, new Rectangle(point.X - 5, point.Y - 5, 10, 10));
        }

        public void DrawOverlay(Brush brushes, AbstractFigure objectRectangle)
        {

            foreach (Rectangle rectangle in RectanglesPoint(objectRectangle))
            {
                GraficPictureBox.Graphics.FillRectangle(brushes, rectangle);

            }
        }
    }
}
