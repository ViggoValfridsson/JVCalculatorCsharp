namespace JVCalculatorCsharp.BMICalculator;
public class BMIConverter
{
    public static decimal CalculateBMI(double heightInCm, decimal weightInKg)
    {
        double heightSquared = Math.Pow(heightInCm, 2);
        decimal BMI = (weightInKg / heightSquared) * 10000;
        return BMI;
    }
    public static double CalculateBMI(decimal feet, decimal inches, decimal weightInLbs)
    {
        return 0;
    }
}
