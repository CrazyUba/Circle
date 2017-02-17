using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(2, 3));
            Console.WriteLine(calc.Add(4.5f, 5.7f));
            // Console.WriteLine(calc.Add(4.5, 5.7)); // Error: Cannot convert double to float => Solution: Generic method


            //Console.WriteLine(calc.AddGeneric(4.5, 5.7));

        }
    }
}
