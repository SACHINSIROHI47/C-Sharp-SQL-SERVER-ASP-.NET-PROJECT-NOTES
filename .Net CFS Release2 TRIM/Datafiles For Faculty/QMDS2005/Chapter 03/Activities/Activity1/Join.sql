SELECT e.EmployeeID AS 'Employee ID', 
h.FirstName AS 'Employee Name', g.Name AS 'Department Name', 
e.HireDate AS 'Date of Joining',  j.AddressLine1 AS 'Employee Address' FROM HumanResources.Employee AS e
JOIN HumanResources.EmployeeDepartmentHistory AS f ON 
e.EmployeeID = f.EmployeeID JOIN HumanResources.Department AS g
ON f.DepartmentID = g.DepartmentID 
JOIN Person.Contact AS h ON e.ContactID = h.ContactID
JOIN HumanResources.EmployeeAddress AS i ON 
e.EmployeeID = i.EmployeeID JOIN Person.Address AS j
ON i.AddressID = j.AddressID
