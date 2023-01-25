using JVCalculatorCsharp.LengthUnitCalculator;
namespace JVCalculatorCsharp.BMI;
public class BMICalculator
{
    public static decimal CalculateBMI(double heightInCm, decimal weightInKg)
    {
        double heightSquared = Math.Pow(heightInCm, 2);
        decimal BMI = (weightInKg / Convert.ToDecimal(heightSquared)) * 10000;
        return Math.Round(BMI,1);
    }
    public static decimal CalculateBMI(decimal feet, decimal inches, decimal weightInLbs)
    {
        const decimal LbsToKgRatio = 0.45359237m;
        decimal heightInCm = ConvertFeetAndInchToCm(feet, inches);
        decimal weightInKg = weightInLbs * LbsToKgRatio;

        decimal BMI = CalculateBMI(Convert.ToDouble(heightInCm), weightInKg);
        return BMI;
    }
    public static decimal ConvertFeetAndInchToCm(decimal feet, decimal inches)
    {
        decimal feetInCm = LengthUnitConverter.ConvertLengthUnit(feet, "Foot", "Centimeter");
        decimal inchesInCm = LengthUnitConverter.ConvertLengthUnit(inches, "Inch", "Centimeter");

        return feetInCm + inchesInCm;
    }
}
