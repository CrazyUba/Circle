using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _6TaskAnlegen
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(() => 
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write(Thread.CurrentThread.ManagedThreadId);
                }
            });

            t.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(Thread.CurrentThread.ManagedThreadId);
            }

            t.Wait();
        }
    }
}
