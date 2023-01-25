using JVCalculatorCsharp.LengthUnitCalculator;

namespace JVCalculatorCsharp.Pages
{
    public partial class LengthCalculator
    {
        public string? StartingUnit { get; set; }
        public string? ConversionUnit { get; set; }
        public string? StartAmount { get; set; }
        public string? ConvertedAmount { get; set; }
        public bool InvalidUnit { get; set; } = false;
        public bool InvalidAmount { get; set; } = false;

        public void HandleSubmit()
        {
            if (String.IsNullOrWhiteSpace(StartingUnit) || String.IsNullOrWhiteSpace(ConversionUnit))
            {
                Console.WriteLine("null");
                InvalidUnit = true;
            }
            else if (decimal.TryParse(StartAmount, out var amount))
            {
                Console.WriteLine("Right!");
                InvalidAmount = false;
                InvalidUnit = false;
                ConvertedAmount = "Loading...";
                decimal CalculatedAmount = LengthUnitConverter.ConvertLengthUnit(amount, StartingUnit, ConversionUnit);
                ConvertedAmount = CalculatedAmount.ToString("G29");
            }
            else
            {
                Console.WriteLine("else");
                InvalidAmount = true;
            }
        }
    }
}
