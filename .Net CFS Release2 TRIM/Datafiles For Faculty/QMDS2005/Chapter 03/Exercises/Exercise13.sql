SELECT SalesOrderID FROM Sales.SalesOrderHeader where TerritoryID = (SELECT TerritoryID FROM Sales.SalesTerritory WHERE Name = 'Northeast')