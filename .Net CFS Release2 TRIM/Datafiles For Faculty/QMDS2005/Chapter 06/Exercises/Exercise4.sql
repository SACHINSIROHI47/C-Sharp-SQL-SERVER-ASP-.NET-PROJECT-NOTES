UPDATE vwSalesOrderDetail
SET OrderQty = 2
FROM vwSalesOrderDetail 
WHERE SalesOrderID = 43659

UPDATE vwSalesOrderDetail
SET TerritoryID = 4
FROM vwSalesOrderDetail 
WHERE SalesOrderID = 43659
