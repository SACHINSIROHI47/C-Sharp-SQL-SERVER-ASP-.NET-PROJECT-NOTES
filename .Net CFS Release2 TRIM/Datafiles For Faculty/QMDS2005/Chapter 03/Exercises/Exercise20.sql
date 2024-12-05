SELECT SalesOrderID FROM Sales.SalesOrderHeader Where 
CreditCardID in (SELECT CreditCardID FROM Sales.CreditCard Where CardType = 'SuperiorCard')
