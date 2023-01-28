using JVCalculatorCsharp.NumberConversion;
namespace JVCalculatorCsharpTest;

public class NumberConversionTest
{
    [Theory]
    [InlineData("1000", "3E8", "Decimal", "Hexadecimal")]
    [InlineData("16", "10", "Decimal", "Hexadecimal")]
    [InlineData("15", "F", "Decimal", "Hexadecimal")]
    [InlineData("F", "15", "Hexadecimal", "Decimal")]
    [InlineData("3E8", "1000", "Hexadecimal", "Decimal")]
    [InlineData("3E8", "3E8", "Hexadecimal", "Hexadecimal")]
    [InlineData("1000", "1000", "Decimal", "Decimal")]
    public void DecimalHexConverterTest(string input, string convertedString, string startUnit, string conversionUnit)
    {
        string result = NumberConverter.DecimalHexConverter(input, startUnit, conversionUnit);
        var expected = convertedString;

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1F", "11111", "Hexadecimal", "Binary")]
    [InlineData("00011111", "1F", "Binary", "Hexadecimal")]
    [InlineData("11111", "1F", "Binary", "Hexadecimal")]
    [InlineData("10", "1010", "Decimal", "Binary")]
    [InlineData("1010", "10", "Binary", "Decimal")]
    [InlineData("1010", "1010", "Binary", "Binary")]
    public void BinaryConverter(string input, string convertedString, string startUnit, string conversionUnit)
    {
        string result = NumberConverter.BinaryConverter(input, startUnit, conversionUnit);
        var expected = convertedString;

        Assert.Equal(expected, result);
    }
}
