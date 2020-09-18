using NUnit.Framework;

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
    }
}