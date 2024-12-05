CREATE DATABASE Vendor
go

USE Vendor
go

CREATE TABLE VList
(
VendorName varchar(20)
)

-- to give ownership of teh database to the sa

ALTER DATABASE AdventureWorks SET TRUSTWORTHY ON
ALTER DATABASE Vendor SET TRUSTWORTHY ON
ALTER AUTHORIZATION ON DATABASE::[AdventureWorks] TO [SA];
ALTER AUTHORIZATION ON DATABASE::[Vendor] TO [SA];

-- to create master encryption key
USE AdventureWorks
CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'niit#1234'
USE Vendor 
CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'niit#1234'

-- to enable Service Broker 
ALTER DATABASE AdventureWorks SET ENABLE_BROKER
ALTER DATABASE Vendor SET ENABLE_BROKER

