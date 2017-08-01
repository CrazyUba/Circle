using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _14LaterTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = new Task<int>(DoWork);
            Task t2 =  t.ContinueWith(DoLaterWork);
            t.Start();
            Task.WaitAll(t, t2);

            Console.WriteLine("Main thread ready");

        }

        static int DoWork()
        {
            Console.WriteLine("Starting DoWork");
            Thread.Sleep(1000);
            Console.WriteLine("End of DoWork");
            return 45;
        }

        static void DoLaterWork(Task<int> t)
        {
            Console.WriteLine("Starting DoLaterWork");
            Thread.Sleep(1000);
            Console.WriteLine(t.Result);
            Console.WriteLine("End of DoLaterWork");
        }
    }
}
