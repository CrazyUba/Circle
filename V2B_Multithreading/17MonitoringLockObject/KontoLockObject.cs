using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17MonitoringLockObject
{
    internal class KontoWithLockObject
    {
        decimal guthaben = 0;
        static object monitor = new object();

        public decimal Guthaben {
            get { return guthaben; }
        }

        public void UeberweiseBetragNach(decimal betrag, KontoWithLockObject anderesKonto)
        {
            lock(monitor)
            {
                anderesKonto.guthaben += betrag;
                this.guthaben -= betrag;
            }
        }

    }
}
