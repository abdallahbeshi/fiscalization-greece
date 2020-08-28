﻿using System;
using System.Xml.Serialization;

namespace Mews.Fiscalization.Greece.Dto.Xsd
{
    [Serializable]
    public enum InvoiceType
    {
        [XmlEnum("1.1")]
        SalesInvoice,
        [XmlEnum("1.2")]
        SalesInvoiceIntraCommunitySupplies,
        [XmlEnum("1.3")]
        SalesInvoiceThirdCountrySupplies,
        [XmlEnum("1.4")]
        SalesInvoiceSaleOnBehalfOfThirdParties,
        [XmlEnum("1.5")]
        SalesInvoiceClearanceOfSalesOnBehalfOfThirdParties,
        [XmlEnum("1.6")]
        SalesInvoiceSupplementalAccountingSourceDocument,
        [XmlEnum("2.1")]
        ServiceRenderedInvoice,
        [XmlEnum("2.2")]
        IntraCommunityServiceRenderedInvoice,
        [XmlEnum("2.3")]
        ThirdCountryServiceRenderedInvoice,
        [XmlEnum("2.4")]
        ServiceRenderedInvoiceSupplementalAccountingSourceDocument,
        [XmlEnum("3.1")]
        ProofOfExpenditureNonLiableIssuer,
        [XmlEnum("3.2")]
        ProofOfExpenditureDenialOfIssuanceByLiableIssuer,
        [XmlEnum("5.1")]
        CreditInvoiceAssociated,
        [XmlEnum("5.2")]
        CreditInvoiceNonAssociated,
        [XmlEnum("6.1")]
        SelfDeliveryRecord,
        [XmlEnum("6.2")]
        SelfSupplyRecord,
        [XmlEnum("7.1")]
        ContractIncome,
        [XmlEnum("8.1")]
        RentsIncome,
        [XmlEnum("8.2")]
        SpecialRecordAccommodationTaxCollectionPaymentReceipt,
        [XmlEnum("11.1")]
        RetailSalesReceipt,
        [XmlEnum("11.2")]
        ServiceRenderedReceipt,
        [XmlEnum("11.3")]
        SimplifiedInvoice,
        [XmlEnum("11.4")]
        RetailSalesCreditNote,
        [XmlEnum("11.5")]
        RetailSalesReceiptOnBehalfOfThirdParties,
        [XmlEnum("13.1")]
        ExpensesDomesticForeignRetailTransactionPurchases,
        [XmlEnum("13.2")]
        DomesticForeignRetailTransactionProvision,
        [XmlEnum("13.3")]
        SharedUtilityBills,
        [XmlEnum("13.4")]
        Subscriptions,
        [XmlEnum("13.30")]
        RetailSelfDeclaredEntityAccountingSourceDocuments,
        [XmlEnum("13.31")]
        DomesticForeignRetailSalesCreditNote,
        [XmlEnum("14.1")]
        InvoiceIntraCommunityAcquisitions,
        [XmlEnum("14.2")]
        InvoiceThirdCountryAcquisitions,
        [XmlEnum("14.3")]
        InvoiceIntraCommunityServicesReceipt,
        [XmlEnum("14.4")]
        InvoiceThirdCountryServicesReceipt,
        [XmlEnum("14.5")]
        Efka,
        [XmlEnum("14.30")]
        SelfDeclaredEntityAccountingSourceDocuments,
        [XmlEnum("14.31")]
        DomesticForeignCreditNote,
        [XmlEnum("15.1")]
        ContractExpense,
        [XmlEnum("16.1")]
        RentExpense,
        [XmlEnum("17.1")]
        Payroll,
        [XmlEnum("17.2")]
        Amortisations,
        [XmlEnum("17.3")]
        OtherIncomeAdjustmentRegularisationEntriesAccountingBase,
        [XmlEnum("17.4")]
        OtherIncomeAdjustmentRegularisationEntriesTaxBase,
        [XmlEnum("17.5")]
        OtherExpenseAdjustmentRegularisationEntriesAccountingBase,
        [XmlEnum("17.6")]
        OtherExpenseAdjustmentRegularisationEntriesTaxBase
    }
}