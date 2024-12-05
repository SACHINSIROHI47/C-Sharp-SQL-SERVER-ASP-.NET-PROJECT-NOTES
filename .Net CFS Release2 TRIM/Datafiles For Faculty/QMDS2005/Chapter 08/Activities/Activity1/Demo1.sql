-- to create the view

Create view vwEmployee as
select e.EmployeeID as 'Employee ID',
h.FirstName as 'Employee Name', g.Name as 'Department Name', 
e.HireDate as 'Date of Joining',  j.AddressLine1 as 'Employee Address'
from HumanResources.Employee as e
join HumanResources.EmployeeDepartmentHistory as f on 
e.EmployeeID = f.EmployeeID join HumanResources.Department as g
on f.DepartmentID = g.DepartmentID 
join Person.Contact as h on e.ContactID = h.ContactID
join HumanResources.EmployeeAddress as i on 
e.EmployeeID = i.EmployeeID join Person.Address as j
on i.AddressID = j.AddressID

-- TO CREATE THE TRIGGER FOR SOLUTION

CREATE TRIGGER trgEmployee ON vwEmployee 
INSTEAD OF 
UPDATE AS
BEGIN
UPDATE Person.Contact SET FirstName = (SELECT [Employee Name] FROM Inserted)
WHERE ContactID = (SELECT ContactID FROM HumanResources.Employee
WHERE EmployeeID = (SELECT [Employee ID] FROM Inserted))
UPDATE HumanResources.EmployeeDepartmentHistory SET DepartmentID = (
SELECT DepartmentID from HumanResources.Department where Name = (select 
[Department Name] from inserted)) where EmployeeID = (SELECT [Employee ID] from 
Inserted)
END

-- FOR VERIFICATION

UPDATE vwEmployee 
SET [Employee Name] = 'Ron', [Department Name] = 'Sales' 
WHERE [Employee ID] = 51


SELECT * FROM vwEmployee WHERE [Employee ID] = 51
