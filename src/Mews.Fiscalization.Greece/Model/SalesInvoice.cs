﻿using Mews.Fiscalization.Core.Model;
using System;

namespace Mews.Fiscalization.Greece.Model
{
    public class SalesInvoice : Invoice
    {
        public SalesInvoice(
            InvoiceHeader header,
            LocalInvoiceParty issuer,
            ISequentialEnumerableStartingWithOne<NonNegativeRevenue> revenueItems,
            InvoiceParty counterpart,
            INonEmptyEnumerable<NonNegativePayment> payments)
            : base(header, issuer, revenueItems, payments, counterpart)
        {
            if (counterpart == null)
            {
                throw new ArgumentNullException(nameof(counterpart));
            }
        }
    }
}
