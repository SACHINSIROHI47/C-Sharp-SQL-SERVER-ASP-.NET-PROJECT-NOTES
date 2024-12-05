CREATE XML SCHEMA COLLECTION CustomerSchemaCollection AS 
'<schema xmlns="http://www.w3.org/2001/XMLSchema">
      <element name="CustomerName" type="string"/>
      <element name="City" type="string"/>
</schema>' 

DROP TABLE CustDetails

CREATE TABLE CustDetails
(
CustID int,
CustDetail XML (CustomerSchemaCollection)
)
INSERT INTO CustDetails
VALUES(2,'<CustomerName>Abrahim Jones</CustomerName><City>Selina</City>')


