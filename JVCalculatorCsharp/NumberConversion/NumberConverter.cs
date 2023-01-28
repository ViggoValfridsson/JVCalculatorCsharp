using Newtonsoft.Json.Converters;

namespace JVCalculatorCsharp.NumberConversion;

public class NumberConverter
{
    public static string DecimalHexConverter(string input, string startUnit, string conversionUnit)
    {
        if (startUnit == "Decimal")
        {
            try
            {
                int decimalNumber = Convert.ToInt32(input);

                if (conversionUnit == "Hexadecimal")
                {
                    return decimalNumber.ToString("X");
                }
                else
                {
                    return input;
                }
            }
            catch
            {
                throw new ArgumentException("Could not convert number, please enter a whole number without any letters");
            }
        }

        try
        {
            int hexAsInteger = int.Parse(input, System.Globalization.NumberStyles.HexNumber);

            if (conversionUnit == "Decimal")
            {
                return hexAsInteger.ToString();
            }
            else
            {
                return input;
            }
        }
        catch
        {
            throw new ArgumentException("Please enter a valid hexadecimal number");
        }
    }
    public static string BinaryConverter(string input, string startUnit, string conversionUnit)
    {
        return string.Empty;
    }
}
