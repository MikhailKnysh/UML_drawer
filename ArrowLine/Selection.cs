using System;
using System.Collections.Generic;
using System.Drawing;

namespace ArrowLine
{
    public class Selection : AbstractFigure, ISelection
    {
        public DataPictureBox singltone = DataPictureBox.GetInstance();

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public bool HitTest(Point pt)
        {
            foreach (AbstractFigure item in singltone.tables)
            {
                if (pt.X > item.startPoint.X && pt.X < item.startPoint.X + width
                    && pt.Y > item.startPoint.Y && pt.Y < item.startPoint.Y + height)
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
                if (r.Contains(new Rectangle(item.startPoint.X, item.startPoint.Y, width, height)))
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
                new Rectangle(objectRectangle.startPoint.X + width, objectRectangle.startPoint.Y - 8, 8, 8),
                new Rectangle(objectRectangle.startPoint.X - 8, objectRectangle.startPoint.Y + objectRectangle.height, 8, 8),
                new Rectangle(objectRectangle.startPoint.X + width, objectRectangle.startPoint.Y + objectRectangle.height, 8, 8)

            };
        }

        public void DrawOverlay(Brush brushes, AbstractFigure objectRectangle)
        {

            foreach (Rectangle rectangle in RectanglesPoint(objectRectangle))
            {
                singltone.Graphics.FillRectangle(brushes, rectangle);

            }


            //singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left + objectRectangle.Width / 2 - 4, objectRectangle.Top - 8, 8, 8));
            //singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left - 8, objectRectangle.Top + objectRectangle.Height / 2 - 4, 8, 8));
            //singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left + objectRectangle.Width / 2 - 4, objectRectangle.Bottom, 8, 8));
            //singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Right, objectRectangle.Top + objectRectangle.Height / 2 - 4, 8, 8));

            // singltone.graphics.DrawRectangle(Pens.CadetBlue, objectRectangle);

        }
    }
}
