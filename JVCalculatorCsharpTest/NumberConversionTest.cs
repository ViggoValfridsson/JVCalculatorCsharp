using JVCalculatorCsharp.NumberConversion;
namespace JVCalculatorCsharpTest;

public class NumberConversionTest
{
    [Theory]
    [InlineData(1000, "3E8")]
    [InlineData(16, "10")]
    [InlineData(15, "F")]

    public void DecimalToHex(int input, string hex)
    {
        string result = NumberConverter.DecimalToHex(input);
        var expected = hex;

        Assert.Equal(expected, result);
    }
}
