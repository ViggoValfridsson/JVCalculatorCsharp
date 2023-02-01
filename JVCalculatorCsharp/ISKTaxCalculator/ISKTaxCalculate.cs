namespace JVCalculatorCsharp.ISKTaxCalculator;

public class ISKTaxCalculate
{
    //User provides 5 values (Q1, Q2, Q3, Q4, deposits) by which this function will return a value which is equal to the users ISK-Tax for 2022.
    public static decimal ISKTaxCalc(decimal Q1, decimal Q2, decimal Q3, decimal Q4, decimal deposits)
    {
        var avgAccountValue = (Q1 + Q2 + Q3 + Q4 + deposits) / 4;
        var SLRplusOne = 0.0294m;
        var standardIncome = avgAccountValue * SLRplusOne;
        var capitalTax = 0.3m;
        var capitalTaxToPay = standardIncome * capitalTax;
        return capitalTaxToPay;
    }
}
