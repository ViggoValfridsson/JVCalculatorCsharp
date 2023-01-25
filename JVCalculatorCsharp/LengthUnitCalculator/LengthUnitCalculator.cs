using JVCalculatorCsharp.Models;

namespace JVCalculatorCsharp.LengthUnitCalculator;
public class LengthUnitConverter
{
    public static decimal ConvertLengthUnit(decimal startValue, string startUnit, string newUnit)
    {
        LengthUnitModel units = new();

        var newUnitValue = units.GetType().GetField(newUnit).GetValue(units);
        var startUnitValue = units.GetType().GetField(startUnit).GetValue(units);

        decimal conversionRatio = Convert.ToDecimal(startUnitValue) / Convert.ToDecimal(newUnitValue);

        decimal nonRoundedValue = conversionRatio * startValue;
        decimal roundedValue = Math.Round(nonRoundedValue, 4);

        return roundedValue;
    }
}
