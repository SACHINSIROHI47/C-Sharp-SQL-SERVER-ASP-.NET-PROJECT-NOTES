CREATE NONCLUSTERED INDEX Idx_SalesOrderId_SalesOrderDetailId
ON Sales.SalesOrderDetail(SalesOrderId, SalesOrderDetailId)
