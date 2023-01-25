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

    public void HandleMetricSubmit()
    {
        try
        {
           
        }
        catch
        {

        }
    }
    public void HandleImperialSubmit()
    {

    }

}
