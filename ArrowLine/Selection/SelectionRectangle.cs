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
            foreach (AbstractFigure item in singltone.tables)
            {
                if (item.Type == FigureType.Table)
                {
                    if (point.X > item.startPoint.X && point.X < item.startPoint.X + item.width
                        && point.Y > item.startPoint.Y && point.Y < item.startPoint.Y + item.height && (item is AbstractTable))
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

            foreach (AbstractFigure item in singltone.tables)
            {
                if (item.Type == FigureType.Table)
                {
                    if (rectangle.Contains(new Rectangle(item.startPoint.X, item.startPoint.Y, item.width, item.height)) && (item is AbstractTable))
                    {
                        item.Selected = true;

                    }
                }

                if(item.Type == FigureType.Arrow)
                {
                    foreach (AbstractFigure abstractFigure in singltone.tables)
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

            foreach (AbstractFigure item in singltone.tables)
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
            return new List<Rectangle>()
            {
                new Rectangle(objectRectangle.startPoint.X - 8, objectRectangle.startPoint.Y - 8, 8, 8),
                new Rectangle(objectRectangle.startPoint.X + objectRectangle.width, objectRectangle.startPoint.Y - 8, 8, 8),
                new Rectangle(objectRectangle.startPoint.X - 8, objectRectangle.startPoint.Y + objectRectangle.height, 8, 8),
                new Rectangle(objectRectangle.startPoint.X + objectRectangle.width, objectRectangle.startPoint.Y + objectRectangle.height, 8, 8),

                new Rectangle(objectRectangle.startPoint.X + objectRectangle.width/2 - 4, objectRectangle.startPoint.Y - 9, 8, 8),
                new Rectangle(objectRectangle.startPoint.X - 9, objectRectangle.startPoint.Y + objectRectangle.height/2 - 4, 8, 8),
                new Rectangle(objectRectangle.startPoint.X + objectRectangle.width/2 - 4, objectRectangle.startPoint.Y + objectRectangle.height + 1, 8, 8 ),
                new Rectangle(objectRectangle.startPoint.X + objectRectangle.width + 1, objectRectangle.startPoint.Y + objectRectangle.height/2 - 4, 8, 8)

            };
        }

        public void DrawOverlay(Brush brushes, Point point)
        {
            singltone.Graphics.FillRectangle(brushes, new Rectangle(point.X - 5, point.Y - 5, 10, 10));
        }

        public void DrawOverlay(Brush brushes, AbstractFigure objectRectangle)
        {

            foreach (Rectangle rectangle in RectanglesPoint(objectRectangle))
            {
                singltone.Graphics.FillRectangle(brushes, rectangle);

            }
        }
    }
}
