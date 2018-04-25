using System;
using FigureDrawer.BusinessLogic2.Visitor;


namespace FigureDrawer.BusinessLogic2.Figures
{
    public class Triangle : BaseDrawableFigure
    {
        public Triangle()
        {
        }

        public Triangle(ConsoleColor color, int coordinateX, int coordinateY) : base(color, coordinateX, coordinateY)
        {
        }

        public override void Accept(IFigureVisitor visitor)
        {
            visitor?.Visit(this);
        }
    }
}