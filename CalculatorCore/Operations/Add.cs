using CalculatorCore.Model;
using CalculatorCore.ICore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorCore.Operation
{
    public class Add : IOperation
    { 
        public int GetResult (Calculator calculatorObject)
        {
            return calculatorObject.Number1 + calculatorObject.Number2;
        }
    }
}
