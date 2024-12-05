SELECT EmployeeID, upper(Title) AS Designation,datediff(yy,Birthdate,getdate()) AS Age 
FROM HumanResources.Employee WHERE Title='Marketing Manager' OR Title='Marketing Specialist'
