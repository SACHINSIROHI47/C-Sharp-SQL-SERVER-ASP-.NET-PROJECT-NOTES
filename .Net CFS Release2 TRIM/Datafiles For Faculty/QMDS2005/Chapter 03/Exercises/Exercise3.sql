SELECT 'Order ID' = h.SalesOrderID, 'Product ID'= d.ProductID, 
'Order Date' = OrderDate 
FROM Sales.SalesOrderHeader h join Sales.SalesOrderDetail d 
       ON h.SalesOrderID = d.SalesOrderID
