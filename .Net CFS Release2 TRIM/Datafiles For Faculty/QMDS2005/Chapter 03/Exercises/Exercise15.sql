SELECT SalesOrderID, SalesOrderDetailID, LineTotal FROM 
Sales.SalesOrderDetail WHERE LineTotal >ALL
(SELECT LineTotal FROM Sales.SalesOrderDetail WHERE SalesOrderID = 43662)
