create database AptechDataSciece2023
use AptechDataSciece2023
create table laptop
(
 laptopcode int not null,
 laptopname char(100) not null,
 mobno char(10) null,
 price money
)
select * from laptop
insert into laptop values(101,'HP Laptop','4585969858',50000)

create table student
(
rollno int not null,
name char(100),
stdadd varchar(500),
dob date,
enrolltime time,
fees money,
marks float,
comment text
)
insert into student values(101,'james','Meerut','2000-05-20','9:00',5000,82,'Thankyou')
insert into student(rollno,name,stdadd,marks) values(102,'Hari','Meerut',80.25)
select * from student
select rollno,name from student
select * from student where rollno=101
select * from student where rollno in(102,104)
select * from humanresources.employee where businessEntityID>10
select * from humanresources.employee where jobtitle in('Marketing Manager','Marketing Assistant')
select * from humanresources.employee where businessEntityID>10 and businessEntityID<20
select * from humanresources.employee where businessEntityID between 10 and 20
select * from humanresources.employee where jobtitle like 'senior%'
select * from humanresources.employee where jobtitle like '_h%f%O%'
select * from humanresources.employee where contains(JobTitle,'Buyer') 

update student set dob='1995-05-06',fees=5600 where rollno=102
delete from student where rollno=102
select * from student
--drop table student
truncate table student

-----primary key should be implemented------------------------
select rollno,name from student where contains(name,'hari')
-------------how to declare variable----------------------
declare @num as integer
set @num=50
select @num+60 as 'Number'

declare @num2 as integer
select @num2=60 
select @num2

-------------------Windows Functions--------------------------------------
-------------Aggregate Function-----------------------------------------------
select sum(vacationHours) from humanresources.employee
select max(vacationHours) from humanresources.employee
select min(vacationHours) from humanresources.employee
select avg(vacationHours) from humanresources.employee
select count(vacationHours) from humanresources.employee
--------------ranking function-----------------------------

select * from humanresources.employee
select * from humanresources.employeepayhistory
select rate, rank() over(order by rate) from humanresources.employeepayhistory
select rate, dense_rank() over(order by rate) from humanresources.employeepayhistory
select rate, row_number() over(order by rate) from humanresources.employeepayhistory
select rate, ntile(4) over(order by rate) from humanresources.employeepayhistory

--------type casting-------------
declare @d as float
set @d=65.25
select Cast(@d as integer)

declare @k as float
set @k=56.14
select CONVERT(int, @k)

----------Date time-------------
select birthdate from humanresources.employee
select GETDATE()
select SYSDATETIME()
select month(GETDATE())
select day(GETDATE())
select year(GETDATE())

------Rounding function-----------
select rate from humanresources.employeepayhistory
select round(rate,2) from humanresources.employeepayhistory
select round(rate,0) from humanresources.employeepayhistory
select round(rate,0) from humanresources.employeepayhistory
select round(rate,0) from humanresources.employeepayhistory
select ceiling(rate) from humanresources.employeepayhistory
select floor(rate) from humanresources.employeepayhistory
select abs(-50)
select power(2,3)

------System function-----------
select HOST_NAME()
select HOST_ID()

----------String function-------------
select JobTitle from humanresources.employee
select left(JobTitle,4) from humanresources.employee
select right(JobTitle,4) from humanresources.employee
select '    hello'
select ltrim('    hello') 
select rtrim('    hello    ')
select upper(JobTitle) from humanresources.employee
select lower(JobTitle) from humanresources.employee
select replace('data analytics','analytics','Science')

------------Batch are compiled into single executable unit----------------
create table laptop2
(
 laptopcode int not null,
 laptopname char(100) not null,
 mobno char(10) null,
 price money
)
insert into laptop2 values(101,'HP Laptop','4585969858',50000)
select * from laptop2
go
--------------Group by--------------
create table employee
(
empcode int primary key not null,
empname char(100) not null,
city varchar(50),
salary money
)
select * from employee
insert into employee values(101,'James','Meerut',50000),(102,'Hari','Meerut',40000),
							 (103,'Gita','Delhi',45000),(104,'Kavita','Delhi',65000)
