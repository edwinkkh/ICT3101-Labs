using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {
        private double result;
        private Calculator c;

        public UsingCalculatorAvailabilitySteps(Calculator c)
        {
            this.c = c;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            result = c.MTBF(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            result = c.availability(p0, p1);
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }
    }
}
