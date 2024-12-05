CREATE TRIGGER trgInsertShift
ON HumanResources.Shift
FOR INSERT
AS
				DECLARE @ModifiedDate datetime
	SELECT @ModifiedDate = ModifiedDate	FROM Inserted
				IF (@ModifiedDate != getdate())
				BEGIN
Print 'The modified date should be the current date.  Hence, cannot insert.'
					ROLLBACK TRANSACTION
				END
RETURN

--to verify use the following statement

INSERT INTO [AdventureWorks].[HumanResources].[Shift]
           ([Name]
           ,[StartTime]
           ,[EndTime]
           ,[ModifiedDate])
     VALUES
           ('MidDay','1900-01-01 11:00:00.000','1900-01-01 19:00:00.000','1900-01-01 23:00:00.000')