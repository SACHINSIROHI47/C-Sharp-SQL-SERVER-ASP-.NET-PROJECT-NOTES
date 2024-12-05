CREATE DATABASE SBI

DROP DATABASE SBI

drop DATABASE SBI2

CREATE DATABASE SBI2
ON
(
NAME = SBI2_DAT,
FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SBI2.mdf',
SIZE = 15,
MAXSIZE = 100,
FILEGROWTH = 5
)
LOG ON
(
NAME = SBI2_LOG,
FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SBI2.ldf',
SIZE = 7 ,
MAXSIZE = 35 ,
FILEGROWTH = 1
)
go

USE MASTER

--System Procedure (function)

sp_addlogin @loginame='USER1',@password='user1007',defdb='SBI'


sp_addlogin 'USER1','user1007','SBI'
go

USE SBI
sp_grantdbaccess 'USER1'


USE AdventureWorks
sp_grantdbaccess 'USER1'

USE master
sp_grantlogin 'INDIA\MIKAL'

sp_defaultdb 'INDIA\MIKAL','master'


