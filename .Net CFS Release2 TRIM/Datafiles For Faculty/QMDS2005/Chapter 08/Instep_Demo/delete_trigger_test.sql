INSERT INTO [AdventureWorks].[HumanResources].[Department]([Name],[GroupName])
     VALUES('TestDept','Testing')
select * from HumanResources.Department
delete HumanResources.Department where DepartmentID = 18