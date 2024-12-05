/* Create an update trigger on the HumanResources.EmployeePayHistory
***********************************************************************/


CREATE TRIGGER updTrigger ON HumanResources.EmployeePayHistory FOR UPDATE 
AS
BEGIN
DECLARE @rate AS money
DECLARE @frq AS int
SELECT @rate = Rate, @frq = PayFrequency FROM Inserted
SELECT @rate * @frq * 30 AS 'Monthly Salary'
END


/* To verify the trigger, execute the following statement to update the salary for employee with EmployeeID as 160 
********************************************************************************/

UPDATE HumanResources.EmployeePayHistory
SET Rate = Rate + 5
WHERE EmployeeID = 160


/*The output will show the monthly salary after the change is done.*/
