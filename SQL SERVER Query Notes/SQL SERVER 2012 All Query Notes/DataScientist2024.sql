create database DataScientist2024;
use DataScientist2024;

create table product
(
pid int primary key not null,
pName char(200) not null,
pPrice money null,
purDate date,
Adrs varchar(500)
)
select * from product;
insert into product values(101,'Mouse',2500.25,'11-25-2024','Meerut')
insert into product(adrs,pName,pid,pPrice,purDate) values
('Delhi','Computer',102,8052,'05-04-2024')
insert into product(adrs,pName,pid,pPrice,purDate) values
('kanpur','Laptop',103,8085,'04-25-2024')

select pid,pname from product

--we can not drop primary key based table if any foreign key link
--we can not delete values also if use into foreign key based table
drop table product
delete from product where pid=101;
--we can not run truncate if any foreign key is link
truncate table product;

-----Link Bill table to product table------
create table billing
(
Billno char(20) primary key not null,
pid int foreign key references product(pid),
sales money
)
select * from billing
insert into billing values('B001',101,6000)
insert into billing values('B002',101,8000)


--Delete, drop, truncate
create table info
(
id int primary key not null,
name varchar(100)
)
insert into info values(1,'James'),(2,'Anita')
select * from info;
--delete table 
drop table info;
--delete values according to criteria
--delete values one by one internally, we can pass parameter
delete from info;
delete from info where id=2;

--truncate use for empty the table
--it can not be parameterized, it is fast
truncate table info;



create table info
(
id int primary key not null,
name varchar(100)
)
insert into info values(1,'James'),(2,'Anita')

select * from info;

update info set name='Ritu' where id=2; 
select * from info;

--alter command work in structure on table
alter table info add marks float;
insert into info values(3,'Anil',80.25),(4,'Rupesh',70.26)

select * from info where id=1 or id=4
select * from info where id>2
select * from info where id between 1 and 3 
select * from info where id in (1,3)


--------------------
Create table customers
(
custid int primary key not null,
name varchar(100) not null,
mobno varchar(10)
)
insert into customers values(1,'Raj Mehta',9859585968),
							(2,'Sanjay Mishra',8659525478),
							(3,'Aditi Gupta',9858568587),
							(4,'Manish Chopra',784587458)
select * from customers

create table shopping_detail
(
itemid int primary key not null,
custid int foreign key references customers(custid),
item_Name varchar(100),
Quantity float
)
select * from shopping_detail;
insert into shopping_detail values(1,2,'Chips',2),
								   (2,3,'Chocolate',5)
select * from customers;		

select * from shopping_detail;
--self Join
select * from shopping_detail as s1 inner join shopping_detail as s2
on s1.custid=s2.Quantity

select * from shopping_detail as s1 left join shopping_detail as s2
on s1.custid=s2.Quantity

--Inner Join--
select * from customers inner join shopping_detail 
on customers.custid=shopping_detail.custid

--Left Join
select * from customers left join shopping_detail 
on customers.custid=shopping_detail.custid

--Right Join
select * from customers right join shopping_detail 
on customers.custid=shopping_detail.Quantity

--Outer Join
select * from customers full outer join shopping_detail 
on customers.custid=shopping_detail.Quantity

Use AdventureWorks2019;
Select * from HumanResources.Department

--Count Number of Employee Accroding to GroupName
select GroupName,count(GroupName) as 'No of Employee' from HumanResources.Department 
group by GroupName

--group by greater then 50 deptartment id
select GroupName,count(GroupName) as 'No of Employee' from HumanResources.Department 
where DepartmentID<=10
group by GroupName having count(GroupName)>=2


select * from Production.Product;
select * from Production.ProductInventory;

select p.ProductID,count(p.name) as 'Name',
count(p.SafetyStockLevel) as 'Safety Stock',
count(pp.Quantity ) as 'Quantity'
from Production.Product as p inner join Production.ProductInventory as pp
on p.ProductID=pp.ProductID where pp.Quantity>500
group by p.ProductID

