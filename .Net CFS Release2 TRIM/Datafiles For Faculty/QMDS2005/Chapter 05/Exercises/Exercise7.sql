WITH
XMLNAMESPACES (' http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ProductModelManuInstructions' AS pd ) 
SELECT ProductModelID 
FROM Production.ProductModel WHERE 
Instructions.exist('/pd:root/pd:Location[@LocationID=10]' ) = 1
