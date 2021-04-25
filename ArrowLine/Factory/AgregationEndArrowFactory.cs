using ArrowLine.Abstract;
using ArrowLine.Arrow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine.Factory
{
    public class AgregationEndArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AgregationEndArrow(FigureType.Arrow);
        }
    }
}
