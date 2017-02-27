using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    abstract class Hund
    {
        IBellverhalten _bellverhalten;

        public Hund(IBellverhalten bellverhalten)
        {
            _bellverhalten = bellverhalten;
        }

        public void setBellverhalten(IBellverhalten bellverhalten)
        {
            _bellverhalten = bellverhalten;
        }

        public string bellen()
        {
            return _bellverhalten.bellen();
        }
    }
}
