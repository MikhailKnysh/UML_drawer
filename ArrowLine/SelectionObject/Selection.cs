using ArrowLine.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ArrowLine.SelectionObject
{
    public class Selection : ISelection
    {
        public bool StartPoint { get; set; }
        public bool EndPoint { get; set; }

        public bool HitTest(Point point)
        {
            foreach (AbstractFigure item in CollectionFigure.tables)
            {
                if (item.Type == FigureType.Table)
                {
                    var tableRectangle = item as AbstractTable;
                    if (point.X > tableRectangle.startPoint.X && point.X < tableRectangle.startPoint.X + tableRectangle.width
                        && point.Y > tableRectangle.startPoint.Y && point.Y < tableRectangle.startPoint.Y + tableRectangle.height)
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
                        return true;
                    }
                    if (new Rectangle(item.endPoint.X - 5, item.endPoint.Y - 5, 10, 10).Contains(point))
                    {
                        EndPoint = true;
                        item.Selected = true;
                        return true;
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
                    var tableRectangle = item as AbstractTable;
                    if (rectangle.Contains(new Rectangle(tableRectangle.startPoint.X, tableRectangle.startPoint.Y, tableRectangle.width, tableRectangle.height)))
                    {
                        item.Selected = true;

                    }
                }

                if (item.Type == FigureType.Arrow)
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
            var rectangle = objectRectangle as AbstractTable;
            return new List<Rectangle>()
            {
                new Rectangle(rectangle.startPoint.X - 6, rectangle.startPoint.Y - 6, 6, 6),
                new Rectangle(rectangle.startPoint.X + rectangle.width, rectangle.startPoint.Y - 6, 6, 6),
                new Rectangle(rectangle.startPoint.X - 6, rectangle.startPoint.Y + rectangle.height, 6, 6),
                new Rectangle(rectangle.startPoint.X + rectangle.width, rectangle.startPoint.Y + rectangle.height, 6, 6),

                new Rectangle(rectangle.startPoint.X + rectangle.width/2 - 3, rectangle.startPoint.Y - 7, 6, 6),
                new Rectangle(rectangle.startPoint.X - 7, rectangle.startPoint.Y + rectangle.height/2 - 3, 6, 6),
                new Rectangle(rectangle.startPoint.X + rectangle.width/2 - 3,rectangle.startPoint.Y + rectangle.height + 1, 6, 6 ),
                new Rectangle(rectangle.startPoint.X + rectangle.width + 1,rectangle.startPoint.Y + rectangle.height/2 - 3, 6, 6)

            };
        }

        public void DrawOverlay(Point point)
        {
            GraficPictureBox.Graphics.FillRectangle(Brushes.Transparent, new Rectangle(point.X - 5, point.Y - 5, 10, 10));
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

