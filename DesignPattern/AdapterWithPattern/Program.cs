using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Store store = new Store();
                store.Order(PaymentType.Card);
                Console.ReadKey();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
