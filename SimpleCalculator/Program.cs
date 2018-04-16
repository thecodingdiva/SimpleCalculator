using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the object that is going to convert the string input to a number
            InputCalculator inputConvertor = new InputConverter();

            //This is the engine that will perform the calculation
            CalculatorEngine calculatorEngine = new CalculatorEngine();


            double firstNumber = inputConvertor.ConvertInputToNumeric(Console.ReadLine());
            double secondNumber = inputConvertor.ConvertInputToNumeric(Console.ReadLine());
            string operation = Console.ReadLine();

        }
    }
}
