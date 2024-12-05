CREATE PROC PayRateIncrease @EmpID int, @percent float
AS
BEGIN
	DECLARE @maxRate float
	DECLARE @RevisedRate float
	DECLARE @PayFre int
	IF EXISTS (SELECT * 
FROM HumanResources.EmployeePayHistory
WHERE Datediff(mm, RateChangeDate, getdate()) > 6 AND EmployeeID = @EmpID)
	BEGIN
	   SELECT @maxRate = Rate 
	   FROM HumanResources.EmployeePayHistory
	   WHERE EmployeeID = @EmpID
	   IF (@maxRate * @percent > 200.00)
	   BEGIN
           PRINT 'Rate of an employee cannot be greater than 200.00'
	   END
	   ELSE
	   BEGIN
         SELECT @RevisedRate = Rate, @PayFre = PayFrequency 
	      FROM HumanResources.EmployeePayHistory
	      WHERE EmployeeID = @EmpID
	      SET @RevisedRate = @RevisedRate * @percent 
	      INSERT INTO HumanResources.EmployeePayHistory
	      VALUES (@EmpID, getdate(), @RevisedRate, @PayFre, 
         getdate())
	   END
	END
END


/*==================================================================================/*


EXEC PayRateIncrease 6, 2
