use data2024
create table employee2
(
empid int primary key not null,
empname varchar(200),
Salary float,
address varchar(500)
)
select * from employee2
insert into employee2 values(101,'James',95858.25,'USA');



use AdventureWorks2012
select * from HumanResources.Employee
create database DataAnalytics
use DataAnalytics

create table employee
(
empcode int not null,
empname char(255) not null,
addrs varchar(500),
salary money,
mobno bigint
)

select * from sys.tables

select * from employee
insert into employee values(1007,'Abhimanu','Kanpur',56025.25);
insert into employee values(1001,'Ram','Mrt',56025.25);
insert into employee(empname,empcode,addrs) values('Ravita',1006,'Meerut')
insert into employee values(1002,'Gita','Delhi',86520.25);
insert into employee values(1004,'Anil','Kanpur',7845.25),(1005,'Hari','Ghz',95858.27)
insert into employee values(1006,'Gita Singh','Haridwar',87520.25);
select * from employee where empcode=1001;
select * from employee where addrs in ('Mrt','Kanpur');
select * from employee where salary between 5000 and 60000
select * from employee where salary>50000 and salary<60000
select * from employee where addrs like 'M%'
select empcode,salary from employee
--% any no of character, _ single character
select * from employee where empname like 'G%S%'
select * from employee where empname like '%h'
select * from employee where empname like '_a%'

--Alter use for modify the structure
--primary key use for unique values it can not be null 
create table student
(
rollno int primary key not null,
stdname char(200) not null,
)
select * from student
insert into student values(101,'James')

alter table student add stdAddress varchar(500) null
--you can not add not null
--alter table student add mobno bigint not null

--add default
alter table student add mobno bigint null

--drop column
insert into student values(102,'Ram','Meerut',8585969987)
alter table student drop column mobno

#update
select * from employee
update employee set addrs='Kanpur' where empcode=1001
update employee set addrs='Delhi', salary=80000 where empcode=1001

#delete
delete from employee where empcode=1006

#---drop, delete, truncate

create table dept
(
depid int,
deptname char(100)
)
insert into dept values(101,'sales')
insert into dept values(102,'sales'),(103,'marketing')
select * from dept

drop table dept
delete from dept
truncate table dept

---
delete from dept where depid=101



use AdventureWorks2012
select * from HumanResources.Employee
select * from HumanResources.Employee where BusinessEntityID=268

--drop database employeedatabase

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

create database hello
use hello

drop database hello
alter database hello Modify Name=Student_Data
EXEC sp_renamedb 'Student_Data','student_info'
sp_rename student_data,student_Information

sp_help
select host_id()



--Database Files and Filegroups
--Every database has at least two files, a primary file and a transaction log file, and at least 
--one filegroup. A maximum of 32,767 files and 32,767 filegroups can be specified for each database.
---------------------------------------------------------------------
--drop database
drop database sales
--drop snapshot
drop database sales_snapshot0600

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
    FILEGROWTH = 5MB )
GO

-------sapshot read only no log file maintain-------------
----database snapshot is read-only, a log file cannot be specified. In conformance with the
-- syntax, every file in the source database is specified, and filegroups are not specified.
--snapshot depend on .ndf or .mdf file and name should be same

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
select * from HumanResources.Employee where JobTitle='Data Scientist' 
or JobTitle='Design Engineer' 
select * from HumanResources.Employee where JobTitle 
in('Data Scientist','Design Engineer','Engineering Manager') 

select * from HumanResources.Employee order by BusinessEntityID desc
select * from HumanResources.Employee order by BusinessEntityID desc
select distinct(JobTitle) from HumanResources.Employee

select count(*) from HumanResources.Employee
select sum(vacationhours) as 'TotalVacationHourse' from HumanResources.Employee

---
use DataAnalytics
select * from employee
select top(2) * from employee
select addrs,sum(salary) as 'Total Salary' from employee group by addrs 
select top(2) addrs,sum(salary) as 'Total Salary' from employee group by addrs 

select addrs,sum(salary) as 'Total Salary' from employee group by addrs 
select addrs,sum(salary) as 'Total Salary' from employee group by addrs order by addrs desc


--------CTE Comman Table Expression - It is temporay result------------------


create table Batch_table
(
id int,
employee varchar(32)
)
go
insert into Batch_table values(1,'Matt'),
								(2,'Joseph')
go
Declare @updateTable table
(
id int, olddata_employee varchar(32), 
newdata_employee varchar(32)
);
update Batch_table
set employee=UPPER(employee)
output
inserted.id,
deleted.employee,
inserted.employee
into @updateTable
select * from @updateTable

----------------------------
select * from Batch_table

