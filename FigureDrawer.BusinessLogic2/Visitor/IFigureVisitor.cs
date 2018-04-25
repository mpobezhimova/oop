using FigureDrawer.BusinessLogic2.Figures;

namespace FigureDrawer.BusinessLogic2.Visitor
{
    public interface IFigureVisitor
    {
        void Visit(Circle figure);
        void Visit(Square figure);
        void Visit(Triangle figure);
    }
}