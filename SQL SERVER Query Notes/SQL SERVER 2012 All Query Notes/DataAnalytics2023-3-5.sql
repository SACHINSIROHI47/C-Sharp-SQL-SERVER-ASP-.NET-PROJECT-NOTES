create database DataAnalytics2023
use DataAnalytics2023
create table student
(
rollno int not null,
stdname char(100) not null,
marks float,
dob date
)
select * from student
insert into student values(101,'Ram',80.25,'2000-05-10')

create table employee
(
empcode int not null,
empname char(100) not null,
empadd varchar(500) not null,
doj date,
salary money,
price float,
comment text
)

select * from employee
insert into employee values(101,'James','Meerut','2022-04-05',90000,5000,'Thankyou'),
							(102,'Hari','Kanpur','2022-04-01',80000,6000,'Nice Job')
insert into employee values(103,'Anita','Delhi','2022-04-05',70000,3000,'its ok'),
							(104,'Rita','Haridwar','2022-04-01',60000,2000,'Well done')

select * from employee where empcode=101
select * from employee where empcode between 102 and 103
select * from employee where empcode>=102 and empcode<=103
select * from employee where empcode>=500 or empcode<=103
select * from employee where empname like 'A%'
select * from employee where empadd like '%r'
select * from employee where empname like 'J_m%'
select * from employee where empname like '%s'
select * from employee where empname like '[a-i]%'    
select * from employee where empname like '[^a-i]%'   
select * from employee where empcode=101 
select empcode,empname,salary from employee where contains(salary,60000)                                                                                       
select * from employee where empadd in('Meerut','Lucknow')

Use AdventureWorks2012;  
GO  
SELECT Name, ListPrice  
FROM Production.Product  
WHERE CONTAINS(Name, 'Mountain');  
GO

#-------------------Primary key uniquely identify the record--------------
create table employee2
(
empcode int primary key not null,
empname char(100) not null,
empadd varchar(500) not null,
doj date,
salary money,
price float,
comment text,
aadharcard bigint unique
)

select * from employee2
insert into employee2 values(101,'James','Meerut','2022-04-05',90000,5000,'Thankyou',45874),
							(102,'Hari','Kanpur','2022-04-01',80000,6000,'Nice Job',95986)
insert into employee2 values(103,'Anita','Delhi','2022-04-05',70000,3000,'its ok',6966),
							(104,'Rita','Haridwar','2022-04-01',60000,2000,'Well done',4554)

insert into employee2 values(106,'Anita','Delhi','2022-04-05',70000,3000,'its ok',6945)
insert into employee2 values(107,'Shalu','Delhi','2022-04-05',70000.2565,3000.7248,'its ok',6974.958)
select empname,empadd from employee2 where contains(empadd,'Kanpur') 

-------------------Data Type and Variable----------------
declare @num1 as Integer
declare @num2 as Integer
set @num1=50
set @num2=60
print @num1+@num1

print 'Addition of Two Number'+str(@num1+@num2)

----------------------------------------------------------
select * from employee2
select year(doj) from employee2
select month(doj) from employee2
select day(doj) from employee2
select max(salary) from employee2
select min(salary) from employee2
select avg(salary) from employee2

select salary,rank() over (order by salary) from employee2
select salary,dense_rank() over (order by salary desc) from employee2
select salary,row_number() over (order by salary) from employee2
select salary,ntile(3) over (order by salary) from employee2

--String Function------------
select * from employee2
select left(empname,4) from employee2
select right(empname,3) from employee2
select len(empname) from employee2
select SUBSTRING(empname,2,5) from employee2
select len('  Meerut ') 
select len(ltrim('  Meerut '))
select len(rtrim('  Meerut '))
select Upper('Meerut')
select upper(empname) from employee2
select lower(empname) from employee2
select REPLACE('it is mrt','mrt','Meerut')
 

-----------------------Mathematical--------------------------------------
select POWER(2,3)
select SQRT(25)
select CEILING(126.25)
select floor(126.25)
select round(126.651,2)
select round(126.651,0)

-------------------Date Time------------------------------------
select GETDATE()
SELECT YEAR('2023-05-06')
SELECT Day('2023-05-06')
SELECT Month('2023-05-06')
declare @marks as Integer
set @marks=70.25
print @marks

