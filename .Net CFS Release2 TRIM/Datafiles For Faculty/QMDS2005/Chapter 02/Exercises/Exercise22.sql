SELECT TOP 5 SalesOrderID FROM Sales.SalesOrderHeader 
WHERE Datepart(yyyy,OrderDate) = 2001 ORDER BY TotalDue DESC