--------how to declare variable it is container use for hold value
declare @salary as integer
set @salary=60000
print @salary

select  * from employee


------------primary key-----------
create table stdReg
(
regno int identity(101,1) primary key not null,
stdname char(200) not null,
mobno bigint default 0,
emailid char(100) unique
)
insert into stdReg values('James',8459696958,'james@gmail.com')
insert into stdReg values('James',8459696958,'james1@gmail.com')
insert into stdReg values('Hari',8459698959,'Hari@gmail.com')
select * from stdReg

--------------foreign key--------------
create table examform
(
rollno int identity(5801,1) primary key not null,
stdsub char(200) not null,
fees money,
regno int foreign key references stdreg(regno)unique
)

insert into examform values('Computer Science',40000,101)
insert into examform values('Commerece',30000,103)
select * from examform
------------------multiple foreign key link---------------------------------------

create table stdmarks
(
regno int foreign key references stdreg(regno)unique,
rollno int foreign key references examform(rollno) unique,
hindi float default 0,
english float default 0,
math float default 0,
science float default 0,
computer float default 0
)

insert into stdmarks values(101,5801,80,60,70,80,65)
insert into stdmarks(regno,rollno,english,math) values(103,5805,80,60)
select * from stdmarks


-----
create table personid
(
personid uniqueidentifier default newid() not null,
person_name char(100),
age int check(age>17)
)

insert into personid(person_name,age) values('james',19)
insert into personid(person_name,age) values('Gita',16)
select * from personid

-------------Aggregate Function--------------------
select len(person_name) from personid
select left(person_name,'2') from personid
select person_name+' '+age as 'NameAge' from personid
select CONCAT(person_name,age)as 'NameAge'  from personid 
select ltrim('       hello') 
select rtrim('       hello') 

-----------------------
select * from employee
select top 3 * from employee 
select  distinct top 2 * from employee order by empcode desc
select distinct * from employee


--SET ROWCOUNT 5;
-------------------------------
with T1 as
(
  select row_number() over(order by empcode) as rownum,T2.empcode,T2.addrs
  from employee T2
)
select empcode,addrs
from t1
where rownum=3 or rownum=2

------------Row_number easy method-------------
SELECT empcode, empname 
FROM (
    SELECT empcode, empname, ROW_NUMBER() OVER (ORDER BY empcode) AS RowNum
    FROM employee
) AS MyDerivedTable
WHERE MyDerivedTable.RowNum=2 or MyDerivedTable.RowNum=3

-------------
select * from employee
select addrs,sum(salary) as 'Total' from employee group by addrs
select addrs,sum(salary) as 'Total' from employee group by addrs order by addrs asc


------------second highest salary------------------
SELECT MAX(SALARY) FROM Employee WHERE SALARY < (SELECT MAX(SALARY) FROM Employee)

-----------
SELECT * FROM (
  SELECT empcode, salary, DENSE_RANK() OVER (ORDER BY salary DESC) AS sal
  FROM employee
) AS subquery
WHERE sal = 3;

#--------------------
use AdventureWorks2012
select * from Sales.SalesOrderDetail

select * from(
select SalesOrderID,UnitPrice, dense_rank() over(order by Unitprice desc) as unit 
from Sales.SalesOrderDetail
)as query
where unit=2


select * from(
select SalesOrderID,UnitPrice, rank() over(order by Unitprice desc) as unit 
from Sales.SalesOrderDetail
)as query

------it use for create group--------------

SELECT empcode,salary 
    ,NTILE(3) OVER(ORDER BY empcode DESC) AS Quartile	   
FROM employee


---------------
SELECT * FROM employee
ORDER BY empcode
OFFSET 2 ROWS
FETCH NEXT 1 ROWS ONLY


#----update selected text-------
drop table dbo.myTestTable

CREATE TABLE dbo.myTestTable(
   colID int IDENTITY NOT NULL,
   directions varchar(max) NULL
)

INSERT INTO dbo.myTestTable(directions)
VALUES('North on Pike, South on Lee')
    , ('North on Pike, South on Lee')
    , ('North on Pike, South on Lee');

select * from dbo.myTesttable

UPDATE myTestTable SET directions .WRITE('Right', 15, 5);



SELECT * FROM employee
SELECT addrs,sum(salary) FROM employee group by addrs order by addrs asc
SELECT addrs,sum(salary) FROM employee where salary>30000 group by addrs order by addrs asc

SELECT addrs,sum(salary) FROM employee where salary>30000 group by all addrs 


select * from employee where empcode=1001
SELECT addrs,sum(salary) FROM employee where salary>30000 group by addrs having addrs='Delhi'
SELECT addrs,sum(salary) FROM employee where salary>30000 group by addrs with cube
--also arrange data ascending order
SELECT addrs,sum(salary) FROM employee where salary>30000 group by addrs with rollup

