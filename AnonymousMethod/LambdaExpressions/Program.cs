using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.Start((x) => { Console.WriteLine("Lambda: " + x); });

            // Overview (Basic concept: delegate!)
            //      Classic 
            clock.Start(printFunc);     // Disadvantage: Extra method

            //      Anonymous Function
            clock.Start(delegate (int b) { Console.WriteLine("Anonymous way: " + b); });

            //      Lambda Expression
            clock.Start((c) => { Console.WriteLine("Lambda way: " + c); });


            // printFunc;       => This is a delegate (pointer of a function)
            // printFunc(55);   => Calling the method



        }

        private static void printFunc(int a)
        {
            Console.WriteLine("Classic way: " + a);
        }

    }
}
