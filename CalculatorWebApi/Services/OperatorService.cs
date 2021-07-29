using CalculatorWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApi.Services
{
    public interface IOperatorService
    {
        double Add(Calculate model);
        double Substract(Calculate model);
        double Divide(Calculate model);
        double Multiply(Calculate model);
    }
    public class OperatorService: IOperatorService
    {
        //Executes the strategy
        public double Add(Calculate model)
        {
            Calculator oprt = new Calculator(new AddOperator());
            return oprt.Calculate(model.a, model.b);
        }

        public double Substract(Calculate model)
        {
            Calculator oprt = new Calculator(new SubtractOperator());
            return oprt.Calculate(model.a, model.b);
        }

        public double Divide(Calculate model)
        {
            Calculator oprt = new Calculator(new DivisionOperator());
            return oprt.Calculate(model.a, model.b);
        }

        public double Multiply(Calculate model)
        {
            Calculator oprt = new Calculator(new MultiplyOperator());
            return oprt.Calculate(model.a, model.b);
        }
        
    }
}
