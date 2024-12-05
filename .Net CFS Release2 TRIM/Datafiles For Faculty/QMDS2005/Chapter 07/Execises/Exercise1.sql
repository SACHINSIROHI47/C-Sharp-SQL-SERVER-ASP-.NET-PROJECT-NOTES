DECLARE @avg_rate int
SELECT @avg_rate = AVG(rate) FROM HumanResources.EmployeePayHistory
SELECT * FROM HumanResources.EmployeePayHistory
WHERE rate < @avg_rate
GO