DECLARE @myval DECIMAL(5, 2);
SET @myval = 193.57;
print @myval

-- Or, using CONVERT
SELECT CONVERT(DECIMAL(10, 2), @myval);
SELECT CONVERT(int, @myval);

select convert(int,salary) from employee2
select convert(decimal(10,1),salary) from employee2


#--------------condition----------------------
declare @mark as integer
set @mark=65
if @mark>=33
begin
	print 'Pass'
end
else
begin
	print 'Fail'
end

#--------loop---------------
declare @n as integer
set @n=1
while @n<=10
begin
	print @n
	set @n=@n+1
end

#-------------------------------------
select * from employee2
select * from employee2 where salary>=75000

/********** example 2 **********/
DECLARE @au_id as integer

SELECT @au_id = min( salary ) FROM employee2

WHILE @au_id IS NOT NULL
BEGIN
SELECT * FROM employee2 WHERE salary = @au_id

set @au_id=null
END

--------------------------------
select * from sys.tables
select * from employee2
select empadd,sum(salary) as EmpSalary from employee2 group by empadd
select * from employee2 order by empcode desc
select empadd,sum(salary) as EmpSalary from employee2 group by empadd order by sum(salary) asc
select empadd,sum(salary) as EmpSalary from employee2 group by empadd having sum(salary)>65000
 order by sum(salary) asc

select * from employee2 where salary>=65000
select sum(salary) from employee2 having sum(salary)>=65000

-----first create this table to other database for cloning
create table employee2
(
empcode int primary key not null,
empname char(100) not null,
empadd varchar(500) not null,
doj date,
salary money,
price float,
comment text,
aadharcard bigint unique
)

--copy production server data into testing server----Data Cloning-------
INSERT INTO DataAnalytics.dbo.employee2(empcode,empname,empadd,doj,salary,price,comment,aadharcard)
SELECT empcode,empname,empadd,doj,salary,price,comment,aadharcard
FROM DataAnalytics2023.dbo.employee2

#------------------------------
INSERT INTO DataAnalytics.dbo.employee2
SELECT *
FROM DataAnalytics2023.dbo.employee2

-----------------------------------------------
drop database aptechmeerut;

create database aptechmeerut on primary
(
    NAME = employee_db,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\
	aptech_db.mdf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 50MB
),
FILEGROUP myemployee_nd_group_1
(
    NAME = employee_ndf1,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\
	aptech_ndf1.ndf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)
log on
(
   NAME = employee_log,
  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\aptechlog.ldf',
	SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)

--modify database
alter database olddatabase modify name=newdatabase
--exec sp_changedbowner sa
 
 alter database aptechmeerut
 set auto_shrink on

 -----------------Modify Table-----------------------------
 create table emptable
 (
 id int primary key not null,
 ename char(100) not null
 )
 select * from emptable
 EXEC sp_rename 'dbo.emptable.id', 'empid', 'column';
 alter table emptable add addrs varchar(70)
 alter table emptable add mob bigint default 0
 alter table emptable drop column addrs

 insert into emptable values(101,'James'),(102,'Hari') 
 delete from emptable where empid=102
 update emptable set ename='Gita' where empid=101
 insert into emptable(empid,ename) values(102,'Hari')

 --drop table accessories

  create table accessories
 (
    id int identity(101,1) primary key not null,
	name char(100) not null,
	systemkey uniqueidentifier default newid(),
	mobno bigint unique,
	age int check (age>17)
 )

 insert into accessories(name,mobno,age) values ('james',9545845874,20),('Ram',9545845875,20)
 select * from accessories


 --------------Primary and foreign key---------------------------
 select * from sys.tables 
 create table std_Registration
 (
   rollno int primary key not null,
   name char(500) not null,
   addrs varchar(600)
 )

 insert into std_Registration values(101,'Gita','Delhi'),(102,'Arun','Mrt')
 select * from std_Registration

  create table Exam
 (
   rollno int foreign key references std_Registration(rollno) not null,
   class char(500) not null,
   fees money
 )

 select * from exam
 insert into exam values(102,'B.A',5000)
 insert into exam values(103,'B.Com',10000)

 ------------------------------------------------
 select * from sys.tables
 select * from employee


 create table employee
