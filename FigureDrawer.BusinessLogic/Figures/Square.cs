using System;

namespace FigureDrawer.BusinessLogic.Figures
{
    public class Square : BaseDrawableFigure
    {
        public Square()
        {
        }

        public Square(ConsoleColor color, int coordinateX, int coordinateY) : base(color, coordinateX, coordinateY)
        {
        }
    }
}