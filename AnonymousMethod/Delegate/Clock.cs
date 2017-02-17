using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void PrintDelegateTyp(int a);

    class Clock
    {
        public void Start(PrintDelegateTyp printDelegate)
        {
            for (int i = 1; i <= 60; i++)
            {
                if (i % 10 == 0) printDelegate(i);
            }
        }
    }
}