(
empcode int not null,
empname char(100) not null,
empadd varchar(500) not null,
doj date,
salary money,
price float,
comment text
)

select * from employee
insert into employee values(101,'James','Meerut','2022-04-05',90000,5000,'Thankyou'),
							(102,'Hari','Kanpur','2022-04-01',80000,6000,'Nice Job')
insert into employee values(105,'Anup','Delhi','2022-04-05',70000,3000,'its ok'),
							(106,'Anita','Haridwar','2022-04-01',60000,2000,'Well done')

select empadd,sum(salary) as 'Salary' from employee group by empadd
select empadd,avg(salary) as 'Salary' from employee group by empadd


Candidate key
primary key
foreign key
composite key
alternate key
unique key

--drop table EdTech
CREATE TABLE EdTech
( mail_id VARCHAR(30),
  passwordd VARCHAR(100),
  username VARCHAR(30) NOT NULL,
  course VARCHAR(30),
  mobile VARCHAR(10) NOT NULL,
  PRIMARY KEY (username, mobile) );

INSERT INTO EdTech (mail_id, passwordd,username, course, mobile)
VALUES ('abhishek123@gmail.com', 'iloveedtech','Asxna', 'System Design', '9999988888');

INSERT INTO EdTech (mail_id, passwordd,username, course, mobile)
VALUES ('anshu111@gmail.com', 'anshu2019','anshu26', 'Big Data', '9999988888');

SELECT * FROM EdTech;

-----------Subquery/Nested Query--------------------
select duedate,shipdate,OrderDate from sales.SalesOrderHeader
where sales.SalesOrderHeader.OrderDate=(select max(orderdate) from 
sales.SalesOrderHeader)

select firstname,lastname,BusinessEntityID from person.Person
where Person.BusinessEntityID in (
select BusinessEntityID from HumanResources.Employee
where JobTitle='Research and Development Manager')

select firstname,lastname,BusinessEntityID from person.Person as A
where exists (
select * from HumanResources.Employee as B
where JobTitle='Research and Development Manager'
and A.BusinessEntityID=B.BusinessEntityID)

--------------------------------------------------------
select * from sys.tables
select * from student 
select * from exam
--truncate table student
--truncate table exam
select d.stdname,d.marks,e.class,e.fees from student as d inner join exam as e on
 d.rollno=e.rollno

insert into student values(101,'Hari',70,'1990-06-06')
insert into student values(103,'James',80,'2000-05-04')
insert into exam values(101,'B.Tech',48000)
insert into exam values(102,'BCA',8000)
----------------------------------------------------------
select * from student 
select * from exam
select d.stdname,d.marks,e.class,e.fees from student as d left outer join exam as 
e on d.rollno=e.rollno

select * from student right outer join exam on student.rollno=exam.rollno

select * from student full outer join exam on student.rollno=exam.rollno

select * from student 
select * from exam
select * from student cross join exam 

---------------self join-----------
create table slfjoin
(
id int not null,
pry_number char(10),
altr_number char(10)
)
select * from slfjoin
insert into slfjoin values(1,'9457878787','6598545874')
insert into slfjoin values(2,'9457878788','9457878788')

-------self join----------
select a.pry_number,b.altr_number from slfjoin a inner join slfjoin b on 
a.pry_number=b.altr_number 

--------Merge----------
create table product
(
productid int not null,
prodname char(50)not null,
ptype char(100) not null,
purchasedate date
);
--drop table product;
select * from product;
insert into product values(100,'Computer','IT','2020-05-06'),(102,'Mouse','IT ','2020-04-03');

create table newproduct
(
productid int not null,
prodname char(50)not null,
ptype char(100) not null,
purchasedate date
);

insert into newproduct values(100,'Computer','IT','2020-05-06'),(103,'Keyboard','IT ','2020-11-02');
insert into newproduct values(104,'Laptop','IT','2020-05-01')
select * from product;
select * from newproduct;

-------------
merge into product as p1
using newproduct as p2 on p1.productid=p2.productid
--match
when matched then
update set p1.prodname=p2.prodname ,
p1.ptype=p2.ptype,
p1.purchasedate=p2.purchasedate
--not matched
when not matched then
insert (productid,prodname,ptype,purchasedate)
values (p2.productid,p2.prodname,p2.ptype,p2.purchasedate)
when not matched by source then
delete
--output
output $action,Inserted.productId,Inserted.prodname,
Inserted.pType,Inserted.purchaseDate,Deleted.Productid,deleted.prodName,
deleted.pType,deleted.Purchasedate;

