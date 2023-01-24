using JVCalculatorCsharp.LengthUnitCalculator;
namespace JVCalculatorCsharpTest;
public class LengthUnitTest
{
    [Theory]
    [InlineData(1, "Inch", "Meter", 0.0254)]
    [InlineData(10, "Centimeter", "Meter", 0.1)]
    [InlineData(12, "Inch", "Foot", 1)]
    [InlineData(36, "Inch", "Yard", 1)]
    [InlineData(5280, "Foot", "Mile", 1)]
    [InlineData(15840, "Foot", "Mile", 3)]
    [InlineData(3, "Foot", "Yard", 1)]
    [InlineData(1760, "Yard", "Mile", 1)]

    public void ConvertLengthUnitTest(decimal startValue, string startUnit, string newUnit, decimal convertedValue)
    {
        decimal result = LengthUnitCalculator.ConvertLengthUnit(startValue, startUnit, newUnit);
        decimal expected = convertedValue;

        Assert.Equal(expected, result);
    }
}
