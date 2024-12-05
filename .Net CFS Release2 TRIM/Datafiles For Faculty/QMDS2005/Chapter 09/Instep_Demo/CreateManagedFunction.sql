CREATE ASSEMBLY GetLongDateAssembly FROM 'C:\GetLongDateAssembly\GetLongDateAssembly\bin\Debug\GetLongDateAssembly.dll'
WITH PERMISSION_SET = UNSAFE



CREATE FUNCTION GetLongDate(@d as DateTime) 
RETURNS nVarchar(50)
AS EXTERNAL NAME GetLongDateAssembly.[DateUtilities.UserDefinedFunctions].GetLongDate


SELECT EmployeeID, dbo.GetLongDate(birthdate) as ‘BirthDate’ 
FROM HumanResources.Employee
