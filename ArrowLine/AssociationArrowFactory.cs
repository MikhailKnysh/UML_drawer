using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowLine.Arrow;

namespace ArrowLine
{
    public class AssociationArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AssociationArrow();
        }
    }
}
