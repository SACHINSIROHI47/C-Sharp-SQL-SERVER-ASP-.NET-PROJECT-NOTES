CREATE TABLE Sales.DeliverySchedule
(ScheduleID int IDENTITY(1, 1) PRIMARY KEY,
ScheduleDate DateTime,
DeliveryRoute int,
DeliveryDriver nvarchar(20),
DeliveryList Xml)

INSERT INTO Sales.DeliverySchedule
VALUES
(GetDate(), 3, 'Bill', 
'<?xml version="1.0" ?>
<DeliveryList xmlns="http://schemas.adventure works.com/DeliverySchedule">
       <Delivery SalesOrderID="43659">
			<CustomerName>Steve Schmidt</CustomerName>
			<Address>6126 North Sixth Street, Rockhampton</Address>
       </Delivery>
       <Delivery SalesOrderID="43660">
			<CustomerName>Tony Lopez</CustomerName>
			<Address>6445 Cashew Street, Rockhampton</Address>
       </Delivery>
</DeliveryList>')

SELECT DeliveryDriver, DeliveryList.query
	('declare namespace ns="http://schemas.adventure works.com/DeliverySchedule"; ns:DeliveryList/ns:Delivery/ns:CustomerName') as 'Customer Names'
FROM Sales.DeliverySchedule


SELECT DeliveryList.value
	('declare namespace ns="http://schemas.adventure works.com/DeliverySchedule";
     (ns:DeliveryList/ns:Delivery/ns:Address)[1]', 'nvarchar(100)') DeliveryAddress
FROM Sales.DeliverySchedule


SELECT DeliveryDriver
FROM Sales.DeliverySchedule
WHERE DeliveryList.exist
	('declare namespace ns="http://schemas.adventure works.com/DeliverySchedule";
     /ns:DeliveryList/ns:Delivery[@SalesOrderID=43659]') = 1




