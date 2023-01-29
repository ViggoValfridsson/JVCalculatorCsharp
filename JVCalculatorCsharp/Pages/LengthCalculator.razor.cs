using JVCalculatorCsharp.LengthUnitCalculator;

namespace JVCalculatorCsharp.Pages
{
    public partial class LengthCalculator
    {
        public string? StartingUnit { get; set; } = "Millimeter";
        public string? ConversionUnit { get; set; } = "Inch";
        public string? StartAmount { get; set; }
        public string? ConvertedAmount { get; set; }
        public bool InvalidUnit { get; set; } = false;
        public bool InvalidAmount { get; set; } = false;

        public void HandleSubmit()
        {
            if (String.IsNullOrWhiteSpace(StartingUnit) || String.IsNullOrWhiteSpace(ConversionUnit))
            {
                InvalidUnit = true;
                return;
            }
            else if (decimal.TryParse(StartAmount, out var amount))
            {
                InvalidAmount = false;
                InvalidUnit = false;
                ConvertedAmount = "Loading...";
                decimal CalculatedAmount = LengthUnitConverter.ConvertLengthUnit(amount, StartingUnit, ConversionUnit);
                ConvertedAmount = CalculatedAmount.ToString("G29");
            }
            else
            {
                InvalidAmount = true;
            }
        }
    }
}
