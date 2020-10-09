using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTests
    {
        private const int Five = 5;
        private const int Three = 3;

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

        [Fact]
        public void WhenSubFiveAndNegativeFiveGotNegativeOne()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Sub(Five, -Five);
            Assert.Equal(10, result);
        }

        [Fact]
        public void WhenSumThreeAndNegativeThreeGotNull()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Sum(Three, -Three);
            Assert.Equal(0, result);
        }

        [Fact]
        public void WhenSubThreeAndNullGotException()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Sub(Three, 0);
            Assert.Equal(Three, result);        
        }
    }
}
