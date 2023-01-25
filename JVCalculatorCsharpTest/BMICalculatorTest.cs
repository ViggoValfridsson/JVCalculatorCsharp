using JVCalculatorCsharp.BMICalculator;
using System;

namespace JVCalculatorCsharpTest
{
    public class BMICalculatorTest
    {
        [Theory]
        [InlineData(184, 76, 22.4)]
        [InlineData(190, 85, 23.5)]
        public void BMIMetricTest(double heightInCm, decimal weightInKg, decimal bmi)
        {
            decimal result = BMICalculator.CalculateBMI(heightInCm, weightInKg);
            decimal expected = bmi;

            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(6, 1, 168, 22.2)]
        [InlineData(6, 5, 168, 19.9)]
        public void ImperialTest(decimal feet, decimal inches, decimal weightInLbs, decimal bmi)
        {
            decimal result = BMICalculator.CalculateBMI(feet, inches, weightInLbs);
            decimal expected = bmi;

            Assert.Equal(expected, result);
        }
    }
}
