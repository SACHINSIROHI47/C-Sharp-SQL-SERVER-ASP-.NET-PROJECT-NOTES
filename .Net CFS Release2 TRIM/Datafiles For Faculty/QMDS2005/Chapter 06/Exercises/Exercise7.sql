CREATE FULLTEXT INDEX ON Sales.Currency(Name) KEY INDEX AK_Currency_Name

Select * from Sales.Currency Where FreeText (Name, '"New" And "Dollar"')
