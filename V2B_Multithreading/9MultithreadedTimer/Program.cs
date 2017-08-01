using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9MultithreadedTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main thread {Thread.CurrentThread.ManagedThreadId}");
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += (s, e) => {
                Console.WriteLine($"Timer thread {Thread.CurrentThread.ManagedThreadId}");
            };
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("1");
                Thread.Sleep(2000);
            }
        }
    }
}
