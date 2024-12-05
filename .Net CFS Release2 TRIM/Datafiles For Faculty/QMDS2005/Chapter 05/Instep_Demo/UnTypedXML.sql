CREATE TABLE CustDetails
(
CUST_ID int,
CUST_DETAILS XML
)

INSERT INTO CustDetails VALUES (2, '<Customer Name="Abrahim Jones" City="Selina" />')
INSERT INTO CustDetails VALUES(2, convert(XML,'<Customer Name="Abrahim Jones" City="Selina" />'))
INSERT INTO CustDetails VALUES(4, cast('<Customer Name="Abrahim Jones" City="Selina" />' as XML))


