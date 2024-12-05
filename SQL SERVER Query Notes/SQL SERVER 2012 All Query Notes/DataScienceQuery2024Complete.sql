create database DataScience2023
use DataScience2023
create table employee
(
empid int primary key not null,
empname char(70) not null,
empaddress varchar(200) not null,
mobno bigint null
);

select * from employee;





insert into employee values(101,'James','Meerut',9458748587);
insert into employee(empid,empname,empaddress) values(102,'Gita','Kanpur');
insert into employee(empaddress,empid,empname) values('Delhi',103,'anita');

select * from employee where empid=101;
select * from employee where empaddress in ('Meerut','Kanpur','Lucknow');
select * from employee where empname like 'a%';
select * from employee where empid between 101 and 103;
select * from employee where empid>=101 and empid<=103;
select * from employee where empid>=101 or empid<=90;
select * from employee where empid!=101;
select * from employee where empaddress<>'Meerut';
select * from employee where NOT(empid=105);

--how to declare variable in sql
--variable is a memory contianer for store values into the memory location
declare @num1 int;
set @num1=50;
select @num1

declare @name char(50);
set @name='James';
select @name
--print @name

declare @age int=25;
select @age;

select 2+2 as 'Addition';

select * from sales.SalesOrderHeader;
select * from sales.SalesOrderHeader where SalesOrderId=43659;

select * from humanresources.employee;
select nationalidnumber,loginid from humanresources.employee;


--batch is collection of one or more sql statement execute into single
use AdventureWorks2012;
select * from humanresources.employee;
go

select * from humanresources.employee;
select nationalidnumber,loginid from humanresources.employee;
go

select * from employee order by empid desc;
select * from employee order by empid asc;

select * from Sales.SalesOrderHeader;
select * from Sales.SalesOrderHeader where salesorderid=43659

--Groupby-----
select sum(SalesOrderID) from 
Sales.SalesOrderHeader group by SalesOrderID;
--group by---
select empaddress,sum(empid),count(empname) from employee where empid<=104  group by empaddress
having empaddress like 'M%';
--order by--
select * from employee order by empaddress asc;
select * from employee order by empaddress;

select * from employee where empid=101;
select * from humanResources.Department;
select GroupName,COUNT(departmentid) as 'TotalCount',count(name) as 'Name' from 
HumanResources.Department group by GroupName;
select GroupName,COUNT(departmentid) as 'TotalCount',count(name) as 'Name' from 
HumanResources.Department group by GroupName having groupname='Manufacturing';

create database meerut
alter database meerut modify name=MeerutCity;
use meerutcity;

sp_changedbowner 'ram'
use meerutcity;
alter database meerutcity
set auto_shrink on


USE master
GO
ALTER DATABASE meerutcity
ADD FILEGROUP Test1FG2;
GO
ALTER DATABASE meerutcity 
ADD FILE 
(
    NAME = test1dat4,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\
	DATA\t1dat4.ndf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)
TO FILEGROUP Test1FG2;
GO

create database Meerutcity;
use MeerutCity
drop database MeerutCity;


CREATE DATABASE AdventureWorks_dbss1800 ON (
    NAME = AdventureWorks2012,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\
	DATA\AdventureWorks_data_1800.ss'
    ) AS SNAPSHOT OF AdventureWorks2012;
GO




--user defined type
create type price from money not null

create table dbo.product
(
pid int identity(1001,1)not null,
pname char(250)not null,
amount money not null,
addres text,
[custid number][numeric](10,0)not null  
)
--10-0 maximum ten digit of data
select * from dbo.product;
insert into dbo.product(pname,amount,addres,[custid number]) values('computer',25025.15,
'Meeruct',1294567895)

--modify column
alter table dbo.product alter column [custid number][numeric](12,0)not null 
insert into dbo.product(pname,amount,addres,[custid number]) values('computer',25025.15,
																'Meeruct',129456789578)
--first delete constraint then delete the column
alter table empinfo add feedback int default 0
alter table empinfo drop constraint DF__empinfo__feedbac__4D5F7D71
alter table empinfo drop column feedback


alter table dbo.product add price money null CONSTRAINT cst default (0) with values

--add column  
--we can not add not null column
alter table dbo.product add [contact number][numeric](12,0)null


--drop column
--we can not delete several condition primary key, foreign key, unique key, check, default
alter table dbo.product drop column [contact number]


--drop table
drop table dbo.product;

