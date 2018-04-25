using System;
using FigureDrawer.BusinessLogic2.Contracts;

namespace FigureDrawer.BusinessLogic2
{
    public interface IDrawableFigure: IFigure
    {
        ConsoleColor Color { get; set; }

        int CoordinateX { get; set; }
        int CoordinateY { get; set; }
    }
}