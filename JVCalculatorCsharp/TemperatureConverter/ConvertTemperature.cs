namespace JVCalculatorCsharp.TemperatureConverter;

public class ConvertTemperature
{
    public static decimal CelsiusFahrenheitConversion(decimal startValue, string startUnit, string convertToUnit)
    {
        decimal returnValue;
        if (startUnit == "Celsius" && convertToUnit == "Fahrenheit")
        {
            returnValue = startValue * (9m / 5m) + 32;
        }
        else if (startUnit == "Fahrenheit" && convertToUnit == "Celsius")
        {
            returnValue = (startValue - 32) * (5m / 9m);
        }
        else
        {
            returnValue = startValue;
        }
        return Math.Round(returnValue, 2);
    }

    public static decimal KelvinConversion(decimal startValue, string startUnit, string convertToUnit)
    {
        if(startUnit == "Kelvin" && convertToUnit == "Celsius")
        {
            return startValue - 273.15m;
        }
        else if (startUnit == "Celsius" && convertToUnit == "Kelvin")
        {
            return startValue + 273.15m;
        }
        else if (startUnit == "Kelvin" && convertToUnit == "Fahrenheit")
        {
            var celsius = startValue - 273.15m;
            return CelsiusFahrenheitConversion(celsius, "Celsius", "Fahrenheit");
        }
        else if (startUnit == "Fahrenheit" && convertToUnit == "Kelvin")
        {
            var celsius = CelsiusFahrenheitConversion(startValue, "Fahrenheit", "Celsius");
            return celsius + 273.15m;
        }
        else
        {
            return startValue;
        }
    }
}

