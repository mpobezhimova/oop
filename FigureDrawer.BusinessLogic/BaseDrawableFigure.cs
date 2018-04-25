using System;

namespace FigureDrawer.BusinessLogic
{
    public abstract class BaseDrawableFigure : IDrawableFigure
    {
        public ConsoleColor Color { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        protected BaseDrawableFigure()
        {
        }

        protected BaseDrawableFigure(ConsoleColor color, int coordinateX, int coordinateY)
        {
            Color = color;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }
}