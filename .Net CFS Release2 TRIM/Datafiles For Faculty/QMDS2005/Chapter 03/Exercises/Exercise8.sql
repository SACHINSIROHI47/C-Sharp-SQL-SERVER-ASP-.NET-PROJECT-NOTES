SELECT c.CountryRegionCode, TerritoryID FROM Sales.SalesTerritory s RIGHT OUTER JOIN Sales.CountryRegionCurrency c on s.CountryRegionCode = c.CountryRegionCode