/* 1.	Insert a new record in the Department table.
======================================================= */


INSERT INTO HumanResources.Department VALUES ('Inventory Control', 'Inventory Management', DEFAULT)


/* 2.  Update the employee details to change the department.
=============================================================*/

UPDATE HumanResources.EmployeeDepartmentHistory 
SET DepartmentID = 17
FROM HumanResources.EmployeeDepartmentHistory d, HumanResources.Employee e,
Person.Contact c
WHERE d.EmployeeID = e.EmployeeID AND e.ContactID = c.ContactID
AND c.FirstName = 'Vamsi' AND c.MiddleName = 'N' AND c.LastName = 'Kuppa'

UPDATE HumanResources.EmployeeDepartmentHistory 
SET DepartmentID = 17
FROM HumanResources.EmployeeDepartmentHistory d, HumanResources.Employee e,
Person.Contact c
WHERE d.EmployeeID = e.EmployeeID AND e.ContactID = c.ContactID
AND c.FirstName = 'Susan' AND c.MiddleName = 'W' AND c.LastName = 'Eaton'


/* 3.	Verify that data is inserted and modified.
===================================================*/

SELECT * FROM HumanResources.Department


SELECT DepartmentID FROM HumanResources.EmployeeDepartmentHistory d
JOIN HumanResources.Employee e
ON d.EmployeeID = e.EmployeeID
JOIN Person.Contact c
ON e.ContactID = c.ContactID
WHERE FirstName = 'Vamsi' AND MiddleName = 'N' AND LastName = 'Kuppa'

SELECT DepartmentID FROM HumanResources.EmployeeDepartmentHistory d
JOIN HumanResources.Employee e
ON d.EmployeeID = e.EmployeeID
JOIN Person.Contact c
ON e.Contactid = c.Contactid
WHERE FirstName = 'Susan' AND MiddleName = 'W' AND LastName = 'Eaton' 



