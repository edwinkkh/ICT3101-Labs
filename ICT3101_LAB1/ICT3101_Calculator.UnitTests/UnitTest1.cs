using NUnit.Framework;
using System.Security.Cryptography;

namespace ICT3101_Calculator.UnitTests
{
    public class Tests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup() {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Subtract(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(-10));
        }

        [Test]
        public void Multiply_WhenMultiplyTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Multiply(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }

        [Test]
        public void Divide_WhenDivideTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Divide(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(0.5));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }

        [Test]
        public void Factorial_WhenMultiple_ResultEqualSum()
        {
            double result = _calculator.factorial(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        [TestCase(-1, 1)]
        [TestCase(0, 1)]
        public void Factorial_WithNegativeInputs_ResultThrowArgumentException(int num, int f)
        {
            Assert.That(() => _calculator.factorial(num, f), Throws.ArgumentException);
        }
    }
}