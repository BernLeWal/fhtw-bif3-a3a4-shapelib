namespace FHTW.Swen1.ShapeLib.Polymorphism.SolutionWithComposition
{
    public interface IPrinter
    {
        int XOriginCoordinate { get; }
        int YOriginCoordinate { get; }
        void PrintShapeType();
        void ShowOrigin();
    }
}