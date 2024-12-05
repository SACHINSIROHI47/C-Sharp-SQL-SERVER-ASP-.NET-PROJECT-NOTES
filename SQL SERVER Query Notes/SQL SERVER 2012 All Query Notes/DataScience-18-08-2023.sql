use AdventureWorks2012
select * from HumanResources.Employee
create database data2023
use data2023
create table employee
(
 empcode int,
 empname char(500),
 salary float
)
insert into employee values(102,'Gita',70000.25),(103,'Anil',45000)

select * from employee
select empcode,empname from employee
select * from employee where empcode=102
--delete from employee where empcode=103
--drop table employee

-----create table 
create table employee_info
(
empcode int primary key not null,
empname char(100) not null,
empaddress varchar(600) not null,
comment text null,
dob date not null,
salary money not null,
timeinout time
)
select * from employee_info
insert into employee_info values(1001,'James','Meerut','Good','05-06-2000',80000,'9:00')
insert into employee_info(empcode,empname,empaddress,salary,dob) 
values(1002,'Ram','Delhi',60000,'05-08-2001')

--operator
use AdventureWorks2012
select * from HumanResources.Employee
select * from HumanResources.Employee where JobTitle in('Data Scientist','Design Engineer')
select * from HumanResources.Employee where JobTitle not in('Data Scientist','Design Engineer')
select * from HumanResources.Employee where BusinessEntityID between 1 and 7
select * from HumanResources.Employee where BusinessEntityID not between 1 and 7
_----pattern matcher
--% any character
--_ single character

select * from HumanResources.Employee where JobTitle like 'Data%'	
select * from HumanResources.Employee where JobTitle like '%Scientist'
select * from HumanResources.Employee where JobTitle like 'G%S%'

----------
--first you have to create fulltext search for entire table column search
--right click on the table and select fulltext search option

select * from HumanResources.Employee where  
contains(JobTitle,'"Data Scientist"');


select * from HumanResources.Employee where BusinessEntityID=4
select * from HumanResources.Employee where JobTitle='Data Scientist'

------------------------------------------------------
create table school 
(
Sch_ID int primary key not null,
schoolname char(100) not null,
schoolAddress varchar(500)
)

select * from school
insert into school values(1001,'Delhi Public School','Meerut')
insert into school values(1002,'MPGS','Meerut')
insert into school(Sch_ID,schoolname) values(1003,'Karan Public School')
--drop table school
begin tran
drop table school

begin tran 
delete from school where sch_id=1001

begin tran 
delete from school

--for recover table values
rollback 

--Truncate is fast as compare to delete, also use for delete the values
--it can not be rollback
begin tran
truncate table school

----------------------------
create table product
(
pid int not null,
productname varchar(100) not null,
productprice int default(0)
)
select * from product
select distinct * from product
insert into product(pid,Productname) values (101,'Mouse'),(102,'Monitor')

#---identity use for autogenerate column values
create table product2
(
pid int identity(101,1)primary key not null,
productname varchar(100) not null,
productprice int default(0)
)
insert into product2(Productname) values ('Mouse'),('Monitor')
select * from product2

------------------------------------------
CREATE TABLE BikeParts (
    BikeParts_GUID AS 'R-' + RIGHT(REPLICATE('0', 8) + CONVERT(VARCHAR, BikePart_ID), 10),
    BikePart_ID INT IDENTITY(1, 1),
    BikePart_Name VARCHAR(100)
)
INSERT INTO BikeParts VALUES ('Break Cable')
INSERT INTO BikeParts VALUES ('Seat Cover')
INSERT INTO BikeParts VALUES ('Head Light')
INSERT INTO BikeParts VALUES ('Tail Lamp')

select * from BikeParts

--------------------------------
create table product3
(
pid uniqueidentifier default newid() not null,
productname varchar(100) not null,
)
insert into product3(Productname) values ('Mouse'),('Monitor')
select * from product3

#----------------------------------
create table contactperson2
(
personid int primary key not null,
personname char(50) not null,
mobileno bigint unique
)
--drop table contactperson2
insert into contactperson2 values(102,'James',9589569858)
select * from contactperson2
#-----Create foreign key table 

create table department
(
per_id int foreign key references contactperson2(personid), 
deptname char(100) not null,
designation char(100)
)
insert into department values(102,'It Department','Data Scientist')
SELECT * from department

#-----------Data Relationship or Data Modeling--------
#-------First Table-----
create table studentreg
(
reg int primary key not null,
name char(100) not null,
addrs varchar(500)
)

select * from studentreg
insert into studentreg values(101,'Ram','MRT'),(102,'Gita','Delhi')
#-----Second Table------
create table examform
(
reg int foreign key references studentreg(reg) unique,
rollno char(10) primary key not null,
class char(50),
fees money
)

