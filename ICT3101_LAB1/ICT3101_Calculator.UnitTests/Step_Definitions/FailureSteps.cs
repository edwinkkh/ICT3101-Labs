using NUnit.Framework;
using System;
using System.Globalization;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class FailureSteps
    {
        private double result;
        private Calculator cal;

        public FailureSteps(Calculator c)
        {
            cal = c;
        }

        [Given(@"I have a verification and validation")]
        public void GivenIHaveAVerificationAndValidation()
        {
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press current failure")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressCurrentFailure(int p0, int p1, int p2)
        {
            result = cal.CurrentFailureIntensity(p0, p1, p2);
        }

        [Then(@"the current intensity result should be ""(.*)""")]
        public void ThenFactorialShouldBe(double p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press average failure")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressAverageFailure(double p0, double p1, double p2)
        {
            result = cal.AverageFailureIntensity(p0, p1, p2);
        }

        [Then(@"The average failure result should be ""(.*)""")]
        public void ThenTheAverageFailureResultShouldBe(double p4)
        {
            Assert.That(result, Is.EqualTo(p4));
        }

    }
}
