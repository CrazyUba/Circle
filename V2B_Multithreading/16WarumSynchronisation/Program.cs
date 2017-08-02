using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16WarumSynchronisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Task[] tasks = new Task[2];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = new Task(
                    () =>
                    {
                        for (int j = 0; j < 10000000; j++)
                        {
                            counter.Increment();
                        }
                    });
                tasks[i].Start();
            }
            Task.WaitAll(tasks);
            
            Console.WriteLine(counter.Value); // Erwartetes Ergebnis: 20000000. Tatsächlich: < 20000000! Thread teilen sich eine gemeinsame Ressource => Vorsicht!!!
            // Lösung z.B. mit der Klasse 'Interlocked'
        }
    }
}
