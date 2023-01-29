using JVCalculatorCsharp.NumberConversion;
namespace JVCalculatorCsharp.Pages;

public partial class NumberConverterPage
{
    public string? StartUnit { get; set; } = "Decimal";
    public string? ConversionUnit { get; set; } = "Binary";
    public string? Input { get; set; }
    public string? Result { get; set; }
    bool Error { get; set; } = false;

    public void HandleSubmit()
    {
        if (string.IsNullOrWhiteSpace(Input) || string.IsNullOrWhiteSpace(StartUnit) || string.IsNullOrWhiteSpace(ConversionUnit))
        {
            return;
        }

        try
        {
            if (StartUnit == "Binary" || ConversionUnit == "Binary")
            {
                Result = NumberConverter.BinaryConverter(Input, StartUnit, ConversionUnit);
            }
            else
            {
                Result = NumberConverter.DecimalHexConverter(Input, StartUnit, ConversionUnit);
            }

            Error = false;
        }
        catch (Exception e)
        {
            Error = true;
            Result = e.Message;
        }
    }
}
