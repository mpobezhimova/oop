using System;

namespace FigureDrawer.BusinessLogic
{
    public interface IDrawableFigure 
    {
        ConsoleColor Color { get; set; }

        int CoordinateX { get; set; }
        int CoordinateY { get; set; }
    }
}