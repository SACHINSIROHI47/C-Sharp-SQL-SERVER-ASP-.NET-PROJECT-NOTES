SELECT SalesOrderID, TaxAmt FROM Sales.SalesOrderHeader  
WHERE TotalDue < 2000 
ORDER BY TotalDue ASC