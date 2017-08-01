using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10TaskParameter
{
    class Program
    {

        static int DoWork(object o) {
            Console.WriteLine($"DoWork-Thread-ID: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            return ((int)o) * 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Main-Thread-ID: {Thread.CurrentThread.ManagedThreadId}");
            Task<int> task = new Task<int>(DoWork, 21);
            task.Start();
            Console.WriteLine($"Main-Thread-ID: {Thread.CurrentThread.ManagedThreadId}");
            task.Wait();
            Console.WriteLine($"Result of task : {task.Result}");

        }
    }
}
