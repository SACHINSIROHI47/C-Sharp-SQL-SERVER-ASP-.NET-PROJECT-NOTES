SELECT SalesOrderID, CreditCardID FROM Sales.SalesOrderHeader 
WHERE CreditCardID IN (SELECT CreditCardID FROM Sales.CreditCard WHERE ExpYear = 2007)
