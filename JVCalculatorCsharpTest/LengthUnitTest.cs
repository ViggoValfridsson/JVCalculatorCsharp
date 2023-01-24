namespace JVCalculatorCsharpTest;
public class LengthUnitTest
{
    [Theory]
    [InlineData(1, "Inch", "Meter", 0.0254)]
    public void ConvertLengthUnitTest(decimal startValue, string startUnit, string newUnit, decimal convertedValue)
    {
        decimal result = LengthUnitCalculator.Convert(startValue, startUnit, newUnit);
        decimal expected = convertedValue;

        Assert.Equal(expected, result);
    }
}
