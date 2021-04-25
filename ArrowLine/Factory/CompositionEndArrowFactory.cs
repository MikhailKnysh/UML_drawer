using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowLine.Abstract;
using ArrowLine.Arrow;
using ArrowLine.Factory;

namespace ArrowLine.Factory
{
    public class CompositionEndArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new CompositionEndArrow(FigureType.Arrow);
        }
    }
}
