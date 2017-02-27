using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    class ElektronischesBellen : IBellverhalten
    {
        public string bellen()
        {
            return "Elektronisches wau wau";
        }
    }
}
