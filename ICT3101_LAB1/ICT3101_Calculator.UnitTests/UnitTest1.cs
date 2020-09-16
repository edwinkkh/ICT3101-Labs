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
        public void Test1()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
    }
}