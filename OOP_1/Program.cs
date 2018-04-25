using FigureDrawer.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IEnumerable<IDrawableFigure> figureCollection = new StaticDrawableFigureCollection();

            var figureDrawer = new FigureDrawer();
            
            // drawing         
            Console.WriteLine("Drawing collection of figures...");
            Console.WriteLine();
            figureDrawer.DrawFigures(figureCollection);
            Console.ReadLine();
        }
    }
}
