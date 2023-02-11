using GeometricFigures.Models;

namespace GeometricFigures;

public static class GeometricCalculator
{
    public static BaseGeometricFigure CalculateSquareAreaAndPerimeter(int side) => new()
    {
        FigureName = "Square",
        Area = side * side,
        Perimeter = 4 * side
    };

    public static BaseGeometricFigure CalculateRhombusAreaAndPerimeter(int horizontalDiagonal, int verticalDiagonal,int side) => new()
    {
        FigureName = "Rhombus",
        Area = (horizontalDiagonal * verticalDiagonal) / 2,
        Perimeter = 4 * side
    };
    
    public static BaseGeometricFigure CalculateRectangleAreaAndPerimeter(int width, int length) => new()
    {
        FigureName = "Rectangle",
        Area = width * length,
        Perimeter = 2 * (width + length)
    };
}