--update values from table
update dbo.product set pname='Laptop' where pid=1002
update dbo.product set pname='Mobile',addres='Kanpur' where pid=1004 or pid=1006

--select command
select * from dbo.product;

--delete
delete from dbo.product where pid=1006

select * from sys.tables;

Create table EmployeeInfo
(
empid int primary key not null,
empname char(200) not null
)

select * from EmployeeInfo;
insert into EmployeeInfo values(101,'James'),(102,'Ram');

create table EmployeePayroll
(
Empid int foreign key references EmployeeInfo(empid),
TransationNo bigint unique not null,
designation varchar(250),
salary money check (salary>0)
)

create table a
(
id int primary key not null
)
insert into a values(50)
select * from a
delete from a where id=99
truncate table a
drop table a

create table b
(
myid int references a(id) on delete cascade on update cascade
)
--drop table b
insert into b values(99)
select * from b
delete from b where myid=99



--drop table EmployeePayroll
select * from EmployeePayroll;
insert into EmployeePayroll values(101,11001,'Data Scientist',100000)
insert into EmployeePayroll values(102,11004,'SQl Developer',50000)
#-------------Unit 8 Accessing Data--------------
select left(designation,5) from EmployeePayroll;
select TransationNo,designation from EmployeePayroll;
select 'Designation is '+' : '+designation as 'Job Postition' from EmployeePayroll

select Empid,TransationNo,designation,salary,salary*0.05 as 'Bonus' from EmployeePayroll;

--Distinct keyword show only the unique values
select distinct(empid) from EmployeePayroll

select top 2 * from EmployeePayroll 
#-----groupby use for arranging the data
select empid,sum(salary) from EmployeePayroll group by empid;

#---CTE(Common Table expression) it is temporary result set
--CTEs make code more readable. And readability makes queries easier to debug. CTEs can reference
-- the results multiple times throughout the query. By storing the results of the subquery, 
--you can reuse them throughout a larger query.

create table newemployee(EmployeeId smallint,
firstname char(50),lastname char(50),
department varchar(100), hiredate datetime,
salary money);
insert into newemployee values(11,'kevin','blaine',
'Research','2012-07-31',54000);

with employeeTemp(employeeid,firstname,lastname,department,hiredate,salary)
as
(
select * from newemployee
)
select * from employeeTemp
-------------------------------------------

create table dcr
(
did int,
salary float,
bonus float
);
--execute in bunch
declare @salary float
set @salary=40000
--select @salary
declare @bns float
set @bns=5000
insert into dcr(did,salary,bonus) values(101,@salary,@bns)
-----
select * from dcr;


--------output varaible--------
--create-insert-update-display----execute all below query in bulk--
create table emptable
(
id int ,
employee varchar(20)
)
go
insert into emptable values(1,'Mat'),(2,'Joseph');
go
declare @updatetable table
(
 id int,
 oldemp varchar(20),newmp varchar(20)
);
update emptable 
set employee=Upper(employee)

output
inserted.id,
deleted.employee,
inserted.employee
into @updatetable 
select * from @updatetable
--------------------
select * from emptable;
drop table emptable

-----------Replacing values-----------------------
go
create table table_5
(
employee_role varchar(max),
summary varchar(max)
)
insert into table_5 values('research','This is a very long non-unicode string')
select * from table_5
update table_5 set summary .write('Good',10,4)
where employee_role like 'research'
select * from table_5

--drop table table_5
#--------------------

use AdventureWorks2012
select * from sales.SalesTerritory order by SalesLastYear asc
go

----insert xml data
insert into table_5 values('Data scientist', '<working><prog>Python</prog></working>')
select * from table_5

---unit-9-------
select WorkOrderID,sum(ActualResourceHrs) as TotalHours from Production.WorkOrderRouting 
group by WorkOrderID
select WorkOrderID,sum(ActualResourceHrs) as TotalHours from Production.WorkOrderRouting
where WorkOrderID>20 group by WorkOrderID
select WorkOrderID,sum(ActualResourceHrs) as TotalHours from Production.WorkOrderRouting
group by WorkOrderID having WorkOrderID>20


--group by with null
select class from Production.Product
select class,avg(listprice) from Production.Product group by class

--Group by with all , pass column name into [] for table column name surely
select [Group],sum(SalesYTD) from Sales.salesTerritory where [group] like 'E%' or 
[group] like '__r%' group by all [Group]

