using FigureDrawer.BusinessLogic2.Visitor;

namespace FigureDrawer.BusinessLogic2.Contracts
{
    public abstract class BaseFigure : IFigure
    {
        public abstract void Accept(IFigureVisitor visitor);
    }
}