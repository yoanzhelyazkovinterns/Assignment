using GeometricFigures.Models;
using GeometricFigures.TestData;

namespace GeometricFigures;

public static class ValuePrinter
{
    public static void PrintGeometricAreaAndPerimeter()
    {
        foreach (var baseGeometricFigure in CalculatedData())
        {
            Console.Write($"Area of {baseGeometricFigure.FigureName}: ");
            Console.WriteLine(baseGeometricFigure.Area);

            Console.Write($"Perimeter of {baseGeometricFigure.FigureName}: ");
            Console.WriteLine($"{baseGeometricFigure.Perimeter}{Environment.NewLine}");
        }
    }

    private static List<BaseGeometricFigure> CalculatedData()
    {
        var squareSide = DefaultValueProvider.DefaultSquareValues().Side;

        var rhombusHorizontalDiagonal = DefaultValueProvider.DefaultRhombusValues().HorizontalDiagonal;
        var rhombusVerticalDiagonal = DefaultValueProvider.DefaultRhombusValues().VerticalDiagonal;
        var rhombusSide = DefaultValueProvider.DefaultRhombusValues().Side;

        var rectangleWidth = DefaultValueProvider.DefaultRectangleValues().Width;
        var rectangleLength = DefaultValueProvider.DefaultRectangleValues().Length;

        var calculatedSquare = GeometricCalculator.CalculateSquareAreaAndPerimeter(squareSide);
        var calculatedRhombus = GeometricCalculator.CalculateRhombusAreaAndPerimeter(
            rhombusHorizontalDiagonal, rhombusVerticalDiagonal, rhombusSide);
        
        var calculatedRectangle = GeometricCalculator.CalculateRectangleAreaAndPerimeter(rectangleWidth, rectangleLength);

        return new List<BaseGeometricFigure>() {calculatedSquare, calculatedRhombus, calculatedRectangle};
    }
}