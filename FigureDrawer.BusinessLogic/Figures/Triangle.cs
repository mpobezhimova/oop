using System;

namespace FigureDrawer.BusinessLogic.Figures
{
    public class Triangle : BaseDrawableFigure
    {
        public Triangle()
        {
        }

        public Triangle(ConsoleColor color, int coordinateX, int coordinateY) : base(color, coordinateX, coordinateY)
        {
        }
    }
}