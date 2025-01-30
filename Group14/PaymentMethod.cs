using System;
using System.ComponentModel;

namespace Group14
{

    public enum PaymentMethod
    {
        [Description("Cash")] Cash,
        [Description("Credit Card")] CreditCard,
        [Description("Direct Debit")] DirectDebit,

    }
}