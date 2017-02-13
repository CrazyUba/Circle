using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterWithoutPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Store store = new Store();
                store.Order(Payment.PayPal);
                Console.ReadKey();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
