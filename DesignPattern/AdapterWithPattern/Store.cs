using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
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

            IPaymentProviderAdapter paymentProviderAdapter;

            if (paymentType == PaymentType.Card)
            {
                paymentProviderAdapter = new PaymentCardAdapter();
            }
            else if (paymentType == PaymentType.PayPal)
            {
                paymentProviderAdapter = new PaymentPayPalAdapter();
            }
            else
            {
                throw new Exception("Invalid Paymenttype");
            }

            paymentProviderAdapter.Pay();
            
        }
    }
}
