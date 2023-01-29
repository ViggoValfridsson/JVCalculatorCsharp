using JVCalculatorCsharp.ConvertCurrency;
using JVCalculatorCsharp.Utils;
namespace JVCalculatorCsharpTest;

public class ObjectHelperTest
{
    [Fact]
    public async void GetPropValueTest()
    {
        var testObject = await GetConversionRate.FetchFromApi("USD");

        var result = ObjectHelpers.GetPropValue(testObject.conversion_rates, "SEK");

        Assert.Equal(testObject.conversion_rates.SEK, result);
    }
}
