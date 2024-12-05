CREATE FUNCTION Sales.IndividualDetails (@format nvarchar(9))
RETURNS @tbl_Individual Table
(CustomerID int Primary Key, Name nvarchar(100))
AS
BEGIN
If (@format = 'LONGNAME')
	INSERT @tbl_Individual
	SELECT Cu.CustomerID, FirstName +' '+ LastName
	FROM Person.Contact AS C
	JOIN Sales.Individual AS I
ON C.ContactID = I.ContactID
	JOIN Sales.Customer AS Cu
	ON I.CustomerID = Cu.CustomerID
	WHERE Cu.CustomerType = 'I'
	ORDER BY LastName, FirstName 
	ELSE IF (@format = 'SHORTNAME')
	INSERT @tbl_Individual
	SELECT Cu.CustomerID, LastName
	FROM Person.Contact AS C
	JOIN Sales.Individual AS I
	ON C.ContactID = I.ContactID
	JOIN Sales.Customer AS Cu
	ON I.CustomerID = Cu.CustomerID
	WHERE Cu.CustomerType = 'I'
	ORDER BY LastName
RETURN
END



/*******************************************************************/



SELECT * FROM Sales.IndividualDetails('LONGNAME')
SELECT * FROM Sales.IndividualDetails('SHORTNAME')
