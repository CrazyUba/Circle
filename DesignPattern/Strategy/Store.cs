using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   
    public class Store
    {
        readonly IPaymentAdapterFactory _paymentAdapterFactory;
        public Store(IPaymentAdapterFactory paymentAdapterFactory)
        {
            _paymentAdapterFactory = paymentAdapterFactory;
        }


        public void Order(PaymentType paymentType)
        {
            Console.WriteLine("Verify order");

            IPaymentProviderAdapter paymentProviderAdapter = _paymentAdapterFactory.Create(paymentType);

            paymentProviderAdapter.Pay();
            
        }
    }
}
