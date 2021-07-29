using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApi.Models
{
    public static class Factory
    {
        
            public static T CreateInstance<T>() where T : new()
            {
                return new T();
            }
        
    }
}
