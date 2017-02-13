using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Store store = new Store();
                store.Order(PaymentType.PayPal);
                Console.ReadKey();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
