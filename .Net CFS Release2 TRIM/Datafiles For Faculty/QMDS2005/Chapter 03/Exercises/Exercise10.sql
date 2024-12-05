SELECT SalesOrderID, Name, Convert(Char(10), OrderDate, 103) as 'Order Date' 
FROM Sales.SalesOrderHeader s JOIN Sales.SalesTerritory t 
ON t.TerritoryID = s.TerritoryID