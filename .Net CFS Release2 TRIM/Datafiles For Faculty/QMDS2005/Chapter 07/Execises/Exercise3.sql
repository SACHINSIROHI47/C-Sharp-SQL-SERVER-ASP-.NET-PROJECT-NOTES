CREATE FUNCTION Sales.DisplayCardNumber(@SalesOrderID int) RETURNS nvarchar(25)
AS
BEGIN
	DECLARE @ret nvarchar(25)
	SELECT @ret = CardNumber
	FROM Sales.SalesOrderHeader s JOIN Sales.CreditCard c
	ON s.CreditCardID = c.CreditCardID
	WHERE SalesOrderID = @SalesOrderID
	IF (@ret IS NULL)
	SET @ret = 0
	RETURN @ret
END



/*************************************************************************/



SELECT SalesOrderID, 'Credit Card Number' = Sales.DisplayCardNumber(SalesOrderID) FROM Sales.SalesOrderHeader
