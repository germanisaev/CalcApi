using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApi.Models
{
    public interface IOperator
    {
        double ExecuteOperation(double a, double b);
    }
}
