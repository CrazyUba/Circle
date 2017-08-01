using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13InnerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(DoWork);
            t.Start();
            t.Wait();
            Console.WriteLine("End of main thread");
        }

        static void DoWork()
        {
            Console.WriteLine("Starting DoWork");

            Task t2 = new Task(DoInnerWork, TaskCreationOptions.AttachedToParent);
            t2.Start();

            Thread.Sleep(1000);
            Console.WriteLine("End of DoWork");
        }

        static void DoInnerWork()
        {
            Console.WriteLine("Starting DoInnerWork");
            Thread.Sleep(1000);
            Console.WriteLine("End of DoInnerWork");
        }
    }
}
