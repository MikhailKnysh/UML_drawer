using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowLine.Abstract;
using ArrowLine.Arrow;


namespace ArrowLine.Factory
{
    public class ImplementationArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new ImplementationArrow(FigureType.Arrow);
        }
    }
}