select * from examform
insert into examform values(101,'R001','B.Com',10000)
insert into examform values(102,'R002','BCA',40000)

#----Third Table--------
create table result
(
 rollno char(10) foreign key references examform(rollno) unique,
 marks float not null,
 div char(50) not null
)

select * from result
insert into result values('R001',80,'Ist Div')
insert into result values('R002',80,'Ist Div')

#--check constraint
create table voting
(
vot_id int primary key not null,
p_name char(200) not null,
age int check(age>=18)
)

select * from voting
insert into voting values(1001,'Anita',15)

select vot_id from voting

select vot_id+ ' ' +age from voting
select CONCAT('Mr./Ms ',p_name) as 'Full Name' from voting
select vot_id as 'Voter ID' from voting

#--------composite primary key----------
create table details
(
candidatename char(200) not null,
dob date not null,
mobno bigint,
primary key (dob,mobno)
)

insert into details values ('james','1-04-2000',9584558747)
select * from details
insert into details values ('james','1-04-2000',9584558789)

--alter key
create table computer
(
productno int,
price money
)

select * from computer
insert into computer values(101,50000)
insert into computer values(102,60000)
insert into computer values(103,45000,'M0001')
--delete from computer 
alter table computer alter column productno int not null
alter table computer add primary key(productno)
--add column 
alter table computer add model varchar(50)
--update
update computer set model='M002' where productno=101


--first check the primary key constraint name into table using sp_help command
--after drop the primary key
sp_help computer

alter table computer drop constraint PK__computer__2D12E19DAC59A0E9 

--add column and after change data types
alter table computer add addres char(200) null

--modify column data types
alter table computer alter column addres varchar(500) null


#--delete primary key when foreign key is linked
--drop table pry,pdetails
--drop table pry
create table pry
(
pid int primary key not null,
productname char(50)
);
select * from pry
insert into pry values(101,'computer')
--you can not update and delete normally
update pry set pid=105
delete from pry where pid=105


sp_help pry

create table pdetails
(
pid int foreign key references pry(pid) on update cascade on delete cascade,
price float,

)
select * from pdetails
insert into pdetails values(101,50000)
sp_help pdetails

--drop foreign key
alter table pdetails drop constraint FK__pdetails__pid__71D1E811

--drop primary key
alter table pry drop constraint PK__pry__DD37D91AEA53A8DC

----Variable is a memory container use for hold values-------
declare @num1 as int
declare @num2 as int
declare @tot as int
set @num1=50
set @num2=60
set @tot=@num1+@num2

print'Addition of two number'+str(@tot)

#---
select * from product
select distinct * from product

use AdventureWorks2012
select top 5 * from humanresources.Employee
select left(loginid,5) from humanresources.Employee
select top 5 sickleavehours from HumanResources.Employee
select top 5 (sickleavehours*1000) as 'Salary' from HumanResources.Employee

--variable and data types
declare @rollno as int
declare @name as char(50)
declare @marks as float
declare @address as varchar(500)
declare @salary as money
set @rollno=101
set @name='James'
set @marks=95.25
set @address='Meerut'
set @salary =65565.23
print 'Roll no is -'+str(@rollno)
print 'Name is -'+@name
print 'Marks is -'+str(@marks)
print 'Address is-'+@address
print 'Salary is- '+str(@salary)

---logic
select * from HumanResources.Employee
select vacationHours from HumanResources.Employee

declare @vacation as int
select @vacation=vacationHours from HumanResources.Employee
select @vacation
select (@vacation*1000)

--------
select * from HumanResources.Employee
select * from HumanResources.Employee where BusinessEntityID !=1
select * from HumanResources.Employee where BusinessEntityID <>1
select * from HumanResources.Employee where BusinessEntityID !<5

select * from HumanResources.Employee where jobtitle like 'D____n%'
select * from HumanResources.Employee where jobtitle like '[ABC]%'
select * from HumanResources.Employee where jobtitle like '[^ABC]%'

#---
select * from HumanResources.Employee where jobtitle like '%-z'

select SUBSTRING('This is computer',1,5) 

SELECT SUBSTRING(col, LEN(SUBSTRING(col, 0, LEN(col) - CHARINDEX ('/', col))) + 1, 
    LEN(col) - LEN(SUBSTRING(col, 0, LEN(col) - CHARINDEX ('/', col))) - LEN(SUBSTRING(
    col, CHARINDEX ('.', col), LEN(col))));

    
create database sampledatabase
drop database sampledatabase

