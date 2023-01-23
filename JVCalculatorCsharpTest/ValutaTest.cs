using JVCalculatorCsharp.FetchData;
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
    [Fact]
    public async void GetPropValueTest()
    {
        var testObject = await GetConversionRate.FetchFromApi("USD");

        var result = GetConversionRate.GetPropValue(testObject.conversion_rates, "SEK");

        Assert.Equal(testObject.conversion_rates.SEK, result);
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

