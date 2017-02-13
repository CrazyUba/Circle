using System;
using ExternalLib;

namespace Factory
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
