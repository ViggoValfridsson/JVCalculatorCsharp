using JVCalculatorCsharp.LengthUnitCalculator;
namespace JVCalculatorCsharp.Pages;

public partial class LengthCalculator
{
    public string? StartingUnit { get; set; } = "Millimeter";
    public string? ConversionUnit { get; set; } = "Inch";
    public string? StartAmount { get; set; }
    public string? ConvertedAmount { get; set; }
    public bool InvalidUnit { get; set; } = false;
    public bool InvalidAmount { get; set; } = false;

    //Performs input validation and uses LengthUnitConverter to convert lengths
    public void HandleSubmit()
    {
        //Checks for null values
        if (String.IsNullOrWhiteSpace(StartingUnit) || String.IsNullOrWhiteSpace(ConversionUnit))
        {
            InvalidUnit = true;
            return;
        }
        //If amount is valid, sets all errors to false and converts value using LengthUnitConverter class
        else if (decimal.TryParse(StartAmount, out var amount))
        {
            InvalidAmount = false;
            InvalidUnit = false;
            decimal CalculatedAmount;

            //try catch to catch possible overflowexceptions
            try
            {
                CalculatedAmount = LengthUnitConverter.ConvertLengthUnit(amount, StartingUnit, ConversionUnit);
            }
            catch 
            {
                InvalidAmount = true;
                return;
            }
            ConvertedAmount = CalculatedAmount.ToString("G29");
        }
        //Sets bool to true which shows error message in UI
        else
        {
            InvalidAmount = true;
        }
    }
}
