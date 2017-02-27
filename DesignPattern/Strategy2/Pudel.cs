using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    class Pudel: Hund
    {
        public Pudel(IBellverhalten bellverhalten) : base(bellverhalten)
        {

        }
    }
}