insert into employee values(105,'Harsh','Kanpur',150000),(106,'Anita','Kanpur',200000)

select city,sum(salary) as empsalary from employee group by city
select city,sum(salary) as empsalary from employee group by city order by empsalary asc
select city,sum(salary) as empsalary from employee group by city having sum(salary)>100000
																	order by empsalary desc 
select city,sum(salary) as empsalary from employee where empcode>102 group by city
select city,sum(salary) as empsalary from employee where empcode>102 group by city 
														having sum(salary)<400000
																	

update employee set empname='Anil' where empcode=102
delete from employee where empcode=102
select * from employee
--drop table employee
truncate table employee

------------Alter use for table structure modification------------------
create table tbl1
(
tid int,
name char(50)
)
select * from tbl1
insert into tbl1 values(101,'james')
insert into tbl1(tid,name) values(103,'Gita')
--drop table tbl1
alter table tbl1 add addres varchar(100)
alter table tbl1 add mobno char(12) default 0
alter table tbl1 drop constraint DF__tbl1__mobno__36B12243
alter table tbl1 drop column mobno
alter table tbl1 add comments char(30)
alter table tbl1 alter column comments varchar(300)
alter table tbl1 alter column tid int not null
alter table tbl1 add primary key(tid)

create table empdata
(
empid int identity(101,1)primary key not null,
name char(200) null
)
select * from empdata
insert into empdata(name) values('Gita')
 
 create table empdata2
(
empid int identity(101,1)primary key not null,
name char(200) null,
securitycode uniqueidentifier default newid() not null
)
go
insert into empdata2(name) values('anil')
select * from empdata2

--drop table employee
create table employee
(
empcode int,
empname char(100),
salary money
)
select * from employee
insert into employee values(101,'james',45000),(102,'Gita',60000),(103,'Anil',35000)
insert into employee values(107,'Karan',35000)

---this method fail when duplicate values occur in table
select * from employee
select * from employee order by salary desc
select * from employee order by salary desc OFFSET 2 ROWS
FETCH NEXT 1 ROWS ONLY

------sub Query we can also find 2nd highest salary----
-----but this method become more complex when we find 3, 4 or many highest---
select top 1 * from employee where salary<(select max(salary) from employee)

--------third highest------------------
select * from employee
select  * from employee where salary<(select max(salary) from employee where
salary<(select max(salary) from employee))

-----------second highest salary using dense----------
select *, DENSE_RANK() over(order by salary desc) from employee

----------second highest salary using desnse rank with CTE(common Table Expression )
with calsalary as
(
select *,DENSE_RANK() over(order by salary desc) as msalary from employee
)
select * from calsalary where msalary=2 

--------------------------with multiple condition-------------------------
with calsalary as
(
select *,DENSE_RANK() over(order by salary desc) as msalary from employee
)
select * from calsalary where msalary=1 and empname like 'K%'


-----------------data Modeling and data relationship-------------------
create table employee1
(
empid int primary key not null,
empname char(100) not null,
emplicens
)

-----------------------------------------------------------------------------------
create table department
(
depid int primary key not null,
Designation varchar(200) not null
)
insert into department values(2,'BPO'),(3,'Account'),(5,'IT')
select * from department

create table employee
(
empid int primary key not null,
empname varchar(200) not null,
emplicence varchar(50) unique not null,
emppassport varchar(50) unique not null,
did int foreign key references department(depid)
)
--drop table employee
insert into employee values(001,'Tom','EL101','PA123',2)
insert into employee values(006,'John','EL103','PA126',5)
select * from employee

