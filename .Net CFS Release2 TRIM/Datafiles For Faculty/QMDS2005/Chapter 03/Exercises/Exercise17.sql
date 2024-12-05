SELECT CardNumber FROM Sales.CreditCard Where CreditCardID = 
(SELECT CreditCardID FROM Sales.ContactCreditCard Where 
ContactID = (SELECT ContactID FROM Person.Contact Where FirstName = 'Catherine' and LastName = 'Abel'))