--cube
select name,CountryRegionCode,sum(salesytd) as totalsales from sales.SalesTerritory
where name <> 'Australia' and name <> 'canada' group by name,CountryRegionCode with cube

--rollup
select name,sum(salesytd) as totalsales from sales.SalesTerritory
where name <> 'Australia' and name <> 'canada' group by name with rollup

--Aggregate Function
select count(*) as "Total Row"  from sales.SalesTerritory

--Spatial Aggregates
declare @city1 geography
set @city1=geography::stpolyfromtext(

--Subquery to return record that will be used
--as criteria for another select query

select dueDate,shipdate from sales.SalesOrderHeader where sales.SalesOrderHeader.OrderDate=
(select max(OrderDate) from sales.SalesOrderHeader)


select FirstName,LastName from Person.Person where Person.person.BusinessEntityID in (select
BusinessEntityID from HumanResources.Employee where JobTitle ='Research and Development Manager')

--Exists check row and return row/record not data
select * from Person.Person
select * from HumanResources.Employee

select FirstName,LastName from Person.Person as A where exists (select
BusinessEntityID from HumanResources.Employee as B where 
JobTitle ='Research and Development Manager'
and A.BusinessEntityID=B.BusinessEntityID)

--Nested subquery
select * from sales.SalesPerson

select BusinessEntityID,FirstName,LastName from Person.Person where Person.person.BusinessEntityID 
in (select BusinessEntityID from sales.SalesPerson where TerritoryID in ( select
TerritoryID from sales.SalesTerritory where name='Canada'))

---Join by default inner join
select A.FirstName,A.LastName,B.JobTitle from person.Person as A
join HumanResources.Employee as B on A.BusinessEntityID=B.BusinessEntityID

--Inner join show record both table are matched
select A.FirstName,A.LastName,B.JobTitle from person.Person as A
inner join HumanResources.Employee as B on A.BusinessEntityID=B.BusinessEntityID

--left outer join
select A.CustomerID,B.DueDate,B.ShipDate from Sales.Customer as A Left outer join
sales.SalesOrderHeader as B on A.CustomerID=B.CustomerID and year(B.DueDate)<2012;


select A.*,B.* from Sales.Customer as A Left outer join
sales.SalesOrderHeader as B on A.CustomerID=B.CustomerID and year(B.DueDate)<2012;

--Right outer join
select A.*,B.* from Sales.Customer as A right outer join
sales.SalesOrderHeader as B on A.CustomerID=B.CustomerID and year(B.DueDate)<2012;


#------Merge--------------
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


--Second Example of Merge
CREATE TABLE SourceProducts(
    ProductID		INT,
    ProductName		VARCHAR(50),
    Price			DECIMAL(9,2)
)
GO
    
INSERT INTO SourceProducts(ProductID,ProductName, Price) VALUES(1,'Table',100)
INSERT INTO SourceProducts(ProductID,ProductName, Price) VALUES(2,'Desk',80)
INSERT INTO SourceProducts(ProductID,ProductName, Price) VALUES(3,'Chair',50)
INSERT INTO SourceProducts(ProductID,ProductName, Price) VALUES(4,'Computer',300)
GO
    
CREATE TABLE TargetProducts(
    ProductID		INT,
    ProductName		VARCHAR(50),
    Price			DECIMAL(9,2)
)
GO
    
INSERT INTO TargetProducts(ProductID,ProductName, Price) VALUES(1,'Table',100)
INSERT INTO TargetProducts(ProductID,ProductName, Price) VALUES(2,'Desk',180)
INSERT INTO TargetProducts(ProductID,ProductName, Price) VALUES(5,'Bed',50)
INSERT INTO TargetProducts(ProductID,ProductName, Price) VALUES(6,'Cupboard',300)

GO   

SELECT * FROM SourceProducts;
select * from TargetProducts;  

--Merge
MERGE TargetProducts AS Target
USING SourceProducts	AS Source
ON Source.ProductID = Target.ProductID
WHEN NOT MATCHED BY Target THEN
    INSERT (ProductID,ProductName, Price) 
    VALUES (Source.ProductID,Source.ProductName, Source.Price)
--use semicolon when we want to execute seprately
-- For Updates
    WHEN MATCHED THEN UPDATE SET
        Target.ProductName	= Source.ProductName,
        Target.Price		= Source.Price
-- For Deletes
WHEN NOT MATCHED BY Source THEN
    DELETE;


#---------CTE--Comman Table Expression-----------
with CTE_OrderYear
As
(
Select Year(OrderDate) AS OrderYear, CustomerId
from Sales.SalesOrderHeader
)
select OrderYear, count(Distinct CustomerID) as CutomerCount
from CTE_OrderYear group by orderyear;

#union column name can be different by data type must be same

select Product.ProductID from Production.Product inner join 
Sales.SalesOrderDetail on Product.ProductID=SalesOrderDetail.ProductID;

select * from Production.Product
select * from Sales.SalesOrderDetail;

select ProductID,ModifiedDate from Production.Product union 
select ProductId,ModifiedDate from Sales.SalesOrderDetail;

select Product.ProductID from Production.Product union all 
select ProductId from Sales.SalesOrderDetail;

select Product.ProductID from Production.Product intersect 
select ProductId from Sales.SalesOrderDetail;

select Product.ProductID from Production.Product except select ProductId from Sales.SalesOrderDetail;

select top 5 sum(salesYTD) as TotalSalesYTD,name from Sales.SalesTerritory group by name;

--arrange table with one row and six column
select * from Sales.SalesTerritory


--PIVOT is a relational operator that allows database developers to convert query results 
from rows to columns. Meanwhile, UNPIVOT will be used to rotate data from columns into rows.


select top 5 'TotalSalesYTD' as GrandTotal,[NorthWest],[Northeast],[Central],[Southwest],[Southeast]  
from
(select top 5 Name,SalesYTD from Sales.SalesTerritory)
as SourceTable
PIVOT
(
sum(SalesYTD) for Name IN([NorthWest],[Northeast],[Central],[Southwest],[Southeast] )
)as PivotTable;

 --unpivot
 select Names,salesYTD from (select GrandTotal,NorthWest,Northeast,Central,Southwest,Southeast from TotalTable) P
 UNPIVOT
(SalesYTD FOR Names in (GradndTotal,NorthWest,Northeast,Central,Southwest,Southeast)) AS unpvt;

select * from dbo.human;

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
select id,hname,gname from dbo.human group by grouping sets 
(
(id,hname)
,(id,gname)
);

--virtual Table 
CREATE VIEW vwproductinfoo as
Select Productid, productNumber, Name, SafetyStockLevel
from Production.Product

select * from vwproductinfoo;

select * from vwproductinfoo order by ProductID desc;

#-----------
create view vwSortedPersonDetails
as
select top 10 coalesce(p.Title,' ')as Title,
p.FirstName,coalesce(p.MiddleName,' ') as MiddleName,
p.LastName,e.JobTitle from HumanResources.Employee e inner join
person.Person p on p.BusinessEntityID=e.BusinessEntityID
order by p.FirstName
go

#execute view
select * from vwSortedPersonDetails

----------------view second example
create table employee_Personal_details
(
empid int not null,
firstname varchar(30),
lastname varchar(30),
address varchar(30)
);

create table employee_salary_details
(
empid int not null,
designation varchar(30),
salary int not null
);

create view vmemployee2 as
select e1.empid,firstname,lastname,designation,salary from 
employee_Personal_details e1 join employee_salary_details e2 on
e1.empid=e2.empid;

--drop view dbo.vmemployee;
go
select * from vmemployee2;
insert into vmemployee2 values(2,'jack','wilson','software developer',16000);

------------------
---create view in single table
create view singleview as
select empid,firstname from employee_Personal_details;

insert into singleview values(102,'James');
select * from singleview;
select * from employee_Personal_details;
update singleview set firstname='Gita' where empid=101;
delete from singleview where empid=102

--update singleview set firstname .write('Sa',1,2) where empid=101

create view vwdepartment as
select * from HumanResources.Department 


select * from vwdepartment

--alter the view
alter view vwdepartment as
select * from HumanResources.Department where DepartmentID>10


select * from vwdepartment

--drop view
drop view vwdepartment

--sphelptext use for identitfy about view
exec sp_helptext vwdepartment

----show all table of database------------
create table product
(
hsncode int,
prodname char(50),
price float
);
insert into product values(101,'Computer',900),(102,'Mouse',800);
select * from product;
use aptech
select * from sys.tables;
select * from product;

create view productview23 as SELECT hsncode,prodname,price from dbo.product
where hsncode>1000;



update productview set price=500 where hsncode>1000


select * from product
select * from product

-----Stored Procedure--------
create procedure upsGetCusTerritory
as
select top 10 CustomerID,Customer.TerritoryID,Sales.SalesTerritory.Name from Sales.Customer
join Sales.SalesTerritory on 
Sales.Customer.TerritoryID=Sales.SalesTerritory.TerritoryID;

Exec upsGetCusTerritory;


---------------------------
create procedure myprocedure2
@cid int
as
begin
     select * from Sales.customer where CustomerID=@cid
end

-------------------
execute myprocedure2 102
-----------------------------------------------------
select * from Sales.customer

create procedure myprocedure3
@cid int,
@result int output
as
begin
     select * from Sales.customer where CustomerID=@cid
	 set @result=500
end

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


----------------------------------

exec sp_helptext myprocedure2


-------------@@NestProcedure-------
/*
U stands for Table (user-defined). Check here for more info. 
The syntax OBJECT_ID is
here Object_type = 'U' which denotes Table (user-defined)
N Makes the String to be considered as nvarchar data type. It denotes that the subsequent string is in Unicode (the N actually 
stands for National language character set). Which means that you are 
passing an NCHAR, NVARCHAR or NTEXT value, as opposed to CHAR, VARCHAR 
*/

----The builtin @@NESTLEVEL function Returns the nesting level of the current 
--stored procedure execution (initially 0) on the local server

SELECT @@NESTLEVEL AS 'Max Precision'   
---------------------------------

USE AdventureWorks2012;  
GO  
IF OBJECT_ID (N'usp_OuterProc')IS NOT NULL  
    DROP PROCEDURE usp_OuterProc;  
GO  
IF OBJECT_ID (N'usp_InnerProc')IS NOT NULL  
    DROP PROCEDURE usp_InnerProc;  
GO  
CREATE PROCEDURE usp_InnerProc AS   
    SELECT @@NESTLEVEL AS 'Inner Level';  
GO  
CREATE PROCEDURE usp_OuterProc AS   
    SELECT @@NESTLEVEL AS 'Outer Level';  
    EXEC usp_InnerProc;  
GO  
EXECUTE usp_OuterProc;  
GO  


select * from employee
create clustered index mycluster on employee(empid)
create nonclustered index mynoncluster on employee(mobno);

drop index mynoncluster on employee with(Move to 'default')
SP_HELPINDEX 'employee'
select * from sys.indexes

select * from HumanResources.employee;

select vacationhours,SickLeaveHours from HumanResources.employee

create table calc_area(Length int,breadth int,area as Length*Breadth);
select * from calc_area;

---cursor is an temporary areawork also use for traverse the result one by one
-- into database it is two type 1)implicit (DML) 2)explicit
select * from HumanResources.employee;

