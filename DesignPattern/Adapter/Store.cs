using ExternalLib;
using System;

namespace AdapterWithoutPattern
{
    public enum Payment
    {
        PayPal,
        Card
    };

    public class Store
    {
        public void Order(Payment payment)
        {
            Console.WriteLine("Verify order");

            if (payment == Payment.Card)
            {
                PaymentCard paymentCard = new PaymentCard();
                paymentCard.ExecutePayment();
            }
            else if (payment == Payment.PayPal)
            {
                PaymentPayPal paymentPayPal = new PaymentPayPal();
                paymentPayPal.Pay();
            }

        }
    }
}
