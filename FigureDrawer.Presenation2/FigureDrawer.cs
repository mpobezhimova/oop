using System;
using System.Collections.Generic;
using FigureDrawer.BusinessLogic2;

namespace FigureDrawer.Presenation2
{
    internal class FigureDrawer
    {
        public void DrawFigures(IEnumerable<IDrawableFigure> figures)
        {
            if (figures == null)
            {
                return;
            }

            foreach (var drawableFigure in figures)
            {
                DrawFigure(drawableFigure);
            }
        }

        private void DrawFigure(IDrawableFigure drawableFigure)
        {
            if (drawableFigure == null)
            {
                return;
            }

            var currentColor = Console.ForegroundColor;

            Console.ForegroundColor = drawableFigure.Color;

            Console.WriteLine("Figure: " + drawableFigure.GetType().Name);
            Console.WriteLine("Color: " + drawableFigure.Color);
            Console.WriteLine("X: " + drawableFigure.CoordinateX);
            Console.WriteLine("Y: " + drawableFigure.CoordinateY);
            Console.WriteLine();

            Console.ForegroundColor = currentColor;
        }
    }
}