SELECT addrs,sum(salary) FROM employee group by empname,addrs having sum(salary)>40000 
order by addrs desc OFFSET 2 ROWS FETCH NEXT 1 ROWS ONLY


SELECT sum(salary) FROM employee
SELECT max(salary) FROM employee
SELECT min(salary) FROM employee
SELECT count(salary) FROM employee
SELECT avg(salary) FROM employee


--subqueries
SELECT * FROM stdreg
select * from examform

select * from stdreg where regno in (select regno from examform where stdsub='Computer Science')
select * from stdreg where exists (select regno from examform )

SELECT * FROM employee
SELECT * FROM stdreg

---copy one table data to another

INSERT INTO employee (empcode,empname)
SELECT regno,stdname
FROM stdreg where regno>101

----join---------

select empcode,empname,addrs,stdname,mobno from employee inner join stdreg on empcode=regno
select empcode,empname,addrs,stdname,mobno from employee inner join stdreg on empname=stdname

select * from HumanResources.Employee
select * from HumanResources.Department

select Jobtitle,E.ModifiedDate,groupname,D.ModifiedDate from HumanResources.Employee as E
inner join HumanResources.Department as D on BusinessEntityID=DepartmentID 
where JobTitle='Data Scientist'

select Jobtitle,E.ModifiedDate,groupname,D.ModifiedDate from HumanResources.Employee as E
left outer join HumanResources.Department as D on BusinessEntityID=DepartmentID 

select groupname,D.ModifiedDate,Jobtitle,E.ModifiedDate from HumanResources.Department as D
right outer join HumanResources.Employee as E  on DepartmentID=BusinessEntityID

select groupname,D.ModifiedDate,Jobtitle,E.ModifiedDate from HumanResources.Department as D
full outer join HumanResources.Employee as E  on DepartmentID=BusinessEntityID

select * from HumanResources.Department 
full join HumanResources.Employee  on DepartmentID=BusinessEntityID

--cross join
select * from HumanResources.Department as D
cross join HumanResources.Employee as E  

--Self------
select A.BusinessEntityID,A.JobTitle,A.OrganizationLevel from HumanResources.Employee as A
inner join HumanResources.Employee as B on A.BusinessEntityID=B.OrganizationLevel



#---------Merge------------------
create table A1
(
rollno int primary key not null,
name varchar(100) not null
)
insert into A1 values(101,'Gita')
select * from A1

--drop table b2
create table B2
(
rollno int primary key not null,
names varchar(100) not null
)
insert into B2 values(101,'James'),(102,'Hari')
select * from B2

-------copy-------
insert into A1 select * from B2


------------------
merge into A1 as p1
using B2 as p2 on p1.rollno=p2.rollno
--match
when matched then
update set p1.name=p2.names 
--not matched
when not matched then
insert (rollno,name)
values (p2.rollno,p2.names)
when not matched by source then
delete
--output
output $action,Inserted.rollno,Inserted.name,
Deleted.rollno,deleted.Name;


------------------------
#------CTE(Comman Table expression)----------------------

with CTE_OrderYear 
as
(
select year(orderdate)as orderyear,CustomerID from sales.SalesOrderHeader
)
select orderyear,count(distinct customerid)as customercount
from CTE_OrderYear group by orderyear

#--------we can not give the same name for cte-----------------------
with cte_students
as
(
select Jobtitle,E.ModifiedDate,groupname,ed.ShiftID from HumanResources.Employee as E
inner join HumanResources.Department as D on BusinessEntityID=DepartmentID 
inner join HumanResources.EmployeeDepartmentHistory as ED on
E.BusinessEntityID=ed.BusinessEntityID 
)
select JobTitle,count(ShiftID) from cte_students group by JobTitle

#-----------------------------------------------------------
create table emp
(
empcode int primary key not null,
empname char(100) not null,
aadharcard bigint unique,
city varchar(100)
)



declare @num1 as integer
declare @adar as bigint
set @num1=1
set @adar=7845858988
while (@num1<=10000)
begin
  insert into emp values(@num1,'James',@adar,'Meerut');
  set @num1=@num1+1
  set @adar=@adar+1
end

-------------------
select * from emp

----------------------------------------------------------------
create table department
(
Deptcode bigint primary key not null,
depname char(100) not null,
aadharcard bigint unique,
city varchar(100)
)

--drop table department

declare @num1 as bigint
declare @adar as bigint
set @num1=10000
set @adar=121518819
while (@num1<=15000)
begin
  insert into department values(@num1,'IT Dept',@adar,'Meerut');
  set @num1=@num1+1
  set @adar=@adar+1
end

