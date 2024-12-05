SELECT 'Sales Order ID' = SalesOrderID, 'Average Value' = Avg(LineTotal) 
FROM Sales.SalesOrderDetail
GROUP BY SalesOrderID 
HAVING AVG(LineTotal) > 5000
