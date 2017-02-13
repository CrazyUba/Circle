using ExternalLib;

namespace Factory
{
    class PaymentPayPalAdapter : IPaymentProviderAdapter
    {
        public void Pay()
        {
            PaymentPayPal paymentPayPal = new PaymentPayPal();
            paymentPayPal.Pay();
        }
    }
}
