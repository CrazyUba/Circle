using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorGeneric<int> calcInt = new CalculatorGeneric<int>();
            Console.WriteLine(calcInt.Add(4, 5));

            CalculatorGeneric<double> calcDouble = new CalculatorGeneric<double>();
            Console.WriteLine(calcDouble.Add(4.3, 5.5));
        }
    }
}
