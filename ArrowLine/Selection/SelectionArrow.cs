using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine.Selection
{
    class SelectionArrow : ISelection
    {
        public DataPictureBox singltone = DataPictureBox.GetInstance();
        public void DrawOverlay(Brush brushes, AbstractFigure objectRectangle)
        {
                singltone.Graphics.FillRectangle(brushes, new Rectangle());
        }

        public bool HitTest(Point point)
        {
            foreach(AbstractFigure abstractFigure in singltone.tables)
            {
                if(new Rectangle(abstractFigure.startPoint.X-5, abstractFigure.startPoint.Y - 5, 10, 10).Contains(point))
                {
                    return true;
                }
                if (new Rectangle(abstractFigure.endPoint.X - 5, abstractFigure.endPoint.Y - 5, 10, 10).Contains(point))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HitTest(Rectangle rectangle)
        {
            foreach (AbstractFigure abstractFigure in singltone.tables)
            {
                if(rectangle.Contains(abstractFigure.startPoint) || rectangle.Contains(abstractFigure.endPoint))
                {
                    return true;
                }
            }
                return false;
        }
    }
}
