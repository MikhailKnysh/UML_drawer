using System.Drawing;


namespace ArrowLine
{
    public abstract class AbstractRectangle : AbstractArrow
    {
        public bool selected;
        public Region objectRegion;
        public Rectangle objectRectangle;
        public Brush fillBrush;

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        public virtual Rectangle ObjectRectangle
        {
            get { return objectRectangle; }
            set { objectRectangle = value; }
        }
        public Brush FillBrush
        {
            get { return fillBrush; }
            set { fillBrush = value; }
        }

        public AbstractRectangle(Pen pen, Graphics graphics)
        {
            selected = false;
            objectRectangle = new Rectangle();
            objectRegion = new Region();
            fillBrush = new SolidBrush(pen.Color);
        }

        public override void Draw(Pen pen, Graphics graphics)
        {

        }

        public virtual void DrawOverlay(Graphics graphics)
        {
            if (selected)
            {
                graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left - 8, objectRectangle.Top - 8, 8, 8));
                graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Right, objectRectangle.Top - 8, 8, 8));
                graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left - 8, objectRectangle.Bottom, 8, 8));
                graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Right, objectRectangle.Bottom, 8, 8));

                graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left + objectRectangle.Width / 2 - 4, objectRectangle.Top - 8, 8, 8));
                graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left - 8, objectRectangle.Top + objectRectangle.Height / 2 - 4, 8, 8));
                graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Left + objectRectangle.Width / 2 - 4, objectRectangle.Bottom, 8, 8));
                graphics.FillRectangle(Brushes.Black, new Rectangle(objectRectangle.Right, objectRectangle.Top + objectRectangle.Height / 2 - 4, 8, 8));

                graphics.DrawRectangle(Pens.CadetBlue, objectRectangle);
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