-------------CTE(Common Table Expression)-------------------------
with cte_order as
(
select year(orderdate)as odrdate,CustomerID from sales.SalesOrderHeader
)
select odrdate from cte_order where odrdate=2011

----------------------------------------------------------------------
with cte_order as
(
select year(orderdate)as odrdate,CustomerID from sales.SalesOrderHeader
),
data as
(
select top 2 odrdate from cte_order where odrdate=2011
)
select odrdate from data

--------------Union---Show distinct------------
select * from product
union
select * from newproduct

----------------union all-------------------------
select * from product
union all
select * from newproduct

-------------------------------------
select * from product
select * from newproduct

select p.productid,p.prodname,p.ptype,p.purchasedate,n.productid,n.prodname,
n.ptype,n.purchasedate from product as p inner join
newproduct as n on p.Productid<n.productid

--------------intersect---------------------------
select * from product
intersect
select * from newproduct

----------------------------------------------
select * from product
except
select * from newproduct

-------------CTE(Common Table Expression)-------------------------
with cte_order as
(
select CustomerID ,year(orderdate)as odrdate,dense_rank() over(order by year(orderdate))as mydate 
from sales.SalesOrderHeader
)
select CustomerID,odrdate from cte_order where mydate=3

---------View is the virtual table-------------------
create view mytableview as
select * from product


select * from mytableview 
delete mytableview where Product_id=116
update mytableview set Product_name='HP Laptop' where Product_id=116
--drop view mytableview

--------alter view always run in batch-----------
alter view mytableview as
select * from product where Product_id<=114
go

select * from mytableview
exec sp_helptext mytableview
-------------------procedure is precomplied of code-------
create procedure uspget
as
select top 10 customerid,customer.TerritoryID from sales.customer
join sales.SalesTerritory on sales.Customer.TerritoryID=Sales.SalesTerritory.TerritoryID

----------Execute----------------------- 
exec uspget

----procedure with parameter-------------
create procedure uspgetsales
@territory varchar(40)
as
select BusinessEntityID from sales.SalesPerson where BusinessEntityID=@territory

----------call procedure and pass parameter-----------------
execute uspgetsales 285

---------------------------------------
create procedure myprocedure3
@cid int,
@result int output
as
begin
     select * from Sales.customer where CustomerID=@cid
	 set @result=500
end
---------------------------------------
declare @addition int
execute myprocedure3 102,@addition output
select @addition

--Alter procedure
ALTER procedure [dbo].[myprocedure3]
@cid int,
@result int output
as
begin
     select * from Sales.customer where CustomerID=@cid
	 set @result=500
end

------------------------
drop procedure myprocedure3

--------------------Indexing------------------------
create table emptable
(
empid int not null,
name char(100)not null
)
select * from emptable
----we can create only one cluster in one table----
create clustered index mycluster on emptable(empid)
----we can create one and more Non-Cluster in one table----
create nonclustered index mynoncluster on emptable(empid);

drop index mycluster on emptable
drop index mynoncluster on emptable

----Cursor iterate result set one by one--------
use AdventureWorks2012;
select * from HumanResources.employee;

DECLARE s1 CURSOR FOR SELECT * FROM HumanResources.employee;
OPEN s1
FETCH NEXT FROM s1;

----------------------
DECLARE @custname AS varchar(20);
SELECT @custname = 'Data Scientist';
DECLARE employee_cursor CURSOR FOR SELECT JobTitle FROM HumanResources.employee where 
businessEntityid=3;
OPEN employee_cursor;
FETCH NEXT FROM employee_cursor

WHILE @@FETCH_STATUS > 0
  BEGIN
      UPDATE HumanResources.employee
      SET    JobTitle = @custname
      WHERE  CURRENT OF employee_cursor;
      FETCH NEXT FROM employee_cursor 
  END;
  close employee_cursor;
  deallocate employee_cursor;

  -----------------Trigger----------------------
  --A trigger is a special type of stored procedure that automatically runs when an event occurs 
  --in the database server. DML triggers run when a user tries to modify data through a data 
  --manipulation language (DML) event. DML events are INSERT, UPDATE, or DELETE statements on a 
  --table or view

  -- Create Employee 
 --drop table employee
