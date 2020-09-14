﻿using Mews.Fiscalization.Greece.Model.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mews.Fiscalization.Greece.Model
{
    public class InvoiceRecordDetail
    {
        public InvoiceRecordDetail(PositiveInt lineNumber, Amount netValue, TaxType taxType, VatExemption? vatExemption, Amount vatAmount, DiscountOption discountOption, IEnumerable<InvoiceRecordIncomeClassification> invoiceRecordIncomeClassification)
        {
            LineNumber = lineNumber ?? throw new ArgumentNullException(nameof(lineNumber));
            NetValue = netValue ?? throw new ArgumentNullException(nameof(netValue));
            TaxType = taxType;
            VatAmount = vatAmount ?? throw new ArgumentNullException(nameof(vatAmount));
            DiscountOption = discountOption;
            VatExemption = vatExemption;
            InvoiceRecordIncomeClassification = invoiceRecordIncomeClassification ?? throw new ArgumentNullException(nameof(invoiceRecordIncomeClassification));

            if (taxType == TaxType.Vat0 && !vatExemption.HasValue)
            {
                throw new ArgumentException($"{nameof(VatExemption)} must be specified when TaxType is {taxType}");
            }

            if (invoiceRecordIncomeClassification.Count() == 0)
            {
                throw new ArgumentException($"Minimal count of {nameof(invoiceRecordIncomeClassification)} is 1.");
            }
        }

        public PositiveInt LineNumber { get; }

        public Amount NetValue { get; }

        public TaxType TaxType { get; }

        public VatExemption? VatExemption { get; }

        public Amount VatAmount { get; }

        public DiscountOption DiscountOption { get; }

        public IEnumerable<InvoiceRecordIncomeClassification> InvoiceRecordIncomeClassification { get; }
    }
}
