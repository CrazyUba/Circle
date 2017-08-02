using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _19Semaphoren
{
    class Program
    {

        static DateTime dt = DateTime.Now;
        static Semaphore sem = new Semaphore(3, 3);

        static void SecondThread()
        {
            sem.WaitOne();
            Console.WriteLine(dt - DateTime.Now);
            Thread.Sleep(1000);
            sem.Release();
        }



        static void Main(string[] args)
        {
            Task[] tasks = new Task[5];
            for (int i = 0; i < 5; i++)
            {
                tasks[i] = new Task(SecondThread);
                //Thread.Sleep(100);
                tasks[i].Start();
            }

            Task.WaitAll(tasks);
        }
    }
}
