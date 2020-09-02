using CalculatorCore.ICore;
using CalculatorCore.Logger;

using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorCore.Model
{
    public class Calculator
    {
        public IOperation Operation { get; set; }

        
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public int Calculate(IOperation Operation) {
            
            var calcOperation = Operation ?? Operation;
            if (calcOperation == null)
            {
                return 0;
            }
            int result  = calcOperation.GetResult(this);

            Logger.Logger.SaveLogInformation(String.Format("Number 1: {0}, Number 2: {1}, Result: {2}", Number1, Number2, result));
            
            return result;
        }



    }
}
