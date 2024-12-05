SELECT EmployeeID, Title FROM HumanResources.Employee WHERE
EmployeeID IN (SELECT EmployeeID FROM HumanResources.EmployeePayHistory WHERE Rate>40)
