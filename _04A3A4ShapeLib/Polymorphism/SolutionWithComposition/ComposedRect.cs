using FHTW.Swen1.ShapeLib.Polymorphism.SolutionWithComposition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04A3A4ShapeLib.Polymorphism.SolutionWithComposition
{
    public class ComposedRect : ComposedShape
    {
        public ComposedRect(int x1, int y1, int x2, int y2) : base(new RectPrinter(x1, y1, x2, y2), new RectCalculator(x1, y1, x2, y2))
        {

        }
    }
}
