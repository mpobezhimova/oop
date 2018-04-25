using System;

namespace FigureDrawer.BusinessLogic.Figures
{
    public class Circle : BaseDrawableFigure
    {
        public Circle()
        {
        }

        public Circle(ConsoleColor color, int coordinateX, int coordinateY) : base(color, coordinateX, coordinateY)
        {
        }
    }
}