select * from department


#--------------------------------
declare @a as integer
set @a=1
while (@a<=10)
begin
print @a
set @a=@a+1
end

#--------------------------------
declare @a as integer
set @a=1
while (@a<=10)
	begin
		if (@a%2!=0)
			begin
				print @a
			end
	set @a=@a+1
end

#---------------------------
---------copy one table value to another table------------------
INSERT INTO employee (empcode,empname)
SELECT regno,stdname
FROM stdreg where regno>101


#--------------------------------------------------
create table emp2
(
empcode int not null,
empname char(100) not null,
aadharcard bigint unique,
city varchar(100)
)

#--------------------------------
--drop table dbo.TestTable2 
CREATE TABLE dbo.TestTable2  
    (TestCol1 int NOT NULL,  
     TestCol2 nchar(10) NULL,  
     TestCol3 nvarchar(50) NULL);  
GO  

insert into dbo.TestTable2 values(101,'Ghz','IT Department'),
								 (102,'Meerut','Tele Department')
insert into dbo.TestTable2 values(102,'Kanpur','IT Department')
select * from dbo.TestTable2

CREATE CLUSTERED INDEX IX_TestTable_TestCol1   
    ON TestTable2 (TestCol2);   
GO  
alter table dbo.testtable2 add primary key(testcol1)  

alter table dbo.testtable2 add primary key(testcol1)  
alter table dbo.testtable2 add unique(testcol2) 

------------------------------------
USE AdventureWorks2019;  
GO  
IF EXISTS (SELECT name FROM sys.indexes  
            WHERE name = N'IX_ProductVendor_VendorID')   
    DROP INDEX IX_ProductVendor_VendorID ON Purchasing.ProductVendor;   
GO  
CREATE NONCLUSTERED INDEX IX_ProductVendor_VendorID   
    ON Purchasing.ProductVendor (BusinessEntityID);   
GO

#------------------------------------------------
USE AdventureWorks2012; 
select * from HumanResources.Employee 

#------------------------------------------------
select * from emp where empcode in(select Deptcode from department where deptcode=101)

-- Uses AdventureWorks  
-- Uses AdventureWorks  
  
create table a1
(
id int not null,
name char(100)
)
--drop table a1
insert into a1 values(103,'James'),(103,'James'),(101,'Ram')
insert into a1 values(105,'Karan')
insert into a1(id) values(105),(106)
select * from a1


create table b2
(
id int primary key not null,
sname char(100),
addres char(200)
)
--drop table b2
insert into b2 values(101,'James','Meerut'),(103,'Anita','Kanpur')
insert into b2 values(104,'Gita','Delhi')
insert into b2(id,sname) values(109,'James')
select * from b2

select * from a1 where id in (select id from b2)
select * from a1 where exists(select id from b2)


select name from a1 where exists (select addres from b2 where addres='Lucknow')
select name from a1 where not exists (select addres from b2 where addres='Lucknow')

select * from a1
select * from b2
--------union ----------------------------
select id,name from a1 union select id,sname from b2  
select id,name from a1 union all select id,sname from b2 
 
--join------------------
select * from a1
select * from b2
select a1.id,a1.name,addres from a1 inner join b2 on a1.id=b2.id
select a1.id,a1.name,b2.id,b2.sname,b2.addres from a1 left join b2 on a1.id=b2.id

select * from a1
select * from b2
select a1.id,a1.name,b2.id,b2.sname,b2.addres from a1 right join b2 on a1.id=b2.id
select * from a1
select * from b2
select a1.id,a1.name,b2.id,b2.sname,b2.addres from a1 cross join b2 
select a1.id,a1.name,b2.id,b2.sname,b2.addres from a1 full join b2 on a1.id=b2.id


create table b3
(
rollno int not null,
sname char(100),
addres char(200),
idno int
)
--drop table b2
select * from b3
insert into b3 values(101,'James','Meerut',101),(102,'Anita','Kanpur',103)
select a.rollno,a.sname,a.addres,a.idno  from b3 as a join b3 as b on a.rollno=b.idno

select * from sys.tables

create table t1
(
empid int not null,
name char(50) not null,
city varchar(60) not null
)
insert into t1 values(101,'ram','MRT'),(103,'Hari','MRT'),(102,'Gita','Dl'),(105,'Karan','Lkw')
select * from t1

create table t2
(
empid int not null,
salary money
)
insert into t2 values(101,50000),(104,60000),(103,40000),(102,30000)
select * from t2


--interview  Questions--------------
select t1.city,sum(t2.salary) as 'Salary' from t1 inner join t2 on t1.empid=t2.empid 
group by t1.city order by city desc


select Product.ProductID from Production.Product intersect 
select ProductId from Sales.SalesOrderDetail;

