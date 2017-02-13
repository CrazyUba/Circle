using System;
using ExternalLib;

namespace Adapter
{
    public class PaymentCardAdapter : IPaymentProviderAdapter
    {
        public void Pay()
        {
            try
            {
                PaymentCard paymentCard = new PaymentCard();
                paymentCard.ExecutePayment();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
