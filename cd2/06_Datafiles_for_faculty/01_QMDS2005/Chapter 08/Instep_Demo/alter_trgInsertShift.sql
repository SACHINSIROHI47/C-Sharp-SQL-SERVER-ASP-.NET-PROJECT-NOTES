ALTER TRIGGER HumanResources.trgInsertShift
ON HumanResources.Shift
FOR INSERT
AS
	DECLARE @ModifiedDate datetime
	SELECT @ModifiedDate = ModifiedDate	FROM Inserted
	IF (@ModifiedDate != getdate())
	BEGIN
RAISERROR (’The modified date is not the current date. The transaction cannot be processed.',10, 1)
		ROLLBACK TRANSACTION
	END
     RETURN
