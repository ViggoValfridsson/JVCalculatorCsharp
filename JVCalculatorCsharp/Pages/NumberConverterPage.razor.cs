using JVCalculatorCsharp.NumberConversion;
namespace JVCalculatorCsharp.Pages;

public partial class NumberConverterPage
{
    public string? StartUnit { get; set; } = "Decimal";
    public string? ConversionUnit { get; set; } = "Binary";
    public string? Input { get; set; }
    public string? Result { get; set; }
    bool Error { get; set; } = false;

    //Uses NumberConverter class to convert between different types of numbers
    public void HandleSubmit()
    {
        //Checks if any input is null
        if (string.IsNullOrWhiteSpace(Input) || string.IsNullOrWhiteSpace(StartUnit) || string.IsNullOrWhiteSpace(ConversionUnit))
        {
            return;
        }

        //Checks if any unit is binary and then either calls BinaryConverter or DecimalHexConverter methods
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
        //Catches error and displays it as an error message
        catch (Exception e)
        {
            Error = true;
            Result = e.Message;
        }
    }
}
