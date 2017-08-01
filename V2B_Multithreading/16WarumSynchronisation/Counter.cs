using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16WarumSynchronisation
{
    internal class Counter
    {
        private int count = 0;

        public int Value
        {
            get { return count; }
        }
        
        public void Increment()
        {
            count++;
        }
    }
}
