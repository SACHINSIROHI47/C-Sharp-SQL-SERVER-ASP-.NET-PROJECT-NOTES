SELECT SalesOrderID, TotalDue FROM Sales.SalesOrderHeader WHERE TotalDue > (SELECT Avg(TotalDue) FROM Sales.SalesOrderHeader)