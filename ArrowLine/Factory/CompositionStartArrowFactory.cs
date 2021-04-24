using ArrowLine.Arrow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    public class CompositionStartArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new CompositionStartArrow(FigureType.Arrow);
        }
    }
}
