using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    public class CalculatorContext
    {
        public Calculator Calculator { get; set; }
        
        public CalculatorContext()
        {
            Calculator = new Calculator();
        }
    }

}
