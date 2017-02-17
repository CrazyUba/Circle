using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            clock.Start(
                delegate (int a)
                {
                    Console.WriteLine("Anonymous method: " + a);
                }
            );

            clock.Start(delegate (int a) { Console.WriteLine("Second anonymous method: " + a); });
        }
    }
}
