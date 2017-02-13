using ExternalLib;

namespace Adapter
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
