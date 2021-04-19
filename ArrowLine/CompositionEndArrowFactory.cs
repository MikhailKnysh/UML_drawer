using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrowLine.Arrow;


namespace ArrowLine
{
    public class CompositionEndArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new CompositionStartArrow();
        }
    }
}
