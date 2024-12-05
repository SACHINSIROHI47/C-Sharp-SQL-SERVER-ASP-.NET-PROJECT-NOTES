-- to craete second trigger on 
CREATE TRIGGER trgDeleteShift1 ON HumanResources.Shift
AFTER 
DELETE
AS 
print 'Second Trigger on Deletion'

-- to set priority
sp_settriggerorder 'HumanResources.trgDeleteShift1', 'FIRST', 'DELETE'
RETURN

-- to insert a new record
INSERT INTO [AdventureWorks].[HumanResources].[Shift]
           ([Name]
           ,[StartTime]
           ,[EndTime]
           )
     VALUES
           ('MidNight','1900-01-01 17:00:00.000','1900-01-01 02:00:00.000')

-- to check the records
Select * from [AdventureWorks].[HumanResources].[Shift]

-- to delete the new record and verify the output
DELETE FROM HumanResources.Shift
where Name = 'MidNight'