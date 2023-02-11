using GeometricFigures.Models;

namespace GeometricFigures.TestData;

public static class DefaultValueProvider
{
    public static Square DefaultSquareValues() => new()
    {
        Side = 2
    };
    
    public static Rhombus DefaultRhombusValues() => new()
    {
        HorizontalDiagonal = 8,
        VerticalDiagonal = 5,
        Side = 2
    };

    public static Rectangle DefaultRectangleValues() => new()
    {
        Width = 6,
        Length = 9
    };
}