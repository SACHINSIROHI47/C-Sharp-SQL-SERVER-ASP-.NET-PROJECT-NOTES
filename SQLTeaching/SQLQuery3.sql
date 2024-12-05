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

CREATE DATABASE FRIEND

USE FRIEND
go

CREATE TABLE Friends
(
FriendID int identity(1,1) PRIMARY KEY,
NameOfFriend VARCHAR(50) NOT NULL,
Address varchar(60) NULL
)

DROP TABLE Friends

select * from Friends

insert Friends(NameOfFriend,Address)
values('Manish Sharnma','22 d Saket, Meerut')

insert Friends(NameOfFriend,Address)
values('Ajay Vats','22 E Shashtri Nagar, Meerut')

insert Friends(NameOfFriend,Address)
values('Reema Jain','45 Rajpur Road, Dehradun')

insert Friends(Address)
values('22 E Shashtri Nagar, Meerut')

insert Friends(NameOfFriend)
values('Geeta Jain')


USE MASTER

--System Procedure (function)

sp_addlogin @loginame='USER1',@password='user1007',defdb='FRIEND'


sp_addlogin 'USER1','user1007','FRIEND'
go

USE FRIEND
sp_grantdbaccess 'USER1'
uioo
USE AdventureWorks
sp_grantdbaccess 'USER1'

USE master
sp_grantlogin 'RGPGADMIN-PC\ENOSH'

sp_defaultdb 'RGPGADMIN-PC\ENSOH','master'
		




