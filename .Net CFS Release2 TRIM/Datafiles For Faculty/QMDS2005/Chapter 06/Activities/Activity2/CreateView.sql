CREATE VIEW vw_Emp_Details 
AS
SELECT e1.EmployeeID, c1.FirstName, 
c1.LastName, e1.Title, c2.FirstName AS [Manager First Name],
c2.LastName AS [Manager Last Name]
FROM HumanResources.Employee e1 INNER JOIN Person.Contact c1
ON e1.ContactID = c1.ContactID INNER JOIN
HumanResources.Employee AS e2
ON e1.ManagerID = e2.EmployeeID 
INNER JOIN Person.Contact AS c2 
ON e2.ContactID = c2.ContactID



SELECT EmployeeID, FirstName, LastName, Title, [Manager First Name], [Manager Last Name] FROM vw_Emp_Details