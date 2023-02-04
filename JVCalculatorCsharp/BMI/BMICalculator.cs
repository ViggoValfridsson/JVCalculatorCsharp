using JVCalculatorCsharp.LengthUnitCalculator;
namespace JVCalculatorCsharp.BMI;

public class BMICalculator
{
    //Calculates BMI from height in cm and weight in kg
    public static decimal CalculateBMI(double heightInCm, decimal weightInKg)
    {
        double heightSquared = Math.Pow(heightInCm, 2);
        decimal BMI = (weightInKg / Convert.ToDecimal(heightSquared)) * 10000;
        return Math.Round(BMI,1);
    }
    //Returns BMI from length in feet/inches and weight in pounds
    public static decimal CalculateBMI(decimal feet, decimal inches, decimal weightInLbs)
    {
        const decimal LbsToKgRatio = 0.45359237m;
        decimal heightInCm = ConvertFeetAndInchToCm(feet, inches);
        decimal weightInKg = weightInLbs * LbsToKgRatio;

        decimal BMI = CalculateBMI(Convert.ToDouble(heightInCm), weightInKg);
        return BMI;
    }
    //Takes in length in feet and inches, returns length in cm
    public static decimal ConvertFeetAndInchToCm(decimal feet, decimal inches)
    {
        decimal feetInCm = LengthUnitConverter.ConvertLengthUnit(feet, "Foot", "Centimeter");
        decimal inchesInCm = LengthUnitConverter.ConvertLengthUnit(inches, "Inch", "Centimeter");

        return feetInCm + inchesInCm;
    }
}
