using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    public delegate void TickHandler(int a);

    internal class Clock
    {
        public event TickHandler Tick;

        public void Start()
        {
            for (int i = 1; i <= 60; i++)
            {
                if (i % 10 == 0)
                {
                    if(Tick != null) Tick.Invoke(i);
                }
            }
        }
    }
}
