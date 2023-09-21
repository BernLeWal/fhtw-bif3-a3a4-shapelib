namespace FHTW.Swen1.ShapeLib.Polymorphism.SolutionWithComposition
{
    public class ComposedCircle : ComposedShape
    {
        public ComposedCircle(int x, int y, int r) : base(new CirclePrinter(x, y, r), new CircleCalculator(r))
        {
        }
    }
}