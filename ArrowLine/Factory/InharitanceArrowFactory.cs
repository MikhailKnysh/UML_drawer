using ArrowLine.Arrow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    public class InharitanceArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new InheritanceArrow(FigureType.Arrow);
        }
    }
}
