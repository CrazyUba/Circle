using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{

    public delegate void PrintFunction(int a);

    class Clock
    {
        public void Start(PrintFunction printFunction)
        {
            for (int i = 1; i <= 60; i++)
            {
                if(i%10 == 0)
                {
                    if (printFunction != null)
                        printFunction.Invoke(i);
                }
            }
        }
    }
}
