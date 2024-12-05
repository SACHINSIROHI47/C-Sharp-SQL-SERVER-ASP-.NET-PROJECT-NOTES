SELECT 'Order Number' = SalesOrderID, 'Total Due' = TotalDue, 
'Day of Order' = DATEPART(dd, OrderDate), 'Week Day' = DATENAME(dw, OrderDate) 
FROM Sales.SalesOrderHeader
