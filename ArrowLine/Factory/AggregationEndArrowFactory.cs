using ArrowLine.Abstract;
using ArrowLine.Arrow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine.Factory
{
    public class AggregationEndArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AggregationEndArrow(FigureType.Arrow);
        }
    }
}
