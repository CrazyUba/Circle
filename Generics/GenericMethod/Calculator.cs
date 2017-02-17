using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    public class Calculator
    {
        public int Add (int a, int b)
        {
            return a + b;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }

        public S AddGeneric<S, T, U>(T a, U b) where S: new() 
        {
            return new S();
        }
    }
}
