using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine
{
    public abstract class AbstractTable// : AbstractFigure
    {
        protected TextBox title;
        public Point startPoint;
        protected int widght = 140;
        protected int height = 180;
        protected int stepDown = 24;
        protected List<string> fields;
        protected List<string> properties;
        protected List<string> methods;
        protected List<LineInTable> linesInTable;

        protected abstract void AddField();
        protected abstract void AddMethod();
        public virtual void Draw(Pen pen, Graphics graphics)
        {
        }
        protected abstract void Resize();
        protected abstract void Move();
    }
}