DECLARE s1 CURSOR FOR SELECT * FROM HumanResources.employee;
OPEN s1
FETCH NEXT FROM s1;  --you can iterate this code one by one

/*FIRST is used to fetch only the first row from cursor table.
LAST is used to fetch only last row from cursor table.
NEXT is used to fetch data in forward direction from cursor table.
PRIOR is used to fetch data in backward direction from cursor table.
ABSOLUTE n is used to fetch the exact nth row from cursor table.
RELATIVE n is used to fetch the data in incremental way as well as decremental way.
Syntax : FETCH NEXT/FIRST/LAST/PRIOR/ABSOLUTE n/RELATIVE n FROM cursor_name*/
FETCH FIRST FROM s1
FETCH LAST FROM s1
FETCH NEXT FROM s1
FETCH PRIOR FROM s1
FETCH ABSOLUTE 7 FROM s1
FETCH RELATIVE -2 FROM s1

-----update cursor------------------
DECLARE @custname AS varchar(20);
SELECT @custname = 'Data Scientist';
DECLARE employee_cursor CURSOR FOR SELECT JobTitle FROM HumanResources.employee where 
businessEntityid=2;
OPEN employee_cursor;
FETCH NEXT FROM employee_cursor

WHILE @@FETCH_STATUS >0
  BEGIN
      UPDATE HumanResources.employee
      SET    JobTitle = @custname
      WHERE  CURRENT OF employee_cursor;
      FETCH NEXT FROM employee_cursor 
  END;
  close employee_cursor;
  deallocate employee_cursor;

  ------Scroll Cursor-------------------------------
 /*Scroll cursor comes with following fetch options

FIRST - fetches first row/record from the cursor result set
LAST - fetches last row from the cursor result set
PRIOR - fetches previous row from the current cursor position
NEXT - fetches next row from the current cursor position
RELATIVE n - fetches nth row from current cursor position
ABSOLUTE n - fetches nth row from the first cursor position
Here is how we can declare a scroll cursor.*/

