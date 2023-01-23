using JVCalculatorCsharp.Models;
using Newtonsoft.Json;

namespace JVCalculatorCsharp.FetchData;
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
            throw;
        }
    }
}
