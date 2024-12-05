SELECT SalesOrderID, MIN(LineTotal) as 'Minimum' , MAX(LineTotal) as 'Maximum'
FROM Sales.SalesOrderDetail
WHERE LineTotal > 5000
GROUP BY SalesOrderID
