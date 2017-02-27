using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    class Stoffhund : Hund
    {
        public Stoffhund(IBellverhalten bellverhalten) : base(bellverhalten)
        {
        }
    }
}
