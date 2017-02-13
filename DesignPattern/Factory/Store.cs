using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public enum PaymentType
    {
        PayPal,
        Card
    };

    public class Store
    {
        public void Order(PaymentType paymentType)
        {
            Console.WriteLine("Verify order");

            IPaymentProviderAdapter paymentProviderAdapter = PaymentAdapterFactory.Create(paymentType);

            paymentProviderAdapter.Pay();
            
        }
    }
}
