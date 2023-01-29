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
        public bool Loading { get; set; } = false;

        public async void ConvertCurrency()
        {
            if (String.IsNullOrWhiteSpace(StartCurrency) || String.IsNullOrWhiteSpace(ExchangeCurrency))
            {
                InvalidCurrency = true;
                Loading= false;
                return;
            }
            else 
            {
                try
                {
                    var amount = Convert.ToDouble(StartAmount);
                    InvalidCurrency = false;
                    InvalidAmount = false;
                    Loading = true;
                    decimal fetchedAmount = await GetConversionRate.ConvertCurrency(StartCurrency!, ExchangeCurrency!, amount);
                    ConvertedAmount = fetchedAmount.ToString();
                }
                catch (OverflowException)
                {
                    InvalidAmount = true;
                    ConvertedAmount = $"Input was either too large or too small, please enter a value between {double.MinValue} and {double.MaxValue}.";
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
            Loading = false;
            StateHasChanged();
        }
    }
}
