using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorDivisionsSteps(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = _calculatorContext.Calculator.Divide(p0, p1);
        }


        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be positive infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
