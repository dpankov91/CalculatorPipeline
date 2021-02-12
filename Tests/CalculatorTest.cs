using NUnit.Framework;
using Services;

namespace Tests
{
    public class Tests
    {
        private ICalculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void AddNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyNumbersWithNoInput()
        {
            
        }
        
        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            var actual = _calculator.Multiply(5, 5);
            const double expected = 25;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            var actual = _calculator.Multiply(-5, -5);
            const double expected = 25;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyThreePositiveNumbers()
        {
            var actual = _calculator.Multiply(5, 5, 2);
            const double expected = 50;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyThreeNegativeNumbers()
        {
            var actual = _calculator.Multiply(-5, -5, -2);
            const double expected = -50;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoNumbersWithZero()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideThreeNumbersWithZero()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOfFive()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOf200()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOfZero()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOfNegativeNumber()
        {
            Assert.Inconclusive("Test not fully implemented");
        }
    }
}