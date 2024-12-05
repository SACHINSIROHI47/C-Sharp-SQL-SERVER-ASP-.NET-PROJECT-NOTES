SELECT * FROM Production.Product 
WHERE ProductNumber = 'RA-2345'


CREATE UNIQUE NONCLUSTERED INDEX Product_ProductNumber
ON Production.Product (ProductNumber)


SELECT * FROM Production.Product 
WHERE ProductNumber = 'RA-2345'
