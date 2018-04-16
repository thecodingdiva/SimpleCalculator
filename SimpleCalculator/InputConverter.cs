using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class InputConverter
    {
        public double ConvertInputToNumeric(string InputText)
        {
            double convertedNumber;
            if (!double.TryParse(InputText, out convertedNumber))
            throw new ArgumentException("Expected a numeric value");
            return convertedNumber;
        }
    }
}
