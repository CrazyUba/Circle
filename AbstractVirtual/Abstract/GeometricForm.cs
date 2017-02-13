using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class GeometricForm
    {
        public decimal area { get; set; }
        public decimal umfang { get; set; }



        abstract public void drawAbstract();    // must be implemented by subclass

        public void drawAlreadyImplemented()    // can be implemented by subclass
        {
            Console.WriteLine("GeometricForm: drawAlreadyImplemented");
        }

        public virtual void drawVirtual()       // cannot be implemented by subclass
        {
            Console.WriteLine("GeometricForm: drawVirtual");
        }
    }
}
