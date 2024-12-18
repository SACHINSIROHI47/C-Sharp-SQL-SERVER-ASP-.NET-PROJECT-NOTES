CREATE TABLE CustomDetails
(
Cust_ID int,
Cust_Details xml
)

INSERT INTO CustomDetails VALUES(1, 
'<?xml version="1.0"?> <Customer Name="Stephen Jones" 
City="Jersey" />')
INSERT INTO CustomDetails VALUES(2, 
'<?xml version="1.0"?> <Customer Name="Abrahim Jones" 

City="Selina" />')
INSERT INTO CustomDetails VALUES(3, 
'<?xml version="1.0"?> <Customer Name="James Stephen" 

City="NJ" />')
INSERT INTO CustomDetails VALUES(4, 
'<?xml version="1.0"?> <Customer Name="Ron Williams" 

City="Selina" />')
INSERT INTO CustomDetails VALUES(5, 
'<?xml version="1.0"?> <Customer Name="Don Simpson" 

City="Selina" />')
INSERT INTO CustomDetails VALUES(6, 
'<?xml version="1.0"?> <Customer Name="Leonardo John" City="NJ" />')


UPDATE CustomDetails SET Cust_Details.modify('
insert attribute Type{"Credit"} as first
into (/Customer)[1]')

UPDATE CustomDetails SET Cust_Details.modify ('
replace value of(Customer/@Type)[1] with "Cash"') WHERE Cust_ID = 3

UPDATE CustomDetails SET Cust_Details.modify (
'delete(/Customer/@City)[1]')




