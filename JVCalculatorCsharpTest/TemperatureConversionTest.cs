using JVCalculatorCsharp.TemperatureConverter;

namespace JVCalculatorCsharpTest;

public class TemperatureConversionTest
{
    [Theory]
    [InlineData(0, "Celsius", "Fahrenheit", 32)]
    [InlineData(32, "Fahrenheit", "Celsius", 0)]


    public void CelsiusFahrenheitConversionTest(decimal startValue, string startUnit, string convertToUnit, decimal newValue)
    {
        var expected = newValue;
        decimal result = ConvertTemperature.CelsiusFahrenheitConversion(startValue, startUnit, convertToUnit);

        Assert.Equal(expected, result);
    }
}