using JVCalculatorCsharp.Models;
namespace JVCalculatorCsharp.LengthUnitCalculator;

public class LengthUnitConverter
{
    //Uses conversion rates in LengthUnitModel to convert between different length units
    public static decimal ConvertLengthUnit(decimal startValue, string startUnit, string newUnit)
    {
        bool bothUnitsAreImperial = false;

        if (CheckIfImperial(startUnit) && CheckIfImperial(newUnit))
        {
            bothUnitsAreImperial = true;
        }

        //Model contains the ratio between all units and a meter
        LengthUnitModel units = new();

        var newUnitValue = units.GetType().GetField(newUnit)?.GetValue(units);
        var startUnitValue = units.GetType().GetField(startUnit)?.GetValue(units);

        decimal conversionRatio = Convert.ToDecimal(startUnitValue) / Convert.ToDecimal(newUnitValue);

        decimal ConvertedValue = conversionRatio * startValue;

        //If both units are imperial the number is limited to 4 decimals. This is to prevent decimal numbers when for example counting in base 12.
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
    //Returns true if a string contains an imperial unit otherwise false
    public static bool CheckIfImperial(string unit)
    {
        if ((unit == "Inch" || unit == "Foot" || unit == "Yard" || unit == "Mile"))
        {
            return true;
        }
        return false;
    }
}
