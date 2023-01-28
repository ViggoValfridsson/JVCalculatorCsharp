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
        if (startUnit == "Binary")
        {
            try
            {
                int inputInDecimal = Convert.ToInt32(input, 2);

                if (conversionUnit == "Hexadecimal")
                {
                    return inputInDecimal.ToString("X");
                }
                else if (conversionUnit == "Decimal")
                {
                    return inputInDecimal.ToString();
                }

                return input;
            }
            catch
            {
                throw new ArgumentException("Please enter a valid binary number!");
            }
        }
        else
        {
            try
            {
                int inputInDecimal;

                if (startUnit == "Hexadecimal")
                {
                    inputInDecimal = Convert.ToInt32(DecimalHexConverter(input, startUnit, "Decimal"));
                }
                else
                {
                    inputInDecimal = Convert.ToInt32(input);
                }

                return Convert.ToString(inputInDecimal, 2);
            }
            catch
            {
                throw new ArgumentException($"Please enter a valid {startUnit.ToLower()} number");
            }
        }
    }
}