--------Composite key-----------------
--drop table salaryTable
create table salarytable
(
emid int not null,
salary_month datetime not null,
amount money,
constraint emp_pk2 primary key (emid,salary_month),   --composite 
constraint K_emp2 foreign key (emid) references employee(empid)
)

insert into salarytable values(9,'2023-05-2',90000.25)
insert into salarytable values(6,SYSDATETIME(),90000.25)
select * from salarytable
select SYSDATETIME()
delete from salarytable where emid=6

----------delete duplicate values-------using cte
with sal_cte as
(
select *,row_number() over(order by emid asc) as rnumber from salarytable
)
delete from sal_cte where rnumber=3

----------------------join-------------------
------inner join
select * from department
select * from employee
select * from employee as e inner join department as d on e.did=d.depid

----------------------------------------------------------------------------
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



use AdventureWorks2019
select * from Person.Person
select * from HumanResources.Employee 

select * from HumanResources.Employee as h inner join Person.Person as p on h.BusinessEntityID=p.BusinessEntityID

-------
--left outer join
select * from sales.Customer 
select distinct StoreID from sales.Customer 
select * from sales.SalesOrderHeader

select A.CustomerID,B.DueDate,B.ShipDate from Sales.Customer as A Left outer join
sales.SalesOrderHeader as B on A.CustomerID=B.CustomerID 

---Right Outer Join----------
select A.CustomerID,B.DueDate,B.ShipDate from Sales.Customer as A right outer join
sales.SalesOrderHeader as B on A.CustomerID=B.CustomerID 


select * from employee
select * from department
select * from employee as e left outer join department as d on e.did=d.depid


select * from employee
select * from department
select * from employee as e right outer join department as d on e.did=d.depid


------self join----------
select * from employee
select e.empname from employee as e inner join employee as p on e.empid=p.did

select * from employee
select * from department
select * from employee as e cross join department as p

-----------------------union----------
--drop table employee2
create table employee2
(
empid int primary key not null,
empname varchar(200) not null,
emplicence varchar(50) unique not null,
emppassport varchar(50) unique not null,
)
--drop table employee
insert into employee2 values(001,'Tom','EL101','PA123'),(006,'John','EL103','PA126')
select * from employee2

--drop table employee3
create table employee3
(
empid int primary key not null,
empname varchar(200) not null,
emplicence varchar(50) unique not null,
emp_port varchar(50) unique not null,
--addrs varchar(100)
)
--drop table employee
insert into employee3 values(001,'Tom','EL101','PA123'),(005,'John','EL103','PA126')
--insert into employee3 values(001,'Tom','EL101','PA123','Meerut'),(005,'John','EL103','PA126','Delhi')
select * from employee3

---All queries combined using a UNION, INTERSECT or EXCEPT operator must have an equal number of expressions in their target lists.
select * from employee2 union select * from employee3
select * from employee3 union all select * from employee2

--------------------
create database employeedatabase2 on primary
(
    NAME = employee_dbb,
  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\
  employee_db.mdf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 50MB
)
log on
(
   NAME = employee_log,
  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\
  employeelog.ldf',
	SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)

---------to add secondry file after 
ALTER DATABASE employeedatabase2 
ADD FILE 
(
    NAME = employee_ndf_file,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\
	employee_ndf_file.ndf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)
GO

-----------------------.mdf .ldf. .ndf--------------------------------------------
create database employeedatabase on primary
(
    NAME = employee_dbb,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\
	employee_dbb.mdf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 50MB
),
FILEGROUP myemployee_nd_group_1
(
    NAME = employee_ndf1,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\
	employee_ndf1.ndf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
),
FILEGROUP myemployee_nd_group_2
(    NAME = employee_ndf2,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\
	employee_ndf2.ndf',
    SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)log on
(   NAME = employee_log,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\
	employeelogg.ldf',
	SIZE = 5MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB
)


----------------create snap shot file ---------------
CREATE DATABASE AdventureWorks_dbss1800 ON (
    NAME = AdventureWorks2019,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\
	AdventureWorks_data_1800.ss'
    ) AS SNAPSHOT OF AdventureWorks2019;
