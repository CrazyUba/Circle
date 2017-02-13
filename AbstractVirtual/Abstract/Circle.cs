using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Circle : GeometricForm
    {
        public override void drawAbstract()
        {
            Console.WriteLine("Circle: drawAbstract");
        }

        public override void drawVirtual()
        {
            Console.WriteLine("Circle: drawVirtual");
        }
    }
}
