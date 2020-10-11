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

        [Fact]
        public void WhenSumStringBeliberdaAndFiveGotNull()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Sum("www1", Five.ToString());
            Assert.Equal(0, result);
        }

        [Fact]
        public void WhenSubStringFiveAndThreeGotTwo()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Sub(Five.ToString(), Three.ToString());
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenSubStringBeliberdaAndFiveGotNull()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Sub(Five.ToString(), "ww112");
            Assert.Equal(0, result);
        }

        [Fact]
        public void WhenSubStringFiveAndBeliberdaGotNull()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Sub( "ww112", Five.ToString());
            Assert.Equal(0, result);
        }

                [Fact]
        public void WhenMultStringFiveAndThreeGot15()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Mult(Five.ToString(), Three.ToString());
            Assert.Equal(15, result);
        }

        [Fact]
        public void WhenMultStringBeliberdaAndFiveGotNull()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Mult(Five.ToString(), "ww112");
            Assert.Equal(0, result);
        }

        [Fact]
        public void WhenMultStringFiveAndBeliberdaGotNull()
        {
            MathCalculator calculator = new MathCalculator();
            var result = calculator.Mult( "ww112", Five.ToString());
            Assert.Equal(0, result);
        }
    }
}
