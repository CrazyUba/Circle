using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.Start(printFunction1);
            clock.Start(printFunction2);
        }

        private static void printFunction1(int a)
        {
            Console.WriteLine("Func 1: " + a);
        }

        private static void printFunction2(int a)
        {
            Console.WriteLine("Func 2: " + a);
        }

    }
}
