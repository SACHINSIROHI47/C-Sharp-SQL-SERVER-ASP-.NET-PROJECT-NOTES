/*1.	Create a stored procedure 
*******************************************/


CREATE PROCEDURE HTTPProc
AS
BEGIN
SELECT tbl1.NAME, tbl2.FirstName, tbl2.EmailAddress
FROM Sales.Store AS tbl1 JOIN Sales.StoreContact AS tbl3 
ON tbl1.CustomerID = tbl3.CustomerID JOIN Person.Contact AS tbl2
ON tbl3.ContactID = tbl2.ContactID 
END


/*2.	create an endpoint 
****************************************/

CREATE ENDPOINT DetailsStore
STATE = STARTED AS HTTP( 
PATH = '/stores', 
AUTHENTICATION = (INTEGRATED ), 
PORTS = ( CLEAR ), SITE = 'SERVER' ) 
FOR SOAP ( 
WEBMETHOD 'StoreDetail' (name='AdventureWorks.dbo.HTTPProc', SCHEMA=STANDARD ), 
WSDL = DEFAULT, SCHEMA = STANDARD, DATABASE = 'AdventureWorks', NAMESPACE = 'http://tempUri.org/' ); 
