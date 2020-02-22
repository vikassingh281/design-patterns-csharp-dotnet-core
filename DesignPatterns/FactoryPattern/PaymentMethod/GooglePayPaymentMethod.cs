﻿using DesignPatterns.FactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern.PaymentMethod
{
    public class GooglePayPaymentMethod : PaymentMethodFactory
    {
        public override PaymentMethodType PaymentMethodType => PaymentMethodType.GooglePay;
    }
}