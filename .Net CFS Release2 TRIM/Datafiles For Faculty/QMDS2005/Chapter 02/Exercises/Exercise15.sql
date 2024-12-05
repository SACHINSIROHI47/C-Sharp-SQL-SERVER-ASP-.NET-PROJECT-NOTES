SELECT 'Order Number' = SalesOrderID, 'Order Date' = OrderDate, Status, 'Total Cost' = TotalDue FROM Sales.SalesOrderHeader 
WHERE OrderDate = '07-01-2001' AND TotalDue > 10000
