SELECT c.CustomerID, TerritoryID, AccountNumber, CustomerType, AddressLine1, City, 
StateProvinceID, PostalCode
FROM Sales.Customer c JOIN Sales.CustomerAddress ca
ON c.CustomerID = ca.CustomerID
JOIN Person.Address a
ON ca.AddressID = a.AddressID
FOR XML PATH('Customer')
