using System;
using System.Collections.Generic;
using System.Drawing;

namespace ArrowLine
{
    public class Selection : ISelection
    {
        public DataPictureBox singltone = DataPictureBox.GetInstance();

   
        public bool HitTest(Point pt)
        {
            foreach (AbstractFigure item in singltone.tables)
            {
                if (pt.X > item.startPoint.X && pt.X < item.startPoint.X + item.width
                    && pt.Y > item.startPoint.Y && pt.Y < item.startPoint.Y + item.height && (item is AbstractTable))
                {
                    item.Selected = true;
                    return true;
                }
            }
            return false;
        }

        public bool HitTest(Rectangle r)
        {
            foreach (AbstractFigure item in singltone.tables)
            {
                if (r.Contains(new Rectangle(item.startPoint.X, item.startPoint.Y, item.width, item.height)) && (item is AbstractTable))
                {
                    item.Selected = true;
                    
                }
            }
            foreach (AbstractFigure item in singltone.tables)
            {
                if (item.Selected==true)
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

        public void DrawOverlay(Brush brushes, AbstractFigure objectRectangle)
        {

            foreach (Rectangle rectangle in RectanglesPoint(objectRectangle))
            {
                singltone.Graphics.FillRectangle(brushes, rectangle);

            }
        }
    }
}
