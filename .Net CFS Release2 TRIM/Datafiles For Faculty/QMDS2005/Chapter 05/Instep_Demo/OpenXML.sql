DECLARE @Doc int
DECLARE @XMLDoc nvarchar(1000)
SET @XMLDoc = N'<ROOT>
<Customer CustomerID="JH01" ContactName="John Henriot">
   <Order OrderID="1001" CustomerID="JH01" 
          OrderDate="2006-07-04T00:00:00">
      <OrderDetail ProductID="11" Quantity="12"/>
      <OrderDetail ProductID="22" Quantity="10"/>
   </Order>
</Customer>
<Customer CustomerID="SG01" ContactName="Steve Gonzlez">
   <Order OrderID="1002" CustomerID="SG01" 
          OrderDate="2006-08-16T00:00:00">
      <OrderDetail ProductID="32" Quantity="3"/>
   </Order>
</Customer>
</ROOT>'

EXEC sp_xml_preparedocument @Doc OUTPUT, @XMLDoc

SELECT *
FROM openxml (@Doc, '/ROOT/Customer/Order/OrderDetail',1)
      WITH (CustomerID  varchar(10) '../../@CustomerID',
            ContactName varchar(20) '../../@ContactName',
			OrderID int '../@OrderID',
			OrderDate datetime '../@OrderDate',
			ProdID int '@ProductID',
			Quantity int)

EXEC sp_xml_removedocument @Doc