select Product.ProductID from Production.Product Except
select ProductId from Sales.SalesOrderDetail;


-------Pivot show column data into row wise---------------
select top 5 'TotalSalesYTD' as GrandTotal,[NorthWest],[Northeast],[Central],[Southwest],[Southeast]  
from
(select top 5 Name,SalesYTD from Sales.SalesTerritory)
as SourceTable
PIVOT
(
sum(SalesYTD) for Name IN([NorthWest],[Northeast],[Central],[Southwest],[Southeast] )
)as PivotTable;

------------------
--unpivot
CREATE TABLE VEmployee
 (VendorID int,
  Emp1Orders int,
  Emp2Orders int,
  Emp3Orders int,
  Emp4Orders int,
  Emp5Orders int)
GO
INSERT INTO VEmployee VALUES(1, 4, 3, 5, 4, 4)
select * from VEmployee;


------------------------------------------------
SELECT VendorID, Employee, Orders AS NumberOfOrders
 FROM
  (SELECT VendorID, Emp1Orders, Emp2Orders, Emp3Orders, Emp4Orders, Emp5Orders
    FROM VEmployee
  ) AS p
UNPIVOT
(
  Orders FOR Employee IN
   (Emp1Orders, Emp2Orders, Emp3Orders, Emp4Orders, Emp5Orders)
) AS unpvt


---Grouping set
select id,hname,gname from dbo.human

select id,hname,gname from dbo.human group by grouping sets 
(
(id,hname)
,(id,gname)
);


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


#-------------------------
declare @num1 as integer
declare @salary as money
declare @name as varchar(50)
set @num1=101
set @salary=5625.25
set @name='James'
print @num1
print @salary
print @name


select * from sys.tables
select * from employee


--------View is a virtual table of select statement
create view myview5 as
select t1.city,sum(t2.salary) as 'Salary' from t1 inner join t2 on t1.empid=t2.empid 
group by t1.city 
go


select * from myview5
select top 1 * from myview5





sp_help employee
sp_who


create view empview as
select * from employee
go

select * from empview
insert into empview values(101,'Anita','Mrt',62565)
delete from empview where empcode=101
update empview set empname='Arun' where empcode=1001


--drop view empview

#--------------------------------
--https://stackoverflow.com/questions/63763696/can-anyone-tell-me-how-inner-join-works-in-sql
--drop table t1,t2
create table t1
(
id int
)
insert into t1 values(1),(0),(0),(1)
insert into t1 values(0)
select * from t1
--drop table t1,t2
create table t2
(
id int
)
insert into t2 values(0),(1),(0),(1)
insert into t2 values(0)

select * from t1
select * from t2

select t1.id,t2.id from t1 inner join t2 on t1.id=t2.id


-------remove duplicate------------
delete t2 from 
(select id, 
      rownumber=ROW_NUMBER() over (partition by id order by (select null) 
	  )
from t2)as t2 where rownumber>1

------------remove according to row number--------------------
delete t2 from 
(select  
      rownumber=ROW_NUMBER() over (order by id )
from t2)as t2 where rownumber=2

(SELECT ID,ROW_NUMBER() OVER (ORDER BY id desc) R2 FROM t2)  
(SELECT ID, dense_rank() OVER (ORDER BY id desc) R2 FROM t2) 
(SELECT ID, rank() OVER (ORDER BY id desc) R2 FROM t2) 

#-----------------------------------------------------------------

#System Based Stored Procedure it is precompiled

exec sys.sp_who
execute sys.sp_who

#User Defined
create procedure sp_employee as
select empcode,empname,addrs,stdname,mobno from employee inner join stdreg on empcode=regno

exec sp_employee

#-------------------------------
create procedure sp_employee_parameter 
@city varchar(50) as
select * from employee where addrs=@city



exec sp_employee_parameter "Kanpur"

#--------------------------------------
select addrs,salary from employee inner join stdreg on empcode=regno

create procedure sp_employee_para 
@city varchar(50),@salary int output as
select @salary=sum(salary) from employee inner join stdreg on empcode=regno 
where addrs=@city

declare @salary as int
exec sp_employee_para "Mrt", @salary output;
select @salary



alter procedure procedurename
-------


drop procedure procedurename

----The builtin @@NESTLEVEL function Returns the nesting level of the current 
--stored procedure execution (initially 0) on the local server

SELECT @@NESTLEVEL AS 'Max Precision'   


select * from employee
create clustered index mycluster on employee(empid)
create nonclustered index mynoncluster on employee(mobno);

drop index indexname

--Cursor retrive one row at a time, it is temporary
use AdventureWorks2012
select * from HumanResources.employee;

