using JVCalculatorCsharp.Models;
using JVCalculatorCsharp.Utils;
using Newtonsoft.Json;

namespace JVCalculatorCsharp.ConvertCurrency;
public class GetConversionRate
{
    public static async Task<ExchangeDataObject> FetchFromApi(string currency)
    {
        HttpClient client = new();

        try
        {
            using HttpResponseMessage response = await client.GetAsync($"https://v6.exchangerate-api.com/v6/5662c65a3d5d2220cef80298/latest/{currency}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            ExchangeDataObject exhangeRates = JsonConvert.DeserializeObject<ExchangeDataObject>(responseBody)!;
            return exhangeRates;
        }
        catch
        {
            throw new HttpRequestException("Could not get the exchange data, please try again.");
        }
    }
    public static decimal CalculateConvertedValue(decimal startValue, decimal conversionRate)
    {
        return startValue * conversionRate;
    }
    public static async Task<decimal> ConvertCurrency(string baseCurrency, string exchangeCurrency, double startValue)
    {
        ExchangeDataObject responseObject = await FetchFromApi(baseCurrency);
        var conversionRate = ObjectHelpers.GetPropValue(responseObject.conversion_rates, exchangeCurrency);

        return CalculateConvertedValue(Convert.ToDecimal(conversionRate), Convert.ToDecimal(startValue));
    }
}
