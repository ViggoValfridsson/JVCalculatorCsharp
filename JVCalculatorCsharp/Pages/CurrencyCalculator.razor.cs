using JVCalculatorCsharp.ConvertCurrency;

namespace JVCalculatorCsharp.Pages
{
    public partial class CurrencyCalculator
    {
        public string? StartCurrency { get; set; }
        public string? ExchangeCurrency { get; set; }
        public string? StartAmount { get; set; }
        public bool InvalidAmount { get; set; } = false;
        public bool InvalidCurrency { get; set; } = false;
        public string? ConvertedAmount { get; set; }

        public async void ConvertCurrency()
        {
            if (String.IsNullOrWhiteSpace(StartCurrency) || String.IsNullOrWhiteSpace(ExchangeCurrency))
            {
                InvalidCurrency = true;
            }
            else if (double.TryParse(StartAmount, out var amount))
            {
                InvalidCurrency = false;
                InvalidAmount = false;
                ConvertedAmount = "Loading...";
                decimal fetchedAmount = await GetConversionRate.ConvertCurrency(StartCurrency!, ExchangeCurrency!, amount);
                ConvertedAmount = fetchedAmount.ToString();
                StateHasChanged();
            }
            else
            {
                InvalidAmount = true;
            }
        }
    }
}
