using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle = new Circle();
                circle.drawAbstract();
                circle.drawAlreadyImplemented();
                circle.drawVirtual();

                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