drop database employeedatabase2
-------------you can create single .mdf file also--------
--when you create .mdf only the .ldf file is automatically created
create database employeedatabase2 on primary
(
    NAME = employee_db,
  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\employee_db.mdf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 50MB
)
-----------------------.mdf .ldf--------------
create database employeedatabase2 on primary
(
    NAME = employee_db,
  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\employee_db.mdf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 50MB
)
log on
(
   NAME = employee_log,
  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\employeelog.ldf',
	SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)

--------------------------------------------------------------------------------------
create database mycollege on 
( NAME = college_db,
  FILENAME = 'd:\sqldata\collegedb.mdf',
	SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)
log on
(
   NAME = college,
  FILENAME = 'd:\sqldata\college.ldf',
	SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)


---------add .ndf file after database created------------------------------------------
USE master
GO
ALTER DATABASE employeedatabase2
ADD FILEGROUP employeendfgroup;
GO
ALTER DATABASE employeedatabase2 
ADD FILE 
(
    NAME = employee_ndf_file,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\
	employee_ndf_file.ndf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)TO FILEGROUP employeendfgroup;
GO


-----------------.mdf .ndf .ndf .ldf----------------------------------------------------------

create database employeedatabase on primary
(
    NAME = employee_db,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\
	employee_db.mdf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 50MB
),
FILEGROUP myemployee_nd_group_1
(
    NAME = employee_ndf1,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\
	employee_ndf1.ndf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
),
FILEGROUP myemployee_nd_group_2
(    NAME = employee_ndf2,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\
	employee_ndf2.ndf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)log on
(   NAME = employee_log,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\
	employeelog.ldf',
	SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)


--------------------------------------------------
--Database Files and Filegroups
--Every database has at least two files, a primary file and a transaction log file, and at least 
--one filegroup. A maximum of 32,767 files and 32,767 filegroups can be specified for each database.
--When you create a database, make the data files as large as possible based on the maximum amount 
--of data you expect in the database.
--if the snapshot is created on database so we can not drop the original database
--first we have to drop snapshot
---------------------------------------------------------------------
drop database sales

USE master;
GO
CREATE DATABASE Sales
ON PRIMARY
( NAME = SPri1_dat,
    FILENAME = 'D:\SalesData\SPri1dat.mdf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 15% ),
( NAME = SPri2_dat,
    FILENAME = 'D:\SalesData\SPri2dt.ndf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 15% ),
FILEGROUP SalesGroup1
( NAME = SGrp1Fi1_dat,
    FILENAME = 'D:\SalesData\SG1Fi1dt.ndf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5 ),
( NAME = SGrp1Fi2_dat,
    FILENAME = 'D:\SalesData\SG1Fi2dt.ndf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5 ),
FILEGROUP SalesGroup2
( NAME = SGrp2Fi1_dat,
    FILENAME = 'D:\SalesData\SG2Fi1dt.ndf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5 ),
( NAME = SGrp2Fi2_dat,
    FILENAME = 'D:\SalesData\SG2Fi2dt.ndf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5 )
LOG ON
( NAME = Sales_log,
    FILENAME = 'E:\SalesLog\salelog.ldf',
    SIZE = 5MB,
    MAXSIZE = 25MB,
    FILEGROWTH = 5MB ) ;
GO

-------sapshot read only no log file maintain-------------
----database snapshot is read-only, a log file cannot be specified. In conformance with the
-- syntax, every file in the source database is specified, and filegroups are not specified.

USE master;	
GO
CREATE DATABASE sales_snapshot0600 ON
    ( NAME = SPri1_dat, FILENAME = 'D:\SalesData\SPri1dat_0600.ss'),
    ( NAME = SPri2_dat, FILENAME = 'D:\SalesData\SPri2dt_0600.ss'),
    ( NAME = SGrp1Fi1_dat, FILENAME = 'D:\SalesData\SG1Fi1dt_0600.ss'),
    ( NAME = SGrp1Fi2_dat, FILENAME = 'D:\SalesData\SG1Fi2dt_0600.ss'),
    ( NAME = SGrp2Fi1_dat, FILENAME = 'D:\SalesData\SG2Fi1dt_0600.ss'),
    ( NAME = SGrp2Fi2_dat, FILENAME = 'D:\SalesData\SG2Fi2dt_0600.ss')
AS SNAPSHOT OF Sales ;
GO



--------------where Query----------
use AdventureWorks2012
select * from HumanResources.Employee
select * from HumanResources.Employee where BusinessEntityID=1
select * from HumanResources.Employee where BusinessEntityID between 1 and 5
select * from HumanResources.Employee where BusinessEntityID<=7
select * from HumanResources.Employee where BusinessEntityID!=1
select * from HumanResources.Employee where JobTitle='Data Scientist' or JobTitle='Design Engineer' 
select * from HumanResources.Employee where JobTitle in('Data Scientist','Design Engineer','Engineering Manager') 