DECLARE s1 CURSOR FOR SELECT * FROM HumanResources.employee;
OPEN s1
FETCH NEXT FROM s1;

--you can execute one by one
FETCH NEXT FROM s1;


DECLARE @custname AS varchar(20);
SELECT @custname = 'Data Analyst';
DECLARE employee_cursor2 CURSOR FOR SELECT * FROM HumanResources.employee 
OPEN employee_cursor2;
FETCH NEXT FROM employee_cursor2

WHILE @@FETCH_STATUS >0
  BEGIN
      UPDATE HumanResources.employee
      SET    JobTitle = @custname
      WHERE  CURRENT OF employee_cursor2;
      FETCH NEXT FROM employee_cursor2 
  END;
  close employee_cursor2;
  deallocate employee_cursor2;


--Trigger is a store procedure it will fire when DML OR DDL work done on table
--A trigger is a special type of stored procedure that automatically runs when an event occurs 
  --in the database server. DML triggers run when a user tries to modify data through a data 
  --manipulation language (DML) event. DML events are INSERT, UPDATE, or DELETE statements on a 
  --table or view



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
INSERT INTO Employee VALUES (1,'Pranaya', 50000, 'Male', 3)
INSERT INTO Employee VALUES (2,'Priyanka', 54000, 'Female', 2)
INSERT INTO Employee VALUES (3,'Anurag', 65000, 'male', 1)
INSERT INTO Employee VALUES (4,'sambit', 47000, 'Male', 2)
INSERT INTO Employee VALUES (5,'Hina', 66000, 'Female', 3)
select * from employee;
go

CREATE TRIGGER trInsertEmployee 
ON Employee
FOR INSERT
AS
if (select salary from inserted) < 9000
BEGIN
  PRINT 'YOU CANNOT PERFORM INSERT OPERATION'
  ROLLBACK TRANSACTION
END


INSERT INTO Employee VALUES (6,'Arjun', 5000, 'male', 7)

-----------------------------------------------------
CREATE TRIGGER trupdateEmployee 
ON Employee
FOR update
AS
if update(salary)
BEGIN
  PRINT 'YOU CANNOT PERFORM Update OPERATION'
  ROLLBACK TRANSACTION
END
-----------------------------------------
update employee set salary=80000 where id=1

--------------------------------------------------

--------create second table--------------
CREATE TABLE Employee2
(
  Id int Primary Key,
  Name nvarchar(30),
  Salary int,
  Gender nvarchar(10),
  DepartmentId int
)


CREATE TRIGGER trdeleteEmployee 
ON Employee
FOR delete
AS
if 2 in (select id from deleted)
BEGIN
  PRINT 'YOU CANNOT PERFORM DELETE OPERATION'
  ROLLBACK TRANSACTION
END
-----------------------------------------
delete from employee where id=3


---------------------------------
CREATE TRIGGER trInsertEmployee2 
ON Employee
FOR INSERT
AS
if (select salary from inserted) >500000
BEGIN
  PRINT 'YOU CANNOT PERFORM INSERT OPERATION'
  ROLLBACK TRANSACTION
  INSERT INTO Employee2 VALUES (1,'Arjun', 0, 'male', 7)  
END


INSERT INTO Employee VALUES (9,'Arjun', 800000, 'male', 7)
select * from employee2
-------------------------------------------
drop trigger trInsertEmployee2


---------Synonym----------------
--A synonym is a database object that serves the following purposes: Provides an 
--alternative name for another database object, referred to as the base object, 
--that can exist on a local or remote server.
use AdventureWorks2012;
 go
 create synonym mysny2
 for human
 go

 select * from sys.synonyms;
 select * from mysny2;


 --------Being-End @@Trancount

 use AdventureWorks2012
 go
 Begin Transaction 
 go
 if @@TRANCOUNT=0
	 begin
		select firstname,middlename from person.person
		where firstname='Kim';
		rollback transaction;
		print N'Rolling back the transaction two times would cause an error';
	 end
 else
	 begin
	    update person.person set middlename='Singh' where firstname='Kim'
		--delete from person.person where lastname='Abbas'
		rollback Transaction;  --use for undo	
		print N'Rolled back the transaction';
	 end
 go

 -----------commit-------------------
 use AdventureWorks2012
 go
 Begin Transaction 
 go
 if @@TRANCOUNT=0
	 begin
		select firstname,middlename from person.person
		where firstname='Kim';
		rollback transaction;
		print N'Rolling back the transaction two times would cause an error';
	 end
 else
	 begin
	    update person.person set middlename='Singh' where firstname='Kim'
		--delete from person.person where lastname='Abbas'
		commit transaction;  --use for undo	
		print N'Save the transaction';
	 end
 go
 -----------------------------
 use AdventureWorks2012
 go
 declare @listprice money
 set @listprice=(select max(listprice) from production.product)
 if @listprice>3000
	Print N'Amount Greater than 3000'
 else
   print N'Amount less than 3000'


 ---------------------------------------------------------------
 ---While Loop-------
