CREATE FUNCTION EmployeeDetails (@Eid AS int)
RETURNS TABLE
AS
RETURN
(
   SELECT t1.EmployeeID, t2.FirstName AS 'Name', 
   t1.Title, (SELECT count(Employeeid) FROM HumanResources.Employee
   WHERE Managerid = @Eid) AS 'Number of Employees' FROM    
   HumanResources.Employee t1
   JOIN Person.Contact t2 ON t1.ContactID = t2.ContactID WHERE   
   t1.EmployeeID = @Eid
   GROUP BY t2.FirstName, t1.EmployeeID, t1.title
)


/*==============================================================================*/


SELECT * FROM EmployeeDetails(16)