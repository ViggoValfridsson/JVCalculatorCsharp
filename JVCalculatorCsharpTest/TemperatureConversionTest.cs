using JVCalculatorCsharp.TemperatureConverter;

namespace JVCalculatorCsharpTest;

public class TemperatureConversionTest
{
    [Theory]
    [InlineData(0, "Celsius", "Fahrenheit", 32)]
    [InlineData(32, "Fahrenheit", "Celsius", 0)]
    [InlineData(0, "Celsius", "Celsius", 0)]
    [InlineData(32, "Fahrenheit", "Fahrenheit", 32)]
    [InlineData(10, "Fahrenheit", "Celsius", -12.22)]
    public void CelsiusFahrenheitConversionTest(decimal startValue, string startUnit, string convertToUnit, decimal newValue)
    {
        var expected = newValue;
        decimal result = ConvertTemperature.CelsiusFahrenheitConversion(startValue, startUnit, convertToUnit);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, "Kelvin", "Celsius", -273.15)]
    [InlineData(10, "Kelvin", "Fahrenheit", -441.67)]
    [InlineData(10, "Celsius", "Kelvin", 283.15)]
    [InlineData(10, "Fahrenheit", "Kelvin", 260.93)]
    [InlineData(10, "Kelvin", "Kelvin", 10)]
    public void KelvinConversionTest(decimal startValue, string startUnit, string convertToUnit, decimal newValue)
    {
        var expected = newValue;
        decimal result = ConvertTemperature.KelvinConversion(startValue, startUnit, convertToUnit);

        Assert.Equal(expected, result); 
    }
}