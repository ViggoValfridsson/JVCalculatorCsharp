namespace JVCalculatorCsharp.CompoundInterest;

public class Compound
{
    public static double CalcCompound(double startingCapital, double rateOfReturn, double years) {
        var rateOfReturnPercent = (rateOfReturn / 100) + 1;

        var totavkast = Math.Pow(rateOfReturnPercent, years);

        return totavkast * startingCapital;
    }
}
