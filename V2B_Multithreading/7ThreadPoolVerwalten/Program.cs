using System;
using System.Threading;
using System.Threading.Tasks;

namespace _7ThreadPoolVerwalten
{
    class Program
    {
        static void Main(string[] args)
        {
            int worker;
            int completion;
            int minThreads;
            int dummy;

            ThreadPool.GetAvailableThreads(out worker, out completion);
            ThreadPool.GetMinThreads(out minThreads, out dummy);

            Console.WriteLine($"workerthreads: {worker}, completionthreads: {completion}");
            Console.WriteLine($"minThreads: {minThreads}");

            ThreadPool.SetMinThreads(50, 8);
            ThreadPool.GetMinThreads(out minThreads, out dummy);
            Console.WriteLine($"minThreads: {minThreads}");

            Task[] tasks = new Task[worker];
            for (int i = 0; i < worker; i++)
            {
                tasks[i] = new Task(() => {
                    Console.WriteLine($"Starting thread ...{Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(20000);
                });
                tasks[i].Start();
            }
//            Task.WaitAll(tasks);
            Console.ReadKey();
        }
    }
}
