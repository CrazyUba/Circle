using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    class Dackel : Hund
    {
        public Dackel(IBellverhalten bellverhalten) : base(bellverhalten)
        {

        }
    }
}
