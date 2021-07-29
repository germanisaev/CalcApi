using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApi.Models
{
    public class Calculator
    {
        private IOperator _operator;

        public Calculator(IOperator ioperator)
        {
            _operator = ioperator;
        }

        public double Calculate(double a, double b)
        {
            return _operator.ExecuteOperation(a, b);
        }
    }
}
