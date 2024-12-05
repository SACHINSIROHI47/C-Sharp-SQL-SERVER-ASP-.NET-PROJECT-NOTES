Update Purchasing.VendorAddress 
set AddressID = 
(Select AddressID from Person.Address Where AddressLine1 = '4151 Olivera' 
AND City = 'Atlanta')
FROM Purchasing.VendorAddress va, Purchasing.Vendor v
WHERE va.VendorID = v.VendorID
AND v.Name = 'Comfort Road Bicycles'
