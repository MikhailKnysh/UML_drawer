using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine
{
    public abstract class AbstractTable : Panel
    {
        protected TextBox title;
        public Point startPoint;
        protected int widght = 120;
        protected int height = 160;
        protected int stepDown = 24;
        protected List<TextBox> fields;
        protected List<TextBox> methods;
        protected List<LineInTable> linesInTable;

        protected abstract void AddField();
        protected abstract void AddMethod();
        public abstract void Draw(Pen pen, Graphics graphics);
        protected abstract void Resize();
        protected abstract void Move();
    }
}
