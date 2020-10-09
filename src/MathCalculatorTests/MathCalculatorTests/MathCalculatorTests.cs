using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTests
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void WhenSumFiveAndThreeThenGotEight()
        {
                // Arrage
                const int Five = 5;
                const int Three = 3;
                MathCalculator calculator = new MathCalculator();

                // Act
                var result = calculator.Sum(Five, Three);

                // Assert
                Assert.Equal(8, result);
        }
    }
}
