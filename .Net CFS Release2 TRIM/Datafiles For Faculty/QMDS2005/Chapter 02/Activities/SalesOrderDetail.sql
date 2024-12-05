SELECT SalesOrderID, ProductID, 'Average Order Quantity' =  avg(OrderQty) FROM Sales.SalesOrderDetail
GROUP BY ProductID, SalesOrderID
