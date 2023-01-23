using JVCalculatorCsharp.FetchData;
using JVCalculatorCsharp.Models;
namespace JVCalculatorCsharpTest;

public class ValutaTest
{
    [Fact]
    public async void FetchExchangeDataTest()
    {
        ExchangeDataObject data = await GetConversionRate.FetchFromApi("USD");

        Assert.Equal("success", data.result);
    }
}