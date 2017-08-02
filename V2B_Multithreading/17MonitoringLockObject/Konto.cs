using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17MonitoringLockObject
{
    internal class KontoLockedByMonitor
    {
        decimal guthaben = 0;
        static object monitor = new object();

        public decimal Guthaben {
            get { return guthaben; }
        }

        public void UeberweiseBetragNach(decimal betrag, KontoLockedByMonitor anderesKonto)
        {
            Monitor.Enter(monitor);
            try
            {
                anderesKonto.guthaben += betrag;
                this.guthaben -= betrag;
            }
            finally
            {
                Monitor.Exit(monitor);
            }
        }

    }
}
