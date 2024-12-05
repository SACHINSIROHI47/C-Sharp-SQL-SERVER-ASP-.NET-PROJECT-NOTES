/*Generate the customerId for the new store by storing the details in the Customer table as follows:*/

INSERT INTO Sales.Customer VALUES (7,'S', DEFAULT, DEFAULT)


/*Store the details of the new store in the Store table as follows:
===================================================================*/

INSERT INTO Sales.Store VALUES(29484, 'Car store', 285,
'<StoreSurvey xmlns="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/StoreSurvey">
  <AnnualSales>350000</AnnualSales>
  <AnnualRevenue>35000</AnnualRevenue>
  <BankName>International Bank</BankName>
  <BusinessType>BM</BusinessType>
  <YearOpened>1980</YearOpened>
  <Specialty>Road</Specialty>
  <SquareFeet>7500</SquareFeet>
  <Brands>AW</Brands>
  <Internet>T1</Internet>
  <NumberEmployees>7</NumberEmployees>
</StoreSurvey>', DEFAULT, DEFAULT)
