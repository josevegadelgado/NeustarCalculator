using CalculatorCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorCore.ICore
{ 
    public interface IOperation
    { 
        public int GetResult (Calculator calculatorObject);
 
    }
}
