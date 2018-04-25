using FigureDrawer.BusinessLogic2.Visitor;

namespace FigureDrawer.BusinessLogic2.Contracts
{
    public interface IFigure
    {
        void Accept(IFigureVisitor visitor);
    }
}
