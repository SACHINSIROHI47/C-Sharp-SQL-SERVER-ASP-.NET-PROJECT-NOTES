SELECT ProductID, UnitPrice, LineTotal FROM Sales.SalesOrderDetail
WHERE ProductID IN (777, 774)
ORDER BY ProductID, UnitPrice, LineTotal
COMPUTE SUM(UnitPrice), SUM(LineTotal) BY ProductID
COMPUTE Sum(UnitPrice), Sum(LineTotal)
