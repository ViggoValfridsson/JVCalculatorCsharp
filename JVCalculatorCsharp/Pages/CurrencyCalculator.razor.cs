using JVCalculatorCsharp.ConvertCurrency;
namespace JVCalculatorCsharp.Pages;

public partial class CurrencyCalculator
{
    public string? StartCurrency { get; set; } = "USD";
    public string? ExchangeCurrency { get; set; } = "EUR";
    public string? StartAmount { get; set; }
    public bool InvalidAmount { get; set; } = false;
    public bool InvalidCurrency { get; set; } = false;
    public string? ConvertedAmount { get; set; }
    public bool Loading { get; set; } = false;

    //Uses GetConversionRate class to convert currencies
    public async void ConvertCurrency()
    {
        //Checks for null values and returns if there are any
        if (String.IsNullOrWhiteSpace(StartCurrency) || String.IsNullOrWhiteSpace(ExchangeCurrency))
        {
            InvalidCurrency = true;
            Loading= false;
            return;
        }
        else 
        {
            //Tries to convert input and then uses GetConversionRate to calculate exchange
            try
            {
                var amount = Convert.ToDouble(StartAmount);
                InvalidCurrency = false;
                InvalidAmount = false;
                Loading = true;
                decimal fetchedAmount = await GetConversionRate.ConvertCurrency(StartCurrency!, ExchangeCurrency!, amount);
                ConvertedAmount = fetchedAmount.ToString();
            }
            //Display message if an invalid input caused overflow
            catch (OverflowException)
            {
                InvalidAmount = true;
                ConvertedAmount = $"Input was either too large or too small, please enter another number.";
            }
            //Displays an error message if something went wrong with the HttpRequest
            catch (HttpRequestException e)
            {
                ConvertedAmount = e.Message;
            }
            //Generic error message
            catch
            {
                ConvertedAmount = "Something went wrong, please try again.";
            }
        }
        Loading = false;
        StateHasChanged();
    }
}