GO

-------------Group by and join with CTE--------------------------
create table employee2
(
empid int primary key not null,
empname varchar(200) not null,
emplicence varchar(50) unique not null,
emppassport varchar(50) unique not null,
)
--drop table employee
insert into employee2 values(001,'Tom','EL101','PA123'),(006,'John','EL103','PA126')
select * from employee2

--drop table employee3
create table employee3
(
empid int primary key not null,
empname varchar(200) not null,
adrs varchar(300) not null,
mobno bigint

)
--drop table employee
insert into employee3 values(001,'Tom','Meerut',9562365821),
(005,'John','Delhi',9521474587)
insert into employee3 values(006,'John','Delhi',9584587458)
insert into employee3 values(009,'Hari','Ghaziabad',9584587458)
select * from employee3

select * from employee2
select * from employee3

with jresult as
(
select e1.empname,e2.adrs from employee2 as e1 inner join employee3 as e2 on 
e1.empid=e2.empid
)
select j.empname,count(j.adrs) as 'Total' from jresult as j group by j.empname



-------VIEW is the virtual/temporary table------------------
create view myview
as
select * from employee3 where empid>2

----------------------------
select * from myview
update myview set empname='Kavita' where empid=1
delete from myview where empid=1

drop view myview --

---------------------------
exec sp_help  myview
exec sp_helptext myview

---------------------------------------------------

with jresult as
(
select e1.empname,e2.adrs from employee2 as e1 inner join employee3 as e2 on 
e1.empid=e2.empid
)
select j.empname,count(j.adrs) as 'Total' from jresult as j group by j.empname

-----we can not do DML operation on view using join--------------
select * from joinview 
delete from joinview where empname='Tom'
update joinview set total=2 where empname='Tom'

---------we can not alter the view------------
create view myview2
as
select empid,empname from employee3 where empid>2

select * from myview2
insert into myview2 values(9,'James')
delete from myview2 where empid=6

---------------------------
select * from employee2
select * from employee3

select * from employee2 as e inner join employee3 as ea on e.empid=ea.empid

select e.empid,e.empname,e.emppassport,ea.adrs,ea.mobno from employee2 as e 
inner join employee3 as ea on e.empid=ea.empid

-------create view----------
create view myview3 as
(
select e.empid,e.empname,e.emppassport,ea.adrs,ea.mobno from employee2 as e 
inner join employee3 as ea on e.empid=ea.empid
)

select * from myview3
---------we can not perform DML Operation on view----------------
insert into myview3 values(7,'Anil','PA128','Kanpur',956856958)
delete from myview3 where empid=6


------------procedure can be parameterized much better as compare to view-------------
exec sp_helptext myview3
create proc sp_mysp1 as
(
select e.empid,e.empname,e.emppassport,ea.adrs,ea.mobno from employee2 as e 
inner join employee3 as ea on e.empid=ea.empid
)

exec sp_mysp1

-----------------
select * from employee3

create proc sp_myproc2 as
select * from employee3 where empid>1


exec sp_myproc2
--we can not perform insert,update,delete on sp
insert into sp_myproc2 values(9,'Gita','Meerut',9569695847)

---------we can alter the stored procedure--------------
alter proc sp_myproc2 as
select * from employee3 where empid>1
select * from employee2

exec sp_myproc2

------sp with parameters--------------------------
create proc sp_myproc3 
@city varchar(100) as
select * from employee3 where adrs=@city


exec sp_myproc3 'Meerut'
exec sp_myproc3 'Ghaziabad'

drop sp_myproc3

-------------Index----------------------
create table deptinfo
(
deptid int,
name varchar(50),
address varchar(100)
)
select * from deptinfo

declare @a as int
set @a=1
while @a<=100
begin
	insert into deptinfo values(@a,'James','Meerut')
    set @a=@a+1
