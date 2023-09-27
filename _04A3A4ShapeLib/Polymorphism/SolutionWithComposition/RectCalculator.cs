using FHTW.Swen1.ShapeLib.Polymorphism.SolutionWithComposition;

namespace _04A3A4ShapeLib.Polymorphism.SolutionWithComposition
{
    internal class RectCalculator : ICalculator
    {
        public RectCalculator(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public int X1 { get; }
        public int Y1 { get; }
        public int X2 { get; }
        public int Y2 { get; }

        public double GetArea()
        {
            return (X2-X1) * (Y2-Y1);
        }

        public double GetPerimeter()
        {
            // basically no perimeter for lines, but line length will be calculated
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }
    }
}