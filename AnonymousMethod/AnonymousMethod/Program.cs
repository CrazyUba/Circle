using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.Tick += new TickHandler(tickHandler);
            clock.Start();
            Console.ReadKey();
        }

        private static void tickHandler(int a)
        {
            Console.WriteLine(a);
        }
    }
}
