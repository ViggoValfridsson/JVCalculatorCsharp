using JVCalculatorCsharp.Models;
namespace JVCalculatorCsharp.LengthUnitCalculator;

public class LengthUnitConverter
{
    public static decimal ConvertLengthUnit(decimal startValue, string startUnit, string newUnit)
    {
        bool bothUnitsAreImperial = false;

        if (CheckIfImperial(startUnit) && CheckIfImperial(newUnit))
        {
            bothUnitsAreImperial = true;
        }

        LengthUnitModel units = new();

        var newUnitValue = units.GetType().GetField(newUnit)?.GetValue(units);
        var startUnitValue = units.GetType().GetField(startUnit)?.GetValue(units);

        decimal conversionRatio = Convert.ToDecimal(startUnitValue) / Convert.ToDecimal(newUnitValue);

        decimal ConvertedValue = conversionRatio * startValue;

        if (bothUnitsAreImperial)
        {
            ConvertedValue = Math.Round(ConvertedValue, 4);
        }
        else
        {
            ConvertedValue = Math.Round(ConvertedValue, 10);
        }

        return ConvertedValue;
    }
    public static bool CheckIfImperial(string unit)
    {
        if ((unit == "Inch" || unit == "Foot" || unit == "Yard" || unit == "Mile"))
        {
            return true;
        }
        return false;
    }
}
