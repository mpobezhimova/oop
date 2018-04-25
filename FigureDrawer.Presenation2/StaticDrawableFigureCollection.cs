using System;
using System.Collections;
using System.Collections.Generic;
using FigureDrawer.BusinessLogic2;
using FigureDrawer.BusinessLogic2.Figures;

namespace FigureDrawer.Presenation2
{
    internal class StaticDrawableFigureCollection : IEnumerable<IDrawableFigure>
    {
        public IEnumerator<IDrawableFigure> GetEnumerator()
        {
            var x = 0;
            var y = 0;
            yield return new Circle(ConsoleColor.Blue, x++, y++);
            yield return new Square(ConsoleColor.Yellow, x++, y++);
            yield return new Triangle(ConsoleColor.Cyan, x, y);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}