DECLARE myCursor SCROLL CURSOR FOR
    SELECT AutoId, FirstName, LastName FROM PersonalDetails

OPEN myCursor
-- 1st row
FETCH NEXT FROM myCursor

-- last row
--FETCH LAST FROM myCursor

-- 2nd row from top
FETCH ABSOLUTE 2 FROM myCursor

-- 3rd row after current row
FETCH RELATIVE 2 FROM myCursor

-- 1st row
FETCH FIRST FROM myCursor

-- next row from current position
FETCH NEXT FROM myCursor
-- previous row from current position
FETCH PRIOR FROM myCursor

CLOSE myCursor
DEALLOCATE myCursor
---------------------End--------------------------

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

-----------update employee id-----
CREATE TRIGGER trgUpdateEmpId 
ON Employee
FOR update
AS
if update(id)
BEGIN

PRINT 'You can not update'
rollback
end

------------------
update employee set id=10 where id=5

----delete trigger-------------
CREATE TRIGGER trInsertEmployeedel2
ON Employee
for delete 
as
--delete from employee2 where id in(select id employee from deleted) 
if 6 in (select id from deleted)

BEGIN    
  print 'User can not be delete'
  rollback
END

--drop trigger trInsertEmployeedel2
-------------------
delete from Employee where id=6


