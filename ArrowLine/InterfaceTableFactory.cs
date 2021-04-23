using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArrowLine.Table;
using System.Threading.Tasks;

namespace ArrowLine
{
    public class InterfaceTableFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new InterfaceTable(FigureType.Table);
        }
    }
}
