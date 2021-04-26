using ArrowLine.Abstract;
using System.Collections.Generic;
using System.Drawing;
using UMlDrawer.Abstract;

namespace ArrowLine.SelectionObject
{
    public class Selection : ISelection
    {
        public bool HitObjectArea(Point point)
        {
            foreach (AbstractFigure item in CollectionFigure.collectionFigures)
            {
                if (item.Type == FigureType.Table)
                {
                    var tableRectangle = item as AbstractTable;
                    if (point.X > tableRectangle.StartPoint.X && point.X < tableRectangle.StartPoint.X + tableRectangle.width
                        && point.Y > tableRectangle.StartPoint.Y && point.Y < tableRectangle.StartPoint.Y + tableRectangle.height)
                    {
                        item.Selected = true;
                        return true;
                    }
                }

                if (item.Type == FigureType.Arrow)
                {
                    if (new Rectangle(item.StartPoint.X - 7, item.StartPoint.Y - 7, 15, 15).Contains(point)
                        || new Rectangle(item.EndPoint.X - 7, item.EndPoint.Y - 7, 15, 15).Contains(point))
                    {
                        item.Selected = true;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool HitObjectArea(Rectangle rectangle)
        {
            foreach (AbstractFigure item in CollectionFigure.collectionFigures)
            {
                if (item.Type == FigureType.Table)
                {
                    var tableRectangle = item as AbstractTable;
                    if (rectangle.Contains(new Rectangle(tableRectangle.StartPoint.X, tableRectangle.StartPoint.Y, tableRectangle.width, tableRectangle.height)))
                    {
                        item.Selected = true;
                    }
                }

                if (item.Type == FigureType.Arrow)
                {
                    if (rectangle.Contains(item.StartPoint)
                        || rectangle.Contains(item.EndPoint))
                    {
                        item.Selected = true;
                    }
                }
            }

            foreach (AbstractFigure item in CollectionFigure.collectionFigures)
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
                new Rectangle(rectangle.StartPoint.X - 6, rectangle.StartPoint.Y - 6, 6, 6),
                new Rectangle(rectangle.StartPoint.X + rectangle.width, rectangle.StartPoint.Y - 6, 6, 6),
                new Rectangle(rectangle.StartPoint.X - 6, rectangle.StartPoint.Y + rectangle.height, 6, 6),
                new Rectangle(rectangle.StartPoint.X + rectangle.width, rectangle.StartPoint.Y + rectangle.height, 6, 6),

                new Rectangle(rectangle.StartPoint.X + rectangle.width/2 - 3, rectangle.StartPoint.Y - 7, 6, 6),
                new Rectangle(rectangle.StartPoint.X - 7, rectangle.StartPoint.Y + rectangle.height/2 - 3, 6, 6),
                new Rectangle(rectangle.StartPoint.X + rectangle.width/2 - 3,rectangle.StartPoint.Y + rectangle.height + 1, 6, 6 ),
                new Rectangle(rectangle.StartPoint.X + rectangle.width + 1,rectangle.StartPoint.Y + rectangle.height/2 - 3, 6, 6)
            };
        }

        public void DrawOverlay(Point point)
        {
            GraphicsPictureBox.Graphics.FillRectangle(Brushes.Transparent, new Rectangle(point.X - 15, point.Y - 15, 15, 15));
        }

        public void DrawOverlay(Brush brushes, AbstractFigure objectRectangle)
        {
            foreach (Rectangle rectangle in RectanglesPoint(objectRectangle))
            {
                GraphicsPictureBox.Graphics.FillRectangle(brushes, rectangle);
            }
        }
    }
}

