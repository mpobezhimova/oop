using System;
using FigureDrawer.BusinessLogic2.Visitor;

namespace FigureDrawer.BusinessLogic2.Figures
{
    public class Square : BaseDrawableFigure
    {
        public Square()
        {
        }

        public Square(ConsoleColor color, int coordinateX, int coordinateY) : base(color, coordinateX, coordinateY)
        {
        }

        public override void Accept(IFigureVisitor visitor)
        {
            visitor?.Visit(this);
        }
    }
}