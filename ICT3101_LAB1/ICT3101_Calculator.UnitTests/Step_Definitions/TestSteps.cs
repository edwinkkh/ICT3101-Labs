using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class TestSteps
    {
        private Calculator _calculator;
        private double _result;
        [Given(@"a calculator")]
        public void GivenACalculator()
        {
            _calculator = new Calculator();
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorPressAdd(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        
        [Then(@"The result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
