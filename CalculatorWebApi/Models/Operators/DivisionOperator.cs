using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApi.Models
{
    public class DivisionOperator : IOperator
    {
        public double ExecuteOperation(double a, double b)
        {
            return a / b;
        }
    }
}