-----Alter----
create table emp
(
empid int
)
select * from emp;
insert into emp values(101)
--Add Column
alter table emp add empname varchar(100)

update emp set empname='Anita' where empid=101
insert into emp(empname) values('James')

--Drop Column
alter table emp drop column empname


Use AdventureWorks2019;
Select * from HumanResources.Department
Select groupname,ModifiedDate from HumanResources.Department
--distinct show only unique values
Select distinct groupname,ModifiedDate from HumanResources.Department

--top show starting values
Select top 4 * from HumanResources.Department

--In use
Select * from HumanResources.Department where 
Name in ('Engineering','Marketing')

--order by use for sorting
Select * from HumanResources.Department order by departmentid desc;

Select * from HumanResources.Department order by name asc;

--identity is autogenerated
create table emp2
(
empid int identity(101,1),
empname varchar(100)
)
insert into emp2(empname) values('Gita')
select * from emp2

--like
Select * from HumanResources.Department where name like 'F%';

--subqueries
Select * from HumanResources.Department where Departmentid=
(select min(productid) from Production.Product )


select * from product
--CTE -Comman Table Expression

with productDis as
(
select (pprice*0.05) as 'Discount' from product
)
select * from productDis where Discount>300;

--Group by using salary
select * from salaries

--show highest salary after group by
with mysalary as
(
select position,sum(Salary) as 'Tot_Sal' from salaries group by position 
)
select max(Tot_Sal) from mysalary;

--Ranking Functions
--Dense Rank, Rank, row_number, ntile

select * from salaries

--show 2nd highest salary
with mysal as
(
select position,Salary, DENSE_RANK() over (order by Salary desc) 
as 'Dense_Salary' from salaries
)
select * from mysal where Dense_Salary=2;

--rank
with mysal2 as
(
select position,RANK() over (order by position desc) 
as 'Ranking' from salaries
)
select * from mysal2 ;

--dense rank
with mysal2 as
(
select position,Dense_RANK() over (order by position desc) 
as 'Dense_Rank' from salaries
)
select * from mysal2 ;

--row number
--dense rank
with mysal2 as
(
select position,row_number() over (order by position desc) 
as 'Row_Number' from salaries
)
select * from mysal2 ;

--ntile
with mysal2 as
(
select position,ntile(4) over (order by position desc) 
as 'ntile_Data' from salaries
)
select * from mysal2 ;

-------Index-----------------------------
create table myindex
(
stdid int primary key not null,
stdname varchar(100),
mobno varchar(10) unique
)
insert into myindex values(101,'James',9569858748)
select * from myindex

create table customer
(
cust_id int,
emailid varchar(100),
mobno varchar(10)
)
create clustered index Clst_indx on customer(cust_id);
create nonclustered index Clst_indx2 on customer(emailid);
insert into customer values(101,'aba@gmail.com',9585874878)
select * from customer

--Aggregate or string functions
select * from salaries;
select len(position) from salaries;
select left(position,4) from salaries;
select right(position,4) from salaries;
select substring(position,3,7) from salaries;
select sum(salary) from salaries;
select max(salary) from salaries;
select min(salary) from salaries;
select avg(salary) from salaries;

--View- it is virtual table store the resultset
select * from salaries;

create view mysalaries as
select * from salaries where salary>100000;

select * from mysalaries

--alter view
alter view mysalaries as
select * from salaries where salary>150000;

select * from mysalaries

insert into mysalaries values('CEO',10,550000)
delete from mysalaries;


drop view mysalaries

--copy one table data to other
insert into salaries select * from salaries2;

--view with Schemabinding
 --such as improved security and the creation of indexes on the view. 
 --However, they also have some limitations, such as restrictions on 
 --modifying the schema of the underlying tables 
 create view mysalView2 with schemabinding as
 select position,level,salary from dbo.salaries2 where salary>150000
 go


 select * from mysalView2;
 update mysalView2 set salary=454545 where level=9

 select * from dbo.salaries2
 update salaries2 set Salary=2569699 where level=9

 drop table dbo.salaries2 

