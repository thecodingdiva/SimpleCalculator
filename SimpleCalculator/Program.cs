﻿using System;
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
            try
            {
                //This is the object that is going to convert the string input to a number
                InputConverter inputConverter = new InputConverter();

                //This is the engine that will perform the calculation
                CalculatorEngine calculatorEngine = new CalculatorEngine();


                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                /*result is the number after the calculation has been completed.
                Calculate is the method from the CalculatorEngine. 
                This method will take the 3 inputs and output the result*/
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
