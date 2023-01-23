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
    public void GetPropValue()
    {

    }
}