CREATE TABLE Employee
(
  Id int Primary Key,
  Name nvarchar(30),
  Salary int,
  Gender nvarchar(10),
  DepartmentId int
)
GO

-- Insert data into Employee table
INSERT INTO Employee VALUES (1,'Pranaya', 5000, 'Male', 3)
INSERT INTO Employee VALUES (2,'Priyanka', 5400, 'Female', 2)
INSERT INTO Employee VALUES (3,'Anurag', 6500, 'male', 1)
INSERT INTO Employee VALUES (4,'sambit', 4700, 'Male', 2)
INSERT INTO Employee VALUES (5,'Hina', 6600, 'Female', 3)
INSERT INTO Employee VALUES (7,'Hina', 66000, 'Female', 3)
select * from employee;
go

----Trigger----------
CREATE TRIGGER trInsertEmployee 
ON Employee
FOR INSERT
AS
if (select salary from inserted) < 9000
BEGIN
  PRINT 'YOU CANNOT PERFORM INSERT OPERATION'
  ROLLBACK TRANSACTION
END

---check the trigger on insert query--------
INSERT INTO Employee VALUES (6,'Hari', 7000, 'Male', 3)
select * from employee;

---add column
alter table employee add dob date
-----create update trigger------------

CREATE TRIGGER trgUpdateEmployee 
ON Employee
FOR update
AS
if (select dob from inserted)>GETDATE()
BEGIN
PRINT 'Date of birth cannot be greater than today date'
rollback
end

--checking update trigger--------

update Employee set dob='2024-01-01' where id=5;

update Employee set dob='2022-01-01' where id=5;

insert into Employee values(6,'Gita',20000,'Female',1,'2024-01-02')
select * from employee;


-----------------------Transaction----------------------
---Transaction is a single unit of statement

use AdventureWorks2019;

select * From HumanResources.JobCandidate;

BEGIN TRANSACTION mytran
DELETE From HumanResources.JobCandidate where JobCandidateid=13;

--we can rollback the deleted values-------
rollback 

--but if we commit so we can not roll back
BEGIN TRANSACTION mytran
DELETE From HumanResources.JobCandidate where JobCandidateid=13;
commit tran mytran;

-----it can not be rollback after commit------
rollback

------------------------------------------
use AdventureWorks2019;
go
declare @tranName varchar(30);
select @tranName='FirstTransaction';

BEGIN TRANSACTION @tranName;
DELETE From HumanResources.JobCandidate where JobCandidateid=7;


-----------------------------------------------------------------
CREATE TABLE Product (  
 Product_id INT PRIMARY KEY,   
 Product_name VARCHAR(40),   
 Price INT,  
 Quantity INT  
)  
--Next, execute the below scripts to insert data into this table:

INSERT INTO Product VALUES(111, 'Mobile', 10000, 10),  
(112, 'Laptop', 20000, 15),  
(113, 'Mouse', 300, 20),  
(114, 'Hard Disk', 4000, 25),  
(115, 'Speaker', 3000, 20);  

select * from product;

BEGIN TRANSACTION  
INSERT INTO Product VALUES(116,'Speaker', 3000, 25)  
-- Check for error  
IF(@@ERROR > 0)  
BEGIN  
    ROLLBACK TRANSACTION  
END  
ELSE  
BEGIN  
   COMMIT TRANSACTION  
END  
--------------------------------------------------------
BEGIN TRANSACTION proceduresave;
DELETE From HumanResources.JobCandidate where JobCandidateid=12;
go
--execute in batch
create proc savetranexample
as
declare @trancounter int;
set @trancounter=@@TRANCOUNT
if @trancounter>0
	save transaction proceduresave
else
	begin transaction;
	delete HumanResources.JobCandidate
	where JobCandidateID=11;
go

----------
select * from HumanResources.JobCandidate

--------------------
Print @@trancount
begin tran
	print @@trancount
	begin tran
		print @@trancount
		commit
	print @@trancount
	commit
print @@trancount