Declare @a int
set @a=1
while (@a<=100)
begin
	if @a%2=0
		print @a
	set @a=@a+1
end

-----insert 1000 record into table
Declare @b as integer
set @b=7
while (@b<=100)
begin
	insert into employee2 values(@b,'Ram',60000,'Male',2)
	set @b=@b+1
end

select * from employee2

------------------------------------
select * from dbo.a1

---Function in sql server
--Scalar Functions
--A Scalar UDF accepts zero or more parameters and return a single value.
--

CREATE FUNCTION GetEmployeeSalary(@sal INT)  
 RETURNS table 
 AS  
RETURN
( 
    SELECT salary FROM employee2 WHERE salary>=@sal
)
go
--RUN------
select * from GetEmployeeSalary(1000)


------------------
use AdventureWorks2012
go
select SalesOrderID,ProductID,OrderQty,
sum(orderQty) over(partition by SalesOrderid) from Sales.SalesOrderDetail


select ROW_NUMBER() OVER(ORDER BY id asc),id,salary from employee2
select RANK() OVER(ORDER BY id DESC),id,NAME from employee2
select dense_RANK() OVER(ORDER BY id DESC),id,NAME from employee2
select top 3 * from employee2 

-------------Transaction----------------
select * from HumanResources.JobCandidate
---Transaction is a single unit of statement
use AdventureWorks2012;
go
declare @tranName varchar(30);
select @tranName='FirstTransaction';
BEGIN TRANSACTION @tranName;
DELETE From HumanResources.JobCandidate where JobCandidateid=6;
---work without where----it can not be rollback-----------
truncate table HumanResources.JobCandidate
------------------------

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
INSERT INTO Employee VALUES (1,'Pranaya', 50000, 'Male', 3)
select * from employee;
go


-----------Run Truncate in Safe Mode---so we can recover deleted values---------------------------
begin tran emp
truncate table employee
----------
rollback 


----------once you have commit can not be rollback----------------------
begin tran emp
truncate table employee
commit transaction

----------
rollback transaction

------------------------------------------------
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
select * from product


BEGIN TRANSACTION  
INSERT INTO Product VALUES(117,'Speaker', 3000, 25)  
-- Check for error  
IF(@@ERROR > 0)  
BEGIN  
    ROLLBACK TRANSACTION  
END  
ELSE  
BEGIN  
   COMMIT TRANSACTION  
END  

---------------------------------------

Print @@trancount
begin tran
	print @@trancount
	begin tran
		print @@trancount
		commit
	print @@trancount
	commit
print @@trancount




--SQL Performance Tuning: Practical Tips For Developers
--Use Indexes Wisely:
--avoid cursor
--wise use join
--select limit resultset

-----Query optimization
select * From HumanResources.Employee where jobtitle='Data Scientist';

SELECT * FROM Sales.SalesOrderDetail s
INNER JOIN Production.Product p ON s.ProductID = p.ProductID
--------------------

SELECT * FROM Production.TransactionHistory
SELECT * FROM  Production.TransactionHistoryArchive

--run query using product id it is optimize
SELECT * FROM Production.TransactionHistory th
INNER JOIN Production.TransactionHistoryArchive tha ON th.TransactionID = tha.TransactionID


