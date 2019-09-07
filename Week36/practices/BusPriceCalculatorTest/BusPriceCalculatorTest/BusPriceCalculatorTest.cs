using System;
using Xunit;
using BusPriceCalculator;

namespace BusPriceCalculatorTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100, 3498)]
        [InlineData(400, 5898)]
        [InlineData(800, 8498)]

        public void Test(int kilometers, int expectedResult)
        {
            BusCalculator calculator = new BusCalculator();
            int totalFee = calculator.Calculate(kilometers);
            Assert.Equal(expectedResult, totalFee);
        }
    }
}
