using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Configuration !!!!!!!! Now, there should be no reason to modify the used classes (just for extensions)
                Store store = new Store(new PaymentAdapterFactory());   // e.g.: Working with different factorys (e.g.: Peak/OffPeak)
                store.Order(PaymentType.Card);                          // Card or Paypal, ...
                Console.ReadKey();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
