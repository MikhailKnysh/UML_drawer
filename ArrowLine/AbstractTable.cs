using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine
{
    public abstract class AbstractTable : AbstractFigure
    {
        protected TextBox title;
        protected int widght = 140;
        protected int height = 180;
        protected int stepDown = 24;
        protected bool selected;
        public Rectangle objectRectangle;
        protected List<string> fields;
        protected List<string> properties;
        protected List<string> methods;
        protected List<LineInTable> linesInTable;
        public List<Rectangle> rectangles = new List<Rectangle>();



        public AbstractTable()
        {
            objectRectangle = new Rectangle();
            objectRegion = new Region();
        }
        public virtual Rectangle ObjectRectangle
        {
            get { return objectRectangle; }
            set { objectRectangle = value; }
        }
        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        protected abstract void AddField();
        protected abstract void AddMethod();

        protected abstract void Resize();
        protected abstract void Move();

        public virtual void DrawOverlay(Graphics g)
        {
            if (selected)
            {
                g.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left - 8, objectRectangle.Top - 8, 8, 8));
                g.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Right, objectRectangle.Top - 8, 8, 8));
                g.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left - 8, objectRectangle.Bottom, 8, 8));
                g.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Right, objectRectangle.Bottom, 8, 8));

                g.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left + objectRectangle.Width / 2 - 4, objectRectangle.Top - 8, 8, 8));
                g.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left - 8, objectRectangle.Top + objectRectangle.Height / 2 - 4, 8, 8));
                g.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left + objectRectangle.Width / 2 - 4, objectRectangle.Bottom, 8, 8));
                g.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Right, objectRectangle.Top + objectRectangle.Height / 2 - 4, 8, 8));

                g.DrawRectangle(Pens.CadetBlue, objectRectangle);
            }
        }
        public virtual bool HitTest(Point pt)
        {
            return objectRegion.IsVisible(pt);
        }

        public virtual bool HitTest(Rectangle r)
        {
            return objectRegion.IsVisible(r);
        }
    }
}
