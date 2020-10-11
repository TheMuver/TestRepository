using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTests
    {
        private const int Five = 5;
        private const int Three = 3;
        private const int Eight = 8;

        [Fact]
        public void WhenSumStringFiveAndThreeGotEight()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Sum(Five.ToString(), Three.ToString());
            Assert.Equal(Eight, result);
        }

        [Fact]
        public void WhenSumStringFiveAndBeliberdaGotNull()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Sum(Five.ToString(), "wwww");
            Assert.Equal(0, result);
        }
    }
}
