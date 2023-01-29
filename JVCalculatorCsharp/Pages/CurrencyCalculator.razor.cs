using JVCalculatorCsharp.ConvertCurrency;

namespace JVCalculatorCsharp.Pages
{
    public partial class CurrencyCalculator
    {
        public string? StartCurrency { get; set; } = "USD";
        public string? ExchangeCurrency { get; set; } = "EUR";
        public string? StartAmount { get; set; }
        public bool InvalidAmount { get; set; } = false;
        public bool InvalidCurrency { get; set; } = false;
        public string? ConvertedAmount { get; set; }

        public async void ConvertCurrency()
        {
            if (String.IsNullOrWhiteSpace(StartCurrency) || String.IsNullOrWhiteSpace(ExchangeCurrency))
            {
                InvalidCurrency = true;
                return;
            }
            else if (double.TryParse(StartAmount, out var amount))
            {
                try
                {
                    InvalidCurrency = false;
                    InvalidAmount = false;
                    ConvertedAmount = "Loading...";
                    decimal fetchedAmount = await GetConversionRate.ConvertCurrency(StartCurrency!, ExchangeCurrency!, amount);
                    ConvertedAmount = fetchedAmount.ToString();
                    StateHasChanged();
                }
                catch (HttpRequestException e)
                {
                    ConvertedAmount = e.Message;
                }
                catch
                {
                    ConvertedAmount = "Something went wrong, please try again.";
                }
            }
            else
            {
                InvalidAmount = true;
            }
        }
    }
}
