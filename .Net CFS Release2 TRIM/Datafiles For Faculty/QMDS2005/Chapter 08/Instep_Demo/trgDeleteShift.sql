CREATE TRIGGER trgDeleteShift
 ON HumanResources.Shift
AFTER 
DELETE
AS 
print 'Deletion successful'

--to verify, insert a record in the Shift table and then delete it

INSERT INTO [AdventureWorks].[HumanResources].[Shift]
           ([Name]
           ,[StartTime]
           ,[EndTime])
     VALUES  ('MidDay','1900-01-01 11:00:00.000','1900-01-01 19:00:00.000')

Select * from [AdventureWorks].[HumanResources].[Shift]

DELETE FROM HumanResources.Shift
where Name = 'MidDay'