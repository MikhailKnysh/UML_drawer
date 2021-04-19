using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    public class Selection : AbstractFigure, ISelection
    {
        public DataPictureBox singltone = DataPictureBox.GetInstance();
        AbstractFigure objectRectangle;
        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public bool HitTest(Point pt)
        {
            foreach(AbstractFigure item in singltone.tables)
            {
                if(pt.X > item.startPoint.X && pt.X < item.startPoint.X + 140 
                    && pt.Y > item.startPoint.Y && pt.Y < item.startPoint.Y + 60)
                {
                    objectRectangle = item;
                    return true;
                }
            }
            return false;
        }

        public bool HitTest(Rectangle r)
        {
            throw new NotImplementedException();
        }
        public void DrawOverlay()
        {

            //if (selected)
            //{
                singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.startPoint.X - 8, objectRectangle.startPoint.Y - 8, 8, 8));
                singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.startPoint.X + 140, objectRectangle.startPoint.Y - 8, 8, 8));
                singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.startPoint.X - 8, objectRectangle.startPoint.Y + 60, 8, 8));
                singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.startPoint.X + 140, objectRectangle.startPoint.Y + 60, 8, 8));


                //singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left + objectRectangle.Width / 2 - 4, objectRectangle.Top - 8, 8, 8));
                //singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left - 8, objectRectangle.Top + objectRectangle.Height / 2 - 4, 8, 8));
                //singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left + objectRectangle.Width / 2 - 4, objectRectangle.Bottom, 8, 8));
                //singltone.graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Right, objectRectangle.Top + objectRectangle.Height / 2 - 4, 8, 8));

               // singltone.graphics.DrawRectangle(Pens.CadetBlue, objectRectangle);
           // }
        }
    }
}
