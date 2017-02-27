using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    class LautesBellen : IBellverhalten
    {
        public string bellen()
        {
            return "Lautes bellen";
        }
    }
}
