using ArrowLine.Arrow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    public class AgregationStartArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AgregationStartArrow();
        }
    }
}