------locks-------
/*Lock modes
Lock mode considers various lock types that can be applied to a resource that has to be locked:
Exclusive (X)
Shared (S)
Update (U)
Intent (I)
Schema (Sch)
Bulk update (BU)
Exclusive lock (X) – This lock type, when imposed, will ensure that a page or row will be 
reserved exclusively for the transaction that imposed the exclusive lock, as long as the 
transaction holds the lock.

The exclusive lock will be imposed by the transaction when it wants to modify the page or 
row data, which is in the case of DML statements DELETE, INSERT and UPDATE. An exclusive lock 
can be imposed to a page or row only if there is no other shared or exclusive lock imposed already
 on the target. This practically means that only one exclusive lock can be imposed to a page or
  row, and once imposed no other lock can be imposed on locked resources

Shared lock (S) – this lock type, when imposed, will reserve a page or row to be available only 
for reading, which means that any other transaction will be prevented to modify the locked record
 as long as the lock is active. However, a shared lock can be imposed by several transactions at 
 the same time over the same page or row and in that way several transactions can share the ability
  for data reading since the reading process itself will not affect anyhow the actual page or row
   data. In addition, a shared lock will allow write operations, but no DDL changes will be 
   allowed

Update lock (U) – this lock is similar to an exclusive lock but is designed to be more flexible 
in a way. An update lock can be imposed on a record that already has a shared lock. In such a 
case, the update lock will impose another shared lock on the target row. Once the transaction 
that holds the update lock is ready to change the data, the update lock (U) will be transformed 
to an exclusive lock (X). It is important to understand that update lock is asymmetrical in 
regards of shared locks. While the update lock can be imposed on a record that has the shared 
lock, the shared lock cannot be imposed on the record that already has the update lock

Intent locks (I) – this lock is a means used by a transaction to inform another transaction 
about its intention to acquire a lock. The purpose of such lock is to ensure data modification 
to be executed properly by preventing another transaction to acquire a lock on the next in 
hierarchy object. In practice, when a transaction wants to acquire a lock on the row, it will 
acquire an intent lock on a table, which is a higher hierarchy object. By acquiring the intent 
lock, the transaction will not allow other transactions to acquire the exclusive lock on that 
table (otherwise, exclusive lock imposed by some other transaction would cancel the row lock).

This is an important lock type from the performance aspect as the SQL Server database engine 
will inspect intent locks only at the table level to check if it is possible for transaction 
to acquire a lock in a safe manner in that table, and therefore intent lock eliminates need 
to inspect each row/page lock in a table to make sure that transaction can acquire lock on 
entire table
*/

SELECT * FROM sys.dm_os_performance_counters
WHERE object_name LIKE '%Locks%';

CREATE TABLE DemoTable  
(Id INT ,  
Name VARCHAR(100))  
INSERT INTO DemoTable  
values(1, 'Flutter'), (2, 'MySQL');  

select * from Demotable
-----
BEGIN TRAN  
UPDATE DemoTable SET   Name='SQL Server' where Id=2  
SELECT @@SPID AS session_id   
----
SELECT * FROM sys.dm_tran_locks  WHERE request_session_id=57


#------Exception Handling------------
begin try
	declare @num int;
	select @num=217/0;
end try
begin catch
	print 'Error divide by zero '
end catch

---------------------
USE AdventureWorks2012;
GO
BEGIN TRY
SELECT 217/0;
END TRY
BEGIN CATCH
SELECT
ERROR_NUMBER() AS ErrorNumber ,
ERROR_SEVERITY() AS ErrorSeverity,
ERROR_LINE() AS ErrorLine,
ERROR_MESSAGE() AS ErrorMessage;
END CATCH
GO

-------------------------------
select * from Production.Product;
USE AdventureWorks2012;
GO
BEGIN TRANSACTION;
BEGIN TRY
DELETE FROM Production.Product Where ProductID=999;
END TRY
BEGIN CATCH
SELECT
ERROR_SEVERITY() AS ErrorSeverity,
ERROR_NUMBER() AS ErrorNumber,
ERROR_STATE() AS ErrorState,
ERROR_PROCEDURE() AS ErrorProcedure,
ERROR_LINE() AS ErrorLine,
ERROR_MESSAGE() AS ErrorMessage;
IF @@TRANCOUNT > 0
ROLLBACK TRANSACTION;
END CATCH

IF @@TRANCOUNT >0
COMMIT TRANSACTION;
GO

---------------------------------------------
select * from HumanResources.EmployeePayHistory

use AdventureWorks2012;
GO
BEGIN TRY
UPDATE HumanResources.EmployeePayHistory SET PayFrequency=4
WHERE BusinessEntityID=1;
END TRY
BEGIN CATCH
IF @@ERROR=547
PRINT N'Check Constraint Violation has occured';
END CATCH

--raise error use for show user defined error
--------------------------------------------
RAISERROR (N'This is an error message %s - %d',5,1,N'Serial Number',23);
go

-----------Throw----------

use AdventureWorks2012;
GO
begin transaction
CREATE TABLE dbo.TestRethrow
(
ID INT PRIMARY KEY
);

BEGIN TRY
INSERT dbo.TestRethrow(ID) VALUES(1);
INSERT dbo.TestREthrow(ID) VALUES(1);
END TRY
BEGIN CATCH
if @@TRANCOUNT>0
PRINT 'Error Primary key rule conflict';
throw; --transfer control 
rollback;
END CATCH;

select * from dbo.TestRethrow
truncate table dbo.TestRethrow
drop table dbo.testrethrow

-----------------------
declare @n1 as integer
set @n1=1
while @n1<10
begin
  select * from HumanResources.Employee where BusinessEntityID=@n1;
  set @n1=@n1+1
end

-------print alphabate--------------
declare @n as integer
set @n=65
while @n<=90
begin
  print char(@n)
  set @n=@n+1
end
