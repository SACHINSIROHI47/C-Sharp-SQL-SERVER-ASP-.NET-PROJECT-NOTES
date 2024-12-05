CREATE TABLE ADDRESS
(
AddressID int not null,
AddressLine1 nvarchar(60) not null,
AddressLine2 nvarchar(60) null,
StateProvinceID int not null,
PostalCode nvarchar(15)
)