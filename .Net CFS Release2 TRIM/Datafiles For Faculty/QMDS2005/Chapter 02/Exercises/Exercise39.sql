SELECT EmployeeID, Month = DATENAME (mm, HireDate), Year = DATENAME (yy, HireDate)
FROM HumanResources.Employee