end

---------add index---------------------
create index myindex on deptinfo(deptid)

drop index myindex on deptinfo 
---------add clustered on unique column---------------------
create clustered index myindex on deptinfo(deptid)

----------add non-clustered index on duplicate---
create nonclustered index mynonclustered on deptinfo(name) 

---------add clustered on duplicate values---------------------
create clustered index myindex on deptinfo(address)


-------add unique non-clustered
--we can not create on duplicate values based column
create unique nonclustered index myindex on deptinfo(address)

-------------------------
create unique nonclustered index myindex on deptinfo(deptid)
-----we can add same column clustered and non-clustered both----------
create unique clustered index myindex2 on deptinfo(deptid)

-------Cursor traverse one by one--------------
use AdventureWorks2019;
select * from HumanResources.employee;

DECLARE s1 CURSOR FOR SELECT * FROM HumanResources.employee;
OPEN s1
FETCH NEXT FROM s1;  --you can iterate this code one by one
close s1;

---------------------------------------------------------------
SELECT * FROM HumanResources.employee
-----update cursor------------------
set nocount on
DECLARE employee_cursor CURSOR FOR SELECT JobTitle FROM HumanResources.employee 
for update of JobTitle
OPEN employee_cursor;
FETCH NEXT FROM employee_cursor
WHILE @@FETCH_STATUS =0
  BEGIN
      UPDATE HumanResources.employee
      SET    JobTitle = 'Data Scientist'
      WHERE  CURRENT OF employee_cursor;
      FETCH NEXT FROM employee_cursor 
  END;
  close employee_cursor;
  deallocate employee_cursor;
set nocount off


--------------update using CTE just working as cursor-----------
SELECT * FROM HumanResources.employee
-----------------------------------
with C as
(
  select businessEntityid,
         9 + row_number() over(order by BusinessEntityID asc) as NewEmpNo
  from HumanResources.employee     
)
update C
set businessEntityid = NewEmpNo

----------------------------trigger----------------------
 --drop table employee3
 CREATE TABLE Employee3
(
  Id int Primary Key,
  Name nvarchar(30),
  Salary int,
  Gender nvarchar(10),
  DepartmentId int
)
GO

-- Insert data into Employee table
INSERT INTO Employee3 VALUES (1,'Pranaya', 50000, 'Male', 3)
INSERT INTO Employee3 VALUES (2,'Priyanka', 54000, 'Female', 2)
INSERT INTO Employee3 VALUES (3,'Anurag', 65000, 'male', 1)
INSERT INTO Employee3 VALUES (4,'sambit', 47000, 'Male', 2)
INSERT INTO Employee3 VALUES (5,'Hina', 66000, 'Female', 3)
select * from employee3;
go



select * from Employee3
CREATE TRIGGER trInsertEmployee 
ON Employee3
FOR INSERT
AS
if (select salary from inserted) < 9000
BEGIN
  PRINT 'YOU CANNOT PERFORM INSERT OPERATION'
  ROLLBACK TRANSACTION
END
------------------------
INSERT INTO Employee3 VALUES (7,'Hina', 86000, 'Female', 3)

--------update Trigger------------------
CREATE TRIGGER trupdateEmployee 
ON Employee3
FOR update
AS
if update(salary)
BEGIN
  PRINT 'YOU CANNOT PERFORM Update OPERATION'
  ROLLBACK TRANSACTION
END
--------------
update employee3 set salary=40000 where id=3 

----------------Delete Trigger-------------------
CREATE TRIGGER trdeleteEmployee 
ON Employee3
FOR delete
AS
if 5 in (select id from deleted)
BEGIN
  PRINT 'YOU CANNOT PERFORM DELETE OPERATION'
  ROLLBACK TRANSACTION
END

----------------------------------
delete from employee3 where id=5

---------------------------------
select * from employee
select * from employee3 

