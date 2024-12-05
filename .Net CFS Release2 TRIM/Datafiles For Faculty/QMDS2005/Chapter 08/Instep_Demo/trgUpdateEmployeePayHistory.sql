CREATE TRIGGER trgUpdateEmployeePayHistory
ON HumanResources.EmployeePayHistory
FOR UPDATE
AS
	IF UPDATE (Rate)
	BEGIN

DECLARE @AvgRate float
SELECT @AvgRate = avg(Rate)
FROM HumanResources.EmployeePayHistory
IF(@AvgRate > 20)
BEGIN
	PRINT 'The average value of rate cannot be more than 20'
     	ROLLBACK TRANSACTION
END
END


-- for verification

update HumanResources.EmployeePayHistory
set Rate = Rate + 5
