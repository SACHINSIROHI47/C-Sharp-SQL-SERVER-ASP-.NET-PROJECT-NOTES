SP_FULLTEXT_DATABASE ENABLE

CREATE FULLTEXT CATALOG CAT3 AS DEFAULT

CREATE FULLTEXT INDEX ON Sales.Store(Name) KEY INDEX PK_Store_CustomerID

Select * from Sales.Store Where FreeText (Name, 'Bike')

Select * from Sales.Store Where Contains (Name, '"Bike Store"')