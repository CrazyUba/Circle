using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _18ReaderWriterLock
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBEROFREADTASKS = 20;
            CommonText commonText = new CommonText();

            Task[] tasks = new Task[NUMBEROFREADTASKS + 1];
            ThreadPool.SetMinThreads(NUMBEROFREADTASKS, 8);

            DateTime dt = DateTime.Now;

            tasks[NUMBEROFREADTASKS] = new Task(() => {
                for (int i = 0; i < 500; i++)
                {
                    commonText.Write("Test" + i);
                    Thread.Sleep(1);
                }
                
            });
            tasks[NUMBEROFREADTASKS].Start();

            for (int i = 0; i < NUMBEROFREADTASKS; i++)
            {
                tasks[i] = new Task(() =>
                {
                    for (int j = 0; j < 1000000; j++)
                    {
                        commonText.Read();
                    }
                    
                });
                tasks[i].Start();
            }

            Task.WaitAll(tasks);

            Console.WriteLine(DateTime.Now - dt);
            Console.WriteLine(commonText.WriteCounter);
            Console.WriteLine(commonText.ReadCounter);




        }

    }
}
