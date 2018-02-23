using System;

namespace ApiBenchmark.Models
{
    public class SalesOrderHeaderDetail
    {
        public virtual int SalesOrderID { get; set; }
        public virtual byte RevisionNumber { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual DateTime? ShipDate { get; set; }
        public virtual byte Status { get; set; }
        public virtual bool OnlineOrderFlag { get; set; }
        public virtual string SalesOrderNumber { get; set; }
        public virtual string PurchaseOrderNumber { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual int CustomerID { get; set; }
        public virtual int? SalesPersonID { get; set; }
        public virtual int? TerritoryID { get; set; }
        public virtual int BillToAddressID { get; set; }
        public virtual int ShipToAddressID { get; set; }
        public virtual int ShipMethodID { get; set; }
        public virtual int? CreditCardID { get; set; }
        public virtual string CreditCardApprovalCode { get; set; }
        public virtual int? CurrencyRateID { get; set; }
        public virtual decimal SubTotal { get; set; }
        public virtual decimal TaxAmt { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual decimal TotalDue { get; set; }
        public virtual string Comment { get; set; }
        public virtual Guid rowguid { get; set; }
        public virtual DateTime HeaderModifiedDate { get; set; }
        public virtual int SalesOrderDetailID { get; set; }
        public virtual string CarrierTrackingNumber { get; set; }
        public virtual short OrderQty { get; set; }
        public virtual int ProductID { get; set; }
        public virtual int SpecialOfferID { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual decimal UnitPriceDiscount { get; set; }
        public virtual decimal LineTotal { get; set; }
        public virtual DateTime DetailModifiedDate { get; set; }
    }
}