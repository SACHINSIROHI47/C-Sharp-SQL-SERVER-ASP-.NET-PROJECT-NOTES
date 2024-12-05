SELECT Description, ProductDescriptionID
FROM Production.ProductDescription
WHERE CONTAINS (Description, ' "top" near "line"' )
