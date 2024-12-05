WITH
XMLNAMESPACES (' http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ProductModelManuInstructions' AS pd ) 
UPDATE Production.ProductModel SET
Instructions.modify('delete (/pd:root/pd:Location)[1]' ) 
WHERE ProductModelID = 7
