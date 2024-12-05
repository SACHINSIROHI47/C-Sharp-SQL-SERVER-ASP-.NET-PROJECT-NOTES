/* Create temporary table 
********************************/


CREATE TABLE Temp
(
ProductID int,
AttChangeCost money,
AttTime datetime
)


/* Create the update trigger on the ProductCostHistory
********************************************************/


CREATE TRIGGER updTrigger ON [Production].[ProductCostHistory] INSTEAD OF UPDATE 
AS
BEGIN
DECLARE @PID AS int
DECLARE @COST AS money
SELECT @pid = ProductID, @cost = StandardCost FROM Deleted
INSERT INTO Temp VALUES(@pid, @cost, getdate())
SELECT 'Sorry you can not change the price of a Product'
END


/* Verify the update trigger on the ProductCostHistory
*************************************************************/


UPDATE [Production].[ProductCostHistory]
SET StandardCost = 55
WHERE ProductID = 707


/*Database engine will display the following message:
‘Sorry you can not change the price of a Product’ */
