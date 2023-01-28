using JVCalculatorCsharp.ISKTaxCalculator;

namespace JVCalculatorCsharpTest
{
    public class IskTaxTest
    {
        [Theory]
        [InlineData(100000, 100000, 100000, 100000, 0, 882)]
        [InlineData(200000, 150000, 250000, 400000, 50000, 2315.25)]
        [InlineData(400000, 150000, 175000, 300000, 100000, 2480.625)]


        public void ISKTaxCalculatorTest(decimal Q1, decimal Q2, decimal Q3, decimal Q4, decimal deposits, decimal capitalTaxToPay)
        {
            var result = ISKTaxCalculate.ISKTaxCalc(Q1, Q2, Q3, Q4, deposits);
            var expected = capitalTaxToPay;

            Assert.Equal(expected, result);
        }
    }
}
