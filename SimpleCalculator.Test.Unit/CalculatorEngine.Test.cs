using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//***in order to access the CalculatorEngine class we have to add it as a using statement
using SimpleCalculator;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class UnitTest1
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpeartion()
            /* 3 steps to a unit test
                1) Setting up data for unit test
                2) Process data through the method that you want to test
                3) compare result of the unit test to your assumption */
        {
            //This is step 1
            int num1 = 1;
            int num2 = 2;

            //*** & step 2
            double result = _calculatorEngine.Calculate("add", num1, num2);

            //Step 3
            Assert.AreEqual(3, result);
        }

        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpeartion()
        {
            int num1 = 1;
            int num2 = 2;

            double result = _calculatorEngine.Calculate("+", num1, num2);
            Assert.AreEqual(3, result);
        }
    }
}
