using ArrowLine.Abstract;
using ArrowLine.Arrow;
using ArrowLine.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine.Factory
{
    public class CompositionStartArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new CompositionStartArrow(FigureType.Arrow);
        }
    }
}
