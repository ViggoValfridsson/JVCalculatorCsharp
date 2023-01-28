using JVCalculatorCsharp.NumberConversion;
namespace JVCalculatorCsharpTest;

public class NumberConversionTest
{
    [Theory]
    [InlineData("1000", "3E8", "Hexadecimal", "Decimal")]
    [InlineData("16", "10", "Hexadecimal", "Decimal")]
    [InlineData("15", "F", "Hexadecimal", "Decimal")]
    [InlineData("F", "15",  "Hexadecimal", "Decimal")]
    [InlineData("3E8", "1000", "Hexadecimal", "Decimal")]

    public void DecimalToHex(string input, string hex, string startUnit, string conversionUnit)
    {
        string result = NumberConverter.DecimalHexConverter(input, startUnit, conversionUnit);
        var expected = hex;

        Assert.Equal(expected, result);
    }
}
