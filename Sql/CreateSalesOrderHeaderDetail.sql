USE [AdventureWorks2017]
GO

/****** Object:  View [Sales].[SalesOrderHeaderDetail]    Script Date: 2018/02/23 0:08:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [Sales].[SalesOrderHeaderDetail]  
AS  
SELECT 
	SalesOrderHeader.SalesOrderID,
	SalesOrderHeader.RevisionNumber,
	SalesOrderHeader.OrderDate,
	SalesOrderHeader.DueDate,
	SalesOrderHeader.ShipDate,
	SalesOrderHeader.Status,
	SalesOrderHeader.OnlineOrderFlag,
	SalesOrderHeader.SalesOrderNumber,
	SalesOrderHeader.PurchaseOrderNumber,
	SalesOrderHeader.AccountNumber,
	SalesOrderHeader.CustomerID,
	SalesOrderHeader.SalesPersonID,
	SalesOrderHeader.TerritoryID,
	SalesOrderHeader.BillToAddressID,
	SalesOrderHeader.ShipToAddressID,
	SalesOrderHeader.ShipMethodID,
	SalesOrderHeader.CreditCardID,
	SalesOrderHeader.CreditCardApprovalCode,
	SalesOrderHeader.CurrencyRateID,
	SalesOrderHeader.SubTotal,
	SalesOrderHeader.TaxAmt,
	SalesOrderHeader.Freight,
	SalesOrderHeader.TotalDue,
	SalesOrderHeader.Comment,
	SalesOrderHeader.rowguid,
	SalesOrderHeader.ModifiedDate as HeaderModifiedDate,
	SalesOrderDetail.SalesOrderDetailID,
	SalesOrderDetail.CarrierTrackingNumber,
	SalesOrderDetail.OrderQty,
	SalesOrderDetail.ProductID,
	SalesOrderDetail.SpecialOfferID,
	SalesOrderDetail.UnitPrice,
	SalesOrderDetail.UnitPriceDiscount,
	SalesOrderDetail.LineTotal,
	SalesOrderDetail.ModifiedDate as DetailModifiedDate
FROM 
	Sales.SalesOrderHeader
	INNER JOIN Sales.SalesOrderDetail
		ON SalesOrderHeader.SalesOrderID = SalesOrderDetail.SalesOrderID
GO


