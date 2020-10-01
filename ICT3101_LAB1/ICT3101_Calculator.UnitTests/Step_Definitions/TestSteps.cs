using NUnit.Framework;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class TestSteps
    {
        private CalculatorContext _calculatorContext;
        private double _result;
        
        public TestSteps(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [Given(@"a calculator")]
        public void GivenACalculator()
        {
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorPressAdd(int p0, int p1)
        {
            _result = _calculatorContext.Calculator.Add(p0, p1);
        }
        
        [Then(@"The result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
