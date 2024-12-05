SELECT ProductID, Sum(LineTotal) as Total FROM Sales.SalesOrderDetail 
GROUP BY ProductID HAVING Sum(LineTotal) > 10000