CREATE TABLE dbo.Table1 (ID INT, Col1 VARCHAR(100))
GO  --go use for batch
CREATE VIEW dbo.FirstView
WITH SCHEMABINDING
AS
SELECT ID
FROM dbo.Table1
GO

DROP TABLE dbo.Table1
GO


-- CASE WHEN salary > 100000 THEN salary ELSE 0 END filters the salaries that are 
--greater than 100,000. If the condition is met, the salary is included in the 
--sum; otherwise, 0 is added.
SELECT 
    position,
    SUM(CASE WHEN salary > 100000 THEN salary ELSE 0 END) AS [Salary 100000]
FROM 
    salaries
GROUP BY 
    position;


----Union and union all----
--1)union show only unique values
--2)Show all values along duplicate

Create table custt1
(
custid int not null,
name varchar(100) not null,
mobno varchar(10)
)
insert into custt1 values(1,'Raj Mehta',9859585968),
							(2,'Sanjay Mishra',8659525478),
						    (2,'Sanjay Mishra',8659525478),
							(4,'Manish Chopra',784587458)
select * from custt1;


Create table custt2
(
custid int not null,
name varchar(100) not null,
mobno varchar(10)
)
insert into custt2 values(5,'Ritu',9859585968),
						  (6,'Anil',8659525478)
						    
select * from custt2;

--union show distinct/unique record
select * from custt1
union 
select * from custt2;

--union all show duplicate record also
select * from custt1
union all
select * from custt2;


--Batch
--is a group of two or more SQL statements or a single SQL statement that has the 
--same effect as a group of two or more SQL statements

create table exam
(
subject varchar(100)
)
insert into exam values('SQL')
select * from exam
go

--Difference
--1)Batch processing Groups transactions together and processes them without user 
--interaction. Batch processing can be done at any time,

--2)
--Transaction processing Processes transactions one at a time and 
--requires user interaction

--Transaction 
--Transactions group a set of tasks into a single execution unit.
--A transaction is a single unit of work.
Create table ct1
(
custid int not null,
name varchar(100) not null,
mobno varchar(10)
)
insert into ct1 values(1,'Raj Mehta',9859585968),
							(2,'Sanjay Mishra',8659525478),
						    (3,'Sanjay Mishra',8659525478),
							(4,'Manish Chopra',784587458)
select * from ct1;

--1)rollback transaction if not commit
begin transaction mytran;
delete from ct1 where custid=4;

--------
rollback;
select * from ct1;

--2)if you commit the transaction it will not rollback
begin transaction mytran;
delete from ct1 where custid=4;
commit;  --savepoint

--not rollback because it is commit/save
rollback;
select * from ct1;

-------

begin transaction datatran
WITH MARK N'Deleting a Customer Record'
go
use DataScientist2024;
go
delete from ct1 where custid=2;
go
commit tran datatran;
go


--it can not be rollback;
rollback;
select * from ct1;

------------Interview Question-------------------
use DataScientist2024;
create table empdata
(
empname varchar(100),
cityname varchar(100)
)
insert into empdata values('A','MRT'),('B','DL'),('C','MRT'),('D','MUMBAI')
select * from empdata;

--
select e1.empname, e1.cityname from empdata as e1 inner join empdata as e2
on e1.cityname=e2.cityname and e1.empname!=e2.empname;

--Stored Procedure--
--A stored procedure is a prepared or pre Compiled SQL code that you can 
--save, so the code can be reused over and over again. So if you have 
--an SQL query that you write over and over again, save it as a stored
--procedure, and then just call it to execute it.
----stored procedure can be parametrized
go
create procedure myproc as
select * from empdata where empname='A'

exec myproc;

--stored procedure with parameter
--@ use for declare variable
go
create procedure sp_Para 
@name varchar(10) as
select * from empdata where empname=@name;

--execute the sp
exec sp_Para 'B';

exec sp_Para 'C';

---------Sp------------
use DataScientist2024;
create table std1
(
id int,
sname varchar(50)
)
insert into std1 values(1,'A'),(3,'B'),(2,'C')

