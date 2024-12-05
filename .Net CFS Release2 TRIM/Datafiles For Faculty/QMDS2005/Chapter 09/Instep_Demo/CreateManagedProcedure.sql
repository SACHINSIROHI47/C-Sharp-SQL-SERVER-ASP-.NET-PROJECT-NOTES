sp_configure CLR_ENABLED, 1;
GO 
RECONFIGURE;
GO



CREATE ASSEMBLY ConvertXMLAssembly FROM 
'C:\ConvertXML\ConvertXML\bin\Debug\ConvertXML.dll' WITH PERMISSION_SET = EXTERNAL_ACCESS


CREATE PROCEDURE clrproc(@XmlData as XML, @filename as nvarchar(30))
AS EXTERNAL NAME
ConvertXMLAssembly.[CLRStoredProcedure.XMLProc].SaveXML


declare @p xml
set @p = (SELECT ProductID, Name, ListPrice FROM Production.Product FOR XML AUTO, ELEMENTS, ROOT('Catalog'))
EXEC clrproc @p, 'D:\Catalog.Xml'

