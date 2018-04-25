using System;
using FigureDrawer.BusinessLogic2.Contracts;
using FigureDrawer.BusinessLogic2.Figures;

namespace FigureDrawer.BusinessLogic2.Visitor
{
    public class DemonFigureVisitor : IFigureVisitor
    {
        private static void DemonizeFigure(IDrawableFigure figure)
        {
            if (figure == null)
            {
                return;
            }

            const int demonNumber = 666;
            figure.Color = ConsoleColor.DarkRed;
            figure.CoordinateX = demonNumber;
            figure.CoordinateY = demonNumber;
        }

        public void Visit(Circle figure)
        {
            DemonizeFigure(figure);
        }

        public void Visit(Square figure)
        {
            DemonizeFigure(figure);
        }

        public void Visit(Triangle figure)
        {
            DemonizeFigure(figure);
        }
    }
}