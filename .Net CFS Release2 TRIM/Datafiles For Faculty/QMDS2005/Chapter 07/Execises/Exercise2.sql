CREATE FUNCTION Sales.CalShipDate(@SalesOrderID int) RETURNS Datetime
AS
BEGIN
	DECLARE @shipDate Datetime
	SELECT @shipDate = ShipDate 
FROM Sales.SalesOrderHeader WHERE SalesOrderID = @SalesOrderID
	IF (@shipDate IS NULL)
	SET @shipDate = 0
	RETURN @shipDate
END


/*************************************************************************/


SELECT SalesOrderID, Sales.CalShipDate(SalesOrderID) AS ShippingDate 
FROM Sales.SalesOrderHeader
