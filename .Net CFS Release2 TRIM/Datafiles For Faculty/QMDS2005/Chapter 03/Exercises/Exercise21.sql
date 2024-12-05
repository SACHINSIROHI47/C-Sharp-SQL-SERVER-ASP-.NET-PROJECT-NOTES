SELECT AverageRate FROM Sales.CurrencyRate 
Where CurrencyRateDate = '2004-07-01' and ToCurrencyCode = (SELECT CurrencyCode FROM Sales.Currency Where Name = 'Australian Dollar')
