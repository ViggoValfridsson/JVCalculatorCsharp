namespace JVCalculatorCsharp.CompoundInterest;

public class Compound
{
    //This function allows the user to calculate how much an investment will be worth in X years, with an annual return of Y%.
    public static double CalcCompound(double startingCapital, double rateOfReturn, double years)
    {
        var rateOfReturnPercent = (rateOfReturn / 100) + 1;

        var totavkast = Math.Pow(rateOfReturnPercent, years);

        return totavkast * startingCapital;
    }
}
