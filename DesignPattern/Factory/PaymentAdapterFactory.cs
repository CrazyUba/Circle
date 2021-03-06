﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal static class PaymentAdapterFactory
    {
        public static IPaymentProviderAdapter Create(PaymentType paymentType)
        {
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
            return paymentProviderAdapter;

        }
    }
}
