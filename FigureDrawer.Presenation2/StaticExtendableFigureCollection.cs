using System.Collections;
using System.Collections.Generic;
using FigureDrawer.BusinessLogic2;
using FigureDrawer.BusinessLogic2.Visitor;

namespace FigureDrawer.Presenation2
{
    internal class StaticExtendableFigureCollection : IEnumerable<IDrawableFigure>
    {
        public IEnumerator<IDrawableFigure> GetEnumerator()
        {
            var staticFigures = new StaticDrawableFigureCollection();

            var demonVisitor = new DemonFigureVisitor();

            foreach (var staticFigure in staticFigures)
            {
                if (staticFigure == null)
                {
                    continue;
                }

                staticFigure.Accept(demonVisitor);

                yield return staticFigure;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
