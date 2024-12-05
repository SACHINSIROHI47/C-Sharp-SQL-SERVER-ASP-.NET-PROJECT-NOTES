SP_FULLTEXT_DATABASE ENABLE

CREATE FULLTEXT CATALOG CAT4 AS DEFAULT

CREATE FULLTEXT INDEX ON Sales.CreditCard(CardType) KEY INDEX AK_CreditCard_CardNumber

Select * from Sales.CreditCard Where Contains (CardType, '"SuperiorCard"')
