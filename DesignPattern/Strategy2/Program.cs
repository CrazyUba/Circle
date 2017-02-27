using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pudel pudel = new Pudel(new LautesBellen());
                Dackel dackel = new Dackel(new LeisesBellen());
                Stoffhund stoffhund = new Stoffhund(new ElektronischesBellen());

                Console.WriteLine("Pudel: " + pudel.bellen());
                Console.WriteLine("Dackel: " + dackel.bellen());
                Console.WriteLine("Stoffhund: " + stoffhund.bellen());

                pudel.setBellverhalten(new LeisesBellen());
                Console.WriteLine("Pudel: " + pudel.bellen());

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
