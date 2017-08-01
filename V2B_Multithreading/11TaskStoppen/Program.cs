using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11TaskStoppen
{

    class FuncParameter
    {
        public CancellationToken CancellationToken { get; set; }
        public int Value { get; set; }
        public FuncParameter(int value, CancellationToken cancellationToken)
        {
            this.CancellationToken = cancellationToken;
            this.Value = value;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Func<object, double> func = (x) => {
                for (int i = 0; i < 4; i++)
                {
                    Thread.Sleep(1000);
                    if (((FuncParameter)x).CancellationToken.IsCancellationRequested)
                    {
                        Console.WriteLine("Thread cancelled");
                        return 0;
                    }
                }
                
                return (double)(((FuncParameter)x).Value * ((FuncParameter)x).Value);
            };

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            FuncParameter funcPar = new FuncParameter(4, cancellationTokenSource.Token);

            Task<double> task = new Task<double>(func, funcPar);
            Console.WriteLine("Starting task ...");
            task.Start();
            Console.WriteLine("Task started. Waiting ...");
            Thread.Sleep(2000);
            cancellationTokenSource.Cancel();
            task.Wait();
            Console.WriteLine($"Result: {task.Result}");
       }
    }
}
