using JVCalculatorCsharp.BMI;
namespace JVCalculatorCsharp.Pages;

public partial class BMICalculatorPage
{
    public bool UsingMetricUnits { get; set; } = true;
    public string? BMI { get; set; }
    public string? HeightInCm { get; set; }
    public string? WeightInKg { get; set; }
    public string? HeightFeet { get; set; }
    public string? HeightInches { get; set; }
    public string? WeightInLbs { get; set; }
    public bool InvalidInput { get; set; } = false;

    //Validates inputs and then uses the BMICalculator class to calculate BMI
    public void HandleSubmit()
    {
        try
        {
            decimal result;

            if (UsingMetricUnits)
            {
                //Converts input to correct datatype
                double heightInCm = Double.Parse(HeightInCm!);
                decimal weightInKg = Decimal.Parse(WeightInKg!);

                if (heightInCm <= 0 || weightInKg <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                result = BMICalculator.CalculateBMI(heightInCm, weightInKg);
            }
            else
            {
                //Converts input to correct datatype
                decimal heightInFeet = decimal.Parse(HeightFeet!);
                decimal heightInInches = decimal.Parse(HeightInches!);
                decimal weightInLbs = decimal.Parse(WeightInLbs!);

                if (heightInFeet <= 0 || heightInInches < 0 || weightInLbs <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                result = BMICalculator.CalculateBMI(heightInFeet, heightInInches, weightInLbs);
            }

            //Sets errors to false
            InvalidInput = false;

            BMI = $"BMI = {result.ToString("G29")}";
        }
        //Sets invalid input to true which triggers an error message in UI
        catch
        {
            InvalidInput = true;
            BMI = string.Empty;
        }
    }
}
