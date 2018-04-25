using System;
using FigureDrawer.BusinessLogic2.Visitor;

namespace FigureDrawer.BusinessLogic2.Figures
{
    public class Circle : BaseDrawableFigure
    {
        public Circle()
        {
        }

        public Circle(ConsoleColor color, int coordinateX, int coordinateY) : base(color, coordinateX, coordinateY)
        {
        }

        public override void Accept(IFigureVisitor visitor)
        {
            visitor?.Visit(this);
        }
    }
}