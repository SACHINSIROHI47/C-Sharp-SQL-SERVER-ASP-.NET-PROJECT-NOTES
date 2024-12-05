SELECT SalesOrderID, Name FROM Sales.SalesOrderHeader s
JOIN Sales.SalesTerritory t ON s.TerritoryID = t.TerritoryID WHERE DATENAME(mm, OrderDate) = 'May' and DATEPART (yy, OrderDate)=2004
