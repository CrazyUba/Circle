using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17MonitoringLockObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var k1 = new KontoLockedByMonitor();
            //var k2 = new KontoLockedByMonitor();

            var k1 = new KontoWithLockObject();
            var k2 = new KontoWithLockObject();

            Task t1 = new Task(() => {
                for (int i = 0; i < 1000000; i++)
                {
                    k1.UeberweiseBetragNach(i, k2);
                }
            });

            t1.Start();

            Task t2 = new Task(() => {
                for (int i = 0; i < 1000000; i++)
                {
                    k2.UeberweiseBetragNach(i, k1);
                }
            });

            t2.Start();
            Task.WaitAll(t1, t2);

            Console.WriteLine(k1.Guthaben);
            Console.WriteLine(k2.Guthaben);
        }
    }
}
