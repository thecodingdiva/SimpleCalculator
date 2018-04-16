using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class CalculatorEngine
    {
        public double Calculate(string operation, double Input1, double Input2)
        {
            double result;

            switch (operation.ToLower())
            {
                //regardless of 'add' or '+' it will perform the calculation for result
                case "add":
                case "+":
                    result = Input1 + Input2;
                    break;

                case "subtract":
                case "-":
                    result = Input1 - Input2;
                    break;

                case "multiply":
                case "*":
                    result = Input1 * Input2;
                    break;

                case "divide":
                case "/":
                    result = Input1 / Input2;
                    break;

                default:
                    throw new InvalidOperationException("Specified opeartion is not recognized");
            }
            return result;
        }
    }
}
