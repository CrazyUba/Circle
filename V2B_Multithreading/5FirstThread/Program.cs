using System;
using System.Threading;

namespace _5FirstThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread( () => {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("2");
                }
                Console.WriteLine("*** Second thread ready ***");
            });

            t.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("1");
            }

            t.Join();       // Main thread waits!!! for thread 't'
            Console.WriteLine("*** Main thread ready ***");
        }
    }
}
