CREATE TRIGGER trgDeleteDepartment
ON HumanResources.Department
FOR delete
AS
       PRINT 'Deletion of Department is not allowed'
       ROLLBACK TRANSACTION
RETURN


--for verification
INSERT INTO [AdventureWorks].[HumanResources].[Department]([Name],[GroupName])
     VALUES('TestDept','Testing')

DELETE FROM HumanResources.Department
where Name = 'TestDept'