using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ArrowLine.Arrow;
using ArrowLine.Abstract;

namespace ArrowLine.Factory
{
    public class AssociationArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AssociationArrow(FigureType.Arrow);
        }
    }
}