--After Delete Trigger
CREATE TRIGGER Employee_Deletion
ON Employee
after delete 
as
BEGIN   
  DECLARE @num nchar;
  Select @num=count(*) from deleted 
  print 'No of employee deleted='+@num
 END

 -----------
 delete from Employee where id=4


 ----------create table employee2----
 CREATE TABLE Employee2
(
  Id int Primary Key,
  Name nvarchar(30),
  Salary int,
  Gender nvarchar(10),
  DepartmentId int
)

insert into Employee2 values(3,'Gita',20000,'Female',1)
select * from Employee;
 -----------------------------insted of trigger--------------------------------------------------------------------------------------------
--Instead Of triggers are executed instead of any of the Insert, Update or Delete operations.
--For example consider an Instead of Trigger for Delete operation, whenever a Delete is performed the Trigger will be executed first and if the Trigger deletes record then only the record will be deleted.

---Nested Query
select * from Employee where id in (select id from Employee2)

-----------
CREATE TRIGGER trInstedofdeleteEmployeede
ON Employee
instead of delete 
as
BEGIN
  delete from employee2 where id in(select id employee from deleted) 
  print 'Value Deleted successfull'
END

--delete from employee2
delete from Employee where Id=3;
--drop trigger trInstedofdeleteEmployeede

select * from Employee2;
select * from Employee;

sp_helptext trInstedofdeleteEmployeede

create TRIGGER altemp
ON employee
FOR INSERT
AS
BEGIN
  PRINT 'YOU CANNOT PERFORM INSERT OPERATION'
  ROLLBACK TRANSACTION
END

insert into Employee values(4,'Gita',20000,'Female',1,'1995-05-06')
---alter trigger---------


ALTER TRIGGER altemp 
ON employee
FOR INSERT
AS
if 101 in (Select id from inserted)
BEGIN
  PRINT 'YOU CANNOT PERFORM INSERT OPERATION'
  ROLLBACK TRANSACTION
END

insert into Employee values(101,'Anita',20000,'Female',1,'1995-05-06')

---DDL Trigger
create trigger secure
on	database
for DROP_TABLE,ALTER_TABLE
AS
Print 'You can not drop or alter table'


--drop table dcr
rollback

--Delete and drop tigger
CREATE TRIGGER emp_deletion
ON Employee
after delete 
as
BEGIN
  print 'Deletion will be effected other table'

  delete from employee2 where id in(select id employee from deleted) 
END


insert into Employee2 values(3,'Anita',20000,'Female',1)
select * from employee;
select * from employee2;
delete from employee where id=3


---after update

CREATE TRIGGER emp_update
ON Employee
after update 
as
BEGIN
  print 'You can not update'
  rollback
END

--drop trigger emp_update

update employee set name='arjun' where id=4

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
		where lastname='Abbass';
		rollback transaction;
		print N'Rolling back the transaction two times would cause an error';
	 end
 else
	 begin
		delete from person.person where lastname='Abbas'
		rollback Transaction;  --use for undo	
		print N'Rolled back the transaction';
	 end
 go
 -----------------------
  select * from person.person order by LastName asc
  -----------------------------

 use AdventureWorks2012
 go
 declare @listprice money
 set @listprice=(select max(listprice) from production.product)
 if @listprice>3000
	Print N'Amount Greater than 3000'
 else
   print N'Amount less than 3000'


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
Declare @a int
set @a=7
while (@a<=100)
begin
	insert into employee values(@a,'Ram',60000,'Male',2,'2020-06-02')
	set @a=@a+1
end

select * from employee2
select id,name,salary,gender,departmentid from employee2
select id,name,salary,gender,departmentid from employee

delete from employee2 where id>2 and id<9
--copy other table values and insert into other table

Declare @data int
set @data=1
while (@data<=10)
begin
	insert into employee2 select id,name,salary,gender,departmentid from employee where id=@data
	set @data=@data+1
end

-----
USE AdventureWorks2012;
GO
SELECT ROW_NUMBER() OVER(
       ORDER BY CustomerID) AS RowNum, 
       CustomerID, 
       SalesOrderID, 
       OrderDate, 
       SalesOrderNumber, 
       SubTotal, 
       TotalDue
FROM Sales.SalesOrderHeader;



-----
declare @sal float
declare @a int
set @sal=0
set @a=1

while @a<=select count(id) from employee2
begin
	select @sal=salary from employee2 where gender='male' and id=@a
	update employee2 set salary=(@sal+((@sal*5)/100)) where gender='male' and id=@a

	set @a=@a+1
end
-------------
select * from employee2


newid

--row_number
select ROW_NUMBER() OVER(ORDER BY id asc),id,salary from employee2
select RANK() OVER(ORDER BY id DESC),id,NAME from employee2
select dense_RANK() OVER(ORDER BY id DESC),id,NAME from employee2
select top 3 * from employee2 

---Function in sql server
--Scalar Functions
--A Scalar UDF accepts zero or more parameters and return a single value.
--
select * from employee2 
-------------------------

CREATE FUNCTION Getemployee(@Rno INT)  
 RETURNS VARCHAR(50)  
 AS  
BEGIN  
    RETURN (SELECT Name FROM employee2 WHERE id=@Rno)  
END 

-----run--
PRINT dbo.Getemployee(1)

-----------------
ALTER FUNCTION Getemployee(@myid INT)  
 RETURNS int  
 AS  
BEGIN  
    RETURN (SELECT salary FROM employee2 WHERE id=@myid)  
END  

----------run
PRINT dbo.Getemployee(1);
PRINT dbo.Getemployee(2);

--Table Valued Functions
--A Table Valued UDF accepts zero or more parameters and return a table variable. 
--This type of function is special because it returns a table that you can query 
--the results of a join with other tables 

CREATE FUNCTION GetEmployeeSalary(@sal INT)  
 RETURNS table 
 AS  
RETURN
( 
    SELECT salary FROM employee2 WHERE salary>=@sal
)

--RUN------
select * from GetEmployeeSalary(1000)

---Transaction is a single unit of statement
use AdventureWorks2012;
go
declare @tranName varchar(30);
select @tranName='FirstTransaction';
BEGIN TRANSACTION @tranName;
DELETE From HumanResources.JobCandidate where JobCandidateid=7;

--execute transaction
rollback
select * From HumanResources.JobCandidate 

-----
BEGIN TRANSACTION;
go
DELETE From HumanResources.JobCandidate where JobCandidateid=7;
go 
commit transaction;
go

--execute transaction
rollback
select * From HumanResources.JobCandidate 

#----------------
select max(len(jobtitle)),min(len(jobtitle)) From HumanResources.Employee
#-------------------------------
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

----------
select * from product

Print @@trancount
begin tran
	print @@trancount
	begin tran
		print @@trancount
		commit
	print @@trancount
	commit
print @@trancount


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

--run query without optimize

--optimize query using add non clustered index on quantity
create nonclustered index mynoncluster1 on Production.TransactionHistory(Quantity);
create nonclustered index mynoncluster2 on Production.TransactionHistoryArchive(Quantity)

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
SELECT * FROM sys.dm_tran_locks  WHERE request_session_id=58

  
 --insert 100 values into database using loop and variable
 declare @num int
 set @num=1
 while @num<=100
 begin
    insert into Demotable values(@num,'Python')
	set @num=@num+1
end

-------------
select * from DemoTable

-------update multiple values at same time
begin tran
update demotable set name='MS SQL Server'  where id<50
update demotable set name='PowerBI'  where id>50
select * from DemoTable
select @@spid   --session id

--check status of request
sp_who2 58

--By using NOLOCK with SELECT QUERY, we can overcome
select * from DemoTable with (nolock);

--For SELECT statement status using the sp_who2 command. 
--The query runs without waiting for the UPDATE
--transaction to be completed successfully and release the locking on the table

select * from DemoTable WITH (READUNCOMMITTED);

--------multiple if -------
declare @val int
set @val=15

if @val>=1 and @val<=10
   update demotable set name='Tableau'  where id<@val
else if @val>10 and @val<20
   update demotable set name='Data Science'  where id<@val
else
   print 'No Condition is match '


select * from demotable


#------Exception Handling------------
begin try
	declare @num int;
	select @num=217/0;
end try
begin catch
	print 'Error divide by zero '
end catch

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

----
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


-----------
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
-----------------------------------
RAISERROR (N'This is an error message %s %d',10,1,N'Serial Number',23);
GO
RAISERROR (N'%0.3s',10,1,N'Hello World');
GO

---for more information-----
https://learn.microsoft.com/en-us/sql/relational-databases/errors-events/database-engine-error-severities?view=sql-server-ver16

---------------------
BEGIN TRY
	SELECT 217/0;
END TRY
BEGIN CATCH
	SELECT ERROR_STATE() AS ErrorState;
END CATCH
GO

-----------------------------------------------
BEGIN TRY
	SELECT 217/0;
END TRY
BEGIN CATCH
	SELECT ERROR_SEVERITY() AS ErrorSeverity;
END CATCH
GO
---------------------------------------------------
USE AdventureWorks2012;
GO
IF OBJECT_ID ('ups_Example','p')IS NOT NULL
DROP PROCEDURE usp_Example;
GO 
CREATE PROCEDURE usp_Example
AS SELECT 217/0;
GO


BEGIN TRY
EXECUTE usp_Example;
END TRY
BEGIN CATCH
SELECT ERROR_PROCEDURE()
END CATCH
GO

-----------
BEGIN TRY
SELECT 217/0;
END TRY
BEGIN CATCH
SELECT ERROR_NUMBER() AS ErrorNumber;
select ERROR_MESSAGE() AS ErrorMessage;
END CATCH;
GO
--------------------------------------------------
USE AdventureWorks2012;
GO
BEGIN TRY
	SELECT * from product;
END TRY
BEGIN CATCH
SELECT
ERROR_NUMBER() AS ErrorNumber,
ERROR_MESSAGE() AS ErrorMessage;
END CATCH

----
drop table dbo.TestRethrow
-----------------
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
throw;
rollback;
END CATCH;

select * from dbo.TestRethrow


--not supported in sqlserver 2012 supported 2016 or above
select * from sys.tables
select * from employee for json auto


///////////////////////
declare @num1 as integer
declare @num2 as integer
declare @add as integer

set @num1=50
set @num2=60
set @add=@num1+@num2
print @add

#-----------------------
declare @a as integer
set @a=1
while (@a<=10)
begin 
	print(@a)
	set @a=@a+1
end

#----------------------------
declare @a as integer
set @a=1
while (@a<=10)
begin 
    if (@a%2=0)
	begin
		print(@a)
	end
	set @a=@a+1
end

#--------------------------------
declare @a as integer
set @a=11
while (@a<=20)
begin 
    if (@a%2!=0)
	begin
		print(@a)
	end
	set @a=@a+1
end

#----------------------------------
declare @a as integer
set @a=11
while (@a<=20)
begin 
    if (@a%2!=0)
	begin
		print(@a)
	end
	set @a=@a+1
end

#---------------Matrix
declare @a as integer
declare @b as integer
set @a=1
set @b=1
while (@a<=5)
begin 
 while(@b<=3)
	begin	
		print @a
		set @b=@b+1
	end
  set @a=@a+1
  set @b=0
end

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
create table t2
(
id int
)
insert into t2 values(0),(1),(0),(1)
insert into t2 values(0)

select * from t1
select * from t2

select t1.id,t2.id from t1 inner join t2 on t1.id=t2.id
