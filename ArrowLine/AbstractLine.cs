using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractLine : AbstractTools
    {
        protected abstract Point[] GetPoints();

        public abstract void DrawLine();
    }
}
