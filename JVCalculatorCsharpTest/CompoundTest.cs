using JVCalculatorCsharp.CompoundInterest;

namespace JVCalculatorCsharpTest;

public class CompoundTest
{
    [Theory]
    [InlineData(10, 10, 1, 11)]
    [InlineData(10, 20, 1, 12)]
    public void CompoundingTest(double startingCapital, double rateOfReturn, double years, double calculatedValue)
    {
        var expected = calculatedValue;
        var result = Compound.CalcCompound(startingCapital, rateOfReturn, years);

        Assert.Equal(expected, result);
    }
    
}

