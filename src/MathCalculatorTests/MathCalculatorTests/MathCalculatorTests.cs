using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTests
    {
        const int Five = 5;
        const int Three = 3;

        [Fact]
        public void WhenSumFiveAndThreeThenGotEight()
        {
                // Arrage
                MathCalculator calculator = new MathCalculator();

                // Act
                var result = calculator.Sum(Five, Three);

                // Assert
                Assert.Equal(8, result);
        }
        
        [Fact]
        public void WhenSubFiveAndThreeGotTwo()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Sub(Five, Three);
            Assert.Equal(2, result);
        }
    }
}
