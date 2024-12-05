-- TO CREATE TRANSACTION

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

BEGIN TRANSACTION

BEGIN TRY

UPDATE HumanResources.Employee
SET Title = 'Marketing Manager'
WHERE EmployeeID = 13

UPDATE HumanResources.EmployeeDepartmentHistory
SET EndDate = getDate()
WHERE EmployeeID = 13 and EndDate = NULL

INSERT INTO HumanResources.EmployeeDepartmentHistory
VALUES(13, 4, 1, getDate(), NULL, getDate())

COMMIT TRANSACTION
SELECT 'TRANSACTION COMMITTED'
END TRY

BEGIN CATCH
ROLLBACK TRANSACTION

END CATCH

-- TO VERIFY
select * from HumanResources.EmployeeDepartmentHistory where EmployeeID = 13 

select * from HumanResources.Employee where EmployeeID = 13
