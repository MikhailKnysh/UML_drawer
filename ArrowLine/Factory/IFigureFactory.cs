using ArrowLine.Abstract;

namespace ArrowLine.Factory
﻿using System.Drawing;
{
    public interface IFigureFactory
    {
        AbstractFigure CreateFigure();
    }
}
