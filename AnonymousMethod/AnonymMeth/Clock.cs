using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymMeth
{
    public delegate void PointerArrayToMethods(int a);  // Declaration: Array of pointers to methods of type "void <method> (int)"

    class Clock
    {
        public void Start(PointerArrayToMethods objPointerArrayToMethods)   // Object of array of pointers to methods of type "void <method> (int)"
        {
            for (int i = 1; i <= 60; i++)
            {
                if (i % 10 == 0)
                {
                    if (objPointerArrayToMethods != null)
                        objPointerArrayToMethods.Invoke(i);        // call registered methods
                }

                    
            }
        }    


    }
}