---------instead of delete trigger----------
CREATE TRIGGER instead_deleteEmployee 
ON Employee3
instead of delete
AS
begin 
 delete from employee where empid in (select id from deleted)
 print 'Delete Successfully'
end

-----------------------
delete from employee3 where id=1
sp_help employee

------------
---------Synonym----------------
--A synonym is a database object that serves the following purposes: Provides an 
--alternative name for another database object, referred to as the base object, 
--that can exist on a local or remote server.

 select * from dbo.dept

 create synonym mysny2
 for employee.dbo.dept
 go

 select * from sys.synonyms;
 
--drop synonym mysny2
SELECT TOP 10 * FROM dbo.mysny2

-------variable-------
declare @a as integer
set @a=1

---------condition-------
if @a>0
	begin
		print 'Condition True'
	end
else
	begin
		print 'Condition False'
	end

---loop----use for iterate block of statement--
declare @num as integer
set @num=1            --Initilization
while @num<=10        --condition
begin
	print @num       
	set @num=@num+1   --Increment/Decrement
end

------loop in reverse-------------
declare @n as integer
set @n=10            --Initilization
while @n>=1        --condition
begin
	print @n       
	set @n=@n-1   --Increment/Decrement
end
-----------Even with condition-----------
declare @c as integer
set @c=1 
while @c<=20 
begin
	if @c%2=0
		begin
			print @c
			set @c=@c+1
		end
    else
		begin
			set @c=@c+1
		end
end

---------break use for exit the loop----------
declare @d as integer
set @d=1 
while @d<10
begin
	if @d=5
		begin
			break
		end
	print @d
	set @d=@d+1
end
-------continue use for skip----
declare @k as integer
set @k=1 
while @k<10
begin
	if @k=5
		begin
		    set @k=@k+1 
			continue
		end
	print @k
	set @k=@k+1
end

------------prime Number---------
declare @t as integer
set @t=1
declare @p as integer
set @p=10
declare @cntr as integer
set @cntr=0

while @t<=@p
begin
	if @p%@t=0
		begin
		set @cntr=@cntr+1
		set @t=@t+1
		end
	set @t=@t+1
end
if @cntr=2
begin	
	print 'Prime Number'
end
else
begin
	print 'Not Prime Number'
end

------------
use AptechDataSciece2023
select * from employee3

select salary*0.5 as Bonus from employee3 where Salary>=50000	

------find out Different slab of bonus on salary------

DECLARE @h AS INT;
DECLARE @g AS INT;
SET @g = 1;

WHILE @g <= 5
BEGIN
    SELECT TOP 1 @h = salary * 0.5
    FROM (
        SELECT salary, ROW_NUMBER() OVER (ORDER BY salary) AS rownumber
        FROM Employee3
    ) AS RankedSalaries
    WHERE rownumber = @g;

    PRINT @h;
    SET @g = @g + 1;
END


----------------Transaction-----
select * from student
----------------------------------------
begin transaction
go
delete from student where rollno=101
------------------------------
rollback tran
------to save all work using commit----can't rollback-------
begin transaction stdelete with mark N'Deleted value save Successfully'
go
delete from student where rollno=102;
go
commit tran stdelete 
------------------------------
rollback tran stdelete
----------------------------------------------
use AdventureWorks2019
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

Print @@trancount
begin tran
	print @@trancount
	begin tran
		print @@trancount
		commit
	print @@trancount
	commit
print @@trancount

--------------Exception/ Error Handling------------------
begin try
  declare @num1 as integer
  select @num1=217/0
end try
begin catch
		print N'Divide By Zero Error'
end catch
---------------------------------
begin try
  declare @num2 as integer
  select @num2=217/0
end try
begin catch
		print N'Divide By Zero Error'
		select ERROR_NUMBER() as 'ErrorNumber',
		 ERROR_LINE() as 'Error Line'
end catch

select * from employee3 
select * from employee3 for json auto
select * from employee3 for json path