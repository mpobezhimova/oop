using System;
using System.Collections.Generic;
using FigureDrawer.BusinessLogic2;

namespace FigureDrawer.Presenation2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IEnumerable<IDrawableFigure> figureCollection = new StaticDrawableFigureCollection();
                        
            var figureDrawer = new global::FigureDrawer.Presenation2.FigureDrawer();

            // drawing
            Console.WriteLine("Drawing collection of figures...");
            Console.WriteLine();
            figureDrawer.DrawFigures(figureCollection);

            IEnumerable<IDrawableFigure> figureCollection2 = new StaticExtendableFigureCollection();
            
            // drawing           
            Console.WriteLine("Drawing extendable figures...");
            Console.WriteLine();                        
            figureDrawer.DrawFigures(figureCollection2);


            Console.ReadLine();
        }
    }
}
