CREATE ASSEMBLY ZipAssembly 
FROM 'C:\ZipCode\ZipCode\bin\Debug\ZipCode.dll'
WITH PERMISSION_SET = UNSAFE


CREATE TYPE ZipCode 
EXTERNAL NAME ZipAssembly.ZipCode 


CREATE TABLE ManagedEmployee
(
Name nvarchar(20),
Zip ZipCode
)


INSERT INTO ManagedEmployee
VALUES ( 'Peter', 'NY')
INSERT INTO ManagedEmployee
VALUES ( 'John', 'CA')


SELECT Name, convert(nvarchar(20), Zip)as 'Zip Code' 
From ManagedEmployee


DECLARE @zip ZipCode
SET @zip = 'CA'
PRINT convert(NVARCHAR(20), @zip)
GO
