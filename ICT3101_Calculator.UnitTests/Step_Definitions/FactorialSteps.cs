using NUnit.Framework;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class FactorialSteps
    {
        private Calculator c;
        private double result;

        public FactorialSteps(Calculator _context)
        {
            c = _context;
        }

        [Given(@"a number")]
        public void GivenANumber()
        {
        }
        
        [When(@"the factorial is ""(.*)""")]
        public void WhenTheNumberIs(int p0)
        {
            result = c.factorial(p0);
        }

        [When(@"the factorial is negative")]
        public void donothing()
        {

        }

        [Then(@"The factorial result should be ""(.*)""")]
        public void ThenFactorialShouldBe(double p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }

        [Then(@"The factorial result should be error")]
        public void ThenTheResultShouldBeError()
        {
            Assert.Throws<ArgumentException>(() => c.factorial(-1));
        }

    }
}
