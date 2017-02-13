using ExternalLib;

namespace Strategy
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
