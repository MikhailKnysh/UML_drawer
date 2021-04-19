using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    interface ISelection
    {
        bool HitTest(Point pt);
        //{
        //    return objectRegion.IsVisible(pt);
        //}

    bool HitTest(Rectangle r);
        //{
        //    return objectRegion.IsVisible(r);
        //}
    }
}
