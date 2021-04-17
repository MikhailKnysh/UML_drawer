using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    public interface IMouseHandler
    {
        void OnMouseDown();

        void OnMouseUp();

        void OnMouseMove();
        void OnPaint();


    }
}
