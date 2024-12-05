/* Enabe the Full-Text Search 
********************************/

sp_fulltext_database enable


/* Create a Default Full-Text Catalog 
***************************************/

CREATE FULLTEXT CATALOG Cat2 AS DEFAULT



/* Creating a Full-Text Index
*******************************/

CREATE FULLTEXT INDEX ON Person.Address (AddressLine1) KEY INDEX AK_Address_rowguid


/* Search the Data by Using the CONTAINS Predicate
***************************************************/

SELECT * FROM Person.Address WHERE CONTAINS (AddressLine1, 'Santa NEAR drive')