create table std2
(
id int,
city varchar(50)
)
insert into std2 values(2,'Meerut'),(1,'Kanpur'),(3,'Delhi'),(3,'Meerut')

select * from std1;
select * from std2;

select s1.id,s1.sname,s2.city  from std1 as s1 inner join std2 as s2
on s1.id=s2.id order by s1.id asc

-------------go use for batch------------------------
go
create procedure citywise as
select s2.city,count(s2.city)as 'Total City' from std1 as s1 inner join std2 as s2
on s1.id=s2.id group by s2.city


exec citywise;


--alter procedure
go
alter procedure citywise as
select s2.city,count(s2.city)as 'Total City' from std1 as s1 inner join std2 as s2
on s1.id=s2.id group by s2.city having city='Delhi'


exec citywise;


-----------conditional---
--run complete code as once---
--declare Variable
--varibale is the memory container to hold value int memory location
declare @num1 as int
declare @num2 as int
declare @sum as float

--assign values
set @num1=50
set @num2=60
set @sum=@num1+@num2

--display values
select @sum as 'Total'

--Condition--use to test any expession
declare @age as int
set @age=17
if @age>=18
	print 'Eligible for Vote'
else
	print 'Not Eligible for Vote'

--Loop use for iterate the particular set of statement
declare @a as int
set @a=1
while @a<=5
	print 'While Loop'
	set @a=@a+1


--------------------------------------------
use DataScientist2024;
Create table custt1
(
custid int not null,
name varchar(100) not null,
mobno varchar(10)
)
insert into custt1 values(1,'Raj Mehta',9859585968),
							(2,'Sanjay Mishra',8659525478),
						    (2,'Sanjay Mishra',8659525478),
							(4,'Manish Chopra',784587458)
select * from custt1;


Create table custt2
(
custid int not null,
name varchar(100) not null,
mobno varchar(10)
)
insert into custt2 values(5,'Ritu',9859585968),
						  (6,'Anil',8659525478)
						    
select * from custt2;

insert into custt2 values(4,'Manish Chopra',784587458)
--union show distinct/unique record
select * from custt1
select * from custt2;

select * from custt1 as c1 where exists (select * from custt2 as c2 where c1.custid=c2.custid);
select * from custt1 as c1 where not exists (select * from custt2 as c2 where c1.custid=c2.custid);

--Windows Functions
--Aggregate
select * from salaries
select avg(Salary)as 'Average Salary' from salaries
select count(*)as 'Total Rows' from salaries
select max(Salary)as 'Maximum Salary' from salaries
select min(Salary)as 'Minimum Salary' from salaries
select sum(Salary)as 'Total Salary' from salaries

--Ranking Function
select *, 
row_number() over(order by salary asc)as 'Row Number',
dense_rank() over(order by salary asc)as 'Dense Rank',
rank() over(order by salary asc)as 'Rank',
ntile(4) over(order by salary asc) as 'Quatarly'
from salaries

select * from salaries
--Analytic Function
select *, 
last_value(salary) over(partition by position order by position asc)as 'last Value'
from salaries

select *, 
first_value(salary) over(partition by position order by position asc)as 'last Value'
from salaries

select *, 
first_value(salary) over(partition by position order by position asc)as 'fist Value'
from salaries


-- A trigger is a special type of stored procedure that automatically runs when an event 
--occurs (DML Query) in the database server
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


select * from Employee;

---
create trigger mytrigger on employee
for insert
as
if (select salary from inserted)<9000
begin
	print('You can not insert Salary Less then 9000')
	rollback transaction;
end;

--checking trigger
INSERT INTO Employee VALUES (4,'Anurag', 65000, 'male', 1)


alter table employee add dob date;
select * from employee;

---second trigger---
CREATE TRIGGER trgUpdateEmployee 
ON Employee
FOR update
AS
if (select dob from inserted)>GETDATE()
BEGIN
PRINT 'Date of birth cannot be greater than today date'
rollback
end;


select * from employee;
update employee set dob='2024-01-06' where id=4;





