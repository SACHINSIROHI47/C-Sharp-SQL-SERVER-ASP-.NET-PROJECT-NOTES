USE AdventureWorks
GO
sp_configure CLR_ENABLED, 1
GO 
RECONFIGURE
GO


CREATE ASSEMBLY SpouseDet
FROM 'C:\SpouseDetails\SpouseDetails\bin\Debug\SpouseDetails.dll'


CREATE TYPE Spouse_Details EXTERNAL NAME
SpouseDet.[SpouseDetails]


CREATE TABLE Spouse_Det 
(
Employee_id int,
SpouseDetails Spouse_Details
)


INSERT INTO Spouse_Det VALUES (1,'Samantha;12/12/1980')


SELECT Employee_id, convert(nvarchar(60), SpouseDetails) 
AS 'Spouse Details' FROM Spouse_Det


