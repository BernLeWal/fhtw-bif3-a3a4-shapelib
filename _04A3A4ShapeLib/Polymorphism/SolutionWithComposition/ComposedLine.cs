namespace FHTW.Swen1.ShapeLib.Polymorphism.SolutionWithComposition
{
    public class ComposedLine : ComposedShape
    {
        public ComposedLine(int x1, int y1, int x2, int y2) : base(new LinePrinter(x1, y1, x2, y2), new LineCalculator(x1, y1, x2, y2))
        {
        }
    }
}