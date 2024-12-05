BEGIN TRANSACTION TR1
BEGIN TRY
UPDATE Person.Contact 
SET EmailAddress='jolyn@yahoo.com' 
WHERE ContactID = 1070
‘Statement 1
UPDATE HumanResources.EmployeeAddress SET AddressID = 32533 
WHERE EmployeeID = 1
COMMIT TRANSACTION TR1
‘Statement 2
SELECT 'Transaction Executed'
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION TR1
SELECT 'Transaction Rollbacked'
END CATCH
