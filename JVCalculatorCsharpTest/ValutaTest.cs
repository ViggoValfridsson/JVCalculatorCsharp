using JVCalculatorCsharp.ConvertCurrency;
using JVCalculatorCsharp.Models;
namespace JVCalculatorCsharpTest;

public class ValutaTest
{
    [Fact]
    public async void FetchExchangeDataTest()
    {
        ExchangeDataObject data = await GetConversionRate.FetchFromApi("USD");
        var expected = "success";

        Assert.Equal(expected, data.result);
    }

    [Theory]
    [InlineData(10, 10, 100)]
    [InlineData(10, 1, 10)]
    [InlineData(10, 0.9, 9)]
    public void CalculateConvertedValue(decimal startValue, decimal conversionRate, decimal convertedValue)
    {
        var result = GetConversionRate.CalculateConvertedValue(startValue, conversionRate);
        var expected = convertedValue;

        Assert.Equal(expected, result);
    }
}

