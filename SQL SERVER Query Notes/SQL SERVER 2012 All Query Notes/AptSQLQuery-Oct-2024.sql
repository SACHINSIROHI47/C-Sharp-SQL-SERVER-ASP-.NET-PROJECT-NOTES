create database AptDataScience2024;
use AptDataScience2024;

create table studentReg
(
reg int,
sname char(50),
dob date,
fees float
)

select * from studentReg;
insert into studentReg values(101,'Ram','1995-05-02',5000)
insert into studentReg values(102,'James','1990-06-01',6000)

select * from studentreg where reg=102;
select reg,sname from studentReg


--use Adventure works sample database
use AdventureWorks2019
select * from HumanResources.Employee;
select * from HumanResources.Employee where BusinessEntityID=1;
select * from HumanResources.Employee where BusinessEntityID<=10;
select * from HumanResources.Employee where BusinessEntityID>=10 and BusinessEntityID<=20;
select * from HumanResources.Employee where BusinessEntityID between 10 and 20;

select * from HumanResources.vEmployeeDepartment;
select * from HumanResources.vEmployeeDepartment where Department='Executive' or 
Department='Engineering';
select * from HumanResources.vEmployeeDepartment where Department in ('Executive','Engineering');

select * from HumanResources.vEmployeeDepartment where Department like 'E%';
select * from HumanResources.vEmployeeDepartment where Department like '__f%';

select VacationHours,VacationHours+5 as 'Total Vacation' from HumanResources.Employee;


--Primary key, Foreign key, Unique key
create table dept
(
deptno int primary key not null,
deptname char(200) not null,
location varchar(500) not null
)
select * from dept;
insert into dept values(90,'IT','Meerut'),(95,'ML-AI','Delhi');

create table employee
(
empid int primary key not null,
empname varchar(200) not null,
aadhar bigint unique,
salary money not null,
deptno int foreign key references dept(deptno)
)

select * from employee;
insert into employee values(101,'James',995656565,265695.25,90)


create table qualification
(
empid int foreign key references employee(empid) unique,
graduation varchar(200) not null,
postgraduation varchar(300),
certification varchar(400)
)

--drop table qualification
insert into qualification(empid,graduation,certification) values(101,'BCA','Data Science');
select * from qualification;

--Group by 
select * from dbo.salaries;
select position,sum(salary) from salaries group by position;
select position,sum(salary) from salaries group by position;

--Aggregate Function
select sum(salary) from salaries;
select avg(salary) from salaries;
select max(salary) from salaries;
select min(salary) from salaries;

--order by
select * from dbo.salaries order by salary asc;
select * from dbo.salaries order by salary desc;

--
select * from studentclass;
select * from studentmarks;

select count(*) as 'Total Rows' from studentmarks;
select class,sum(marks) as 'Total marks' from studentmarks group by class order by class desc;



select * from dbo.salaries;
update dbo.salaries set salary=600000,position='AI-ML Expert' where level=9; 

--delete records
delete from dbo.salaries where level=8;

create table std_detd
(
std_id bigint identity(100001,1) not null,
std_name varchar(100) not null,
mobno varchar(20) default 0,
age int check (age>=18)
);

select * from std_detd;
insert into std_detd(std_name,mobno,age) values('James','9586958587',20)
insert into std_detd(std_name,age) values('James',20)

select * from dbo.customers1;
select * from dbo.customers2;

--distinct show only unique values
select distinct * from dbo.customers1;

--union show the unique record once
select * from dbo.customers1
union
select * from dbo.customers2;

--union all show the duplicate record
select * from dbo.customers1
union all
select * from dbo.customers2;

---Sub Query
use AdventureWorks2019;
select * from HumanResources.Department;
select * from HumanResources.EmployeeDepartmentHistory;


select * from HumanResources.Department where DepartmentID in(
select distinct DepartmentID from HumanResources.EmployeeDepartmentHistory where ShiftID=3)

----Joins-------
create table tbl1
(
empid int,
ename varchar(100)
)
insert into tbl1 values(101,'James'),(102,'Gita'),(103,'Anita')
select * from tbl1

create table tbl2
(
empid int,
eadd varchar(100)
)
insert into tbl2 values(101,'Meerut'),(102,'Lucknow'),(104,'Delhi')
select * from tbl2

select * from tbl1;
select * from tbl2;

--left join
select * from tbl1 left join tbl2 on tbl1.empid=tbl2.empid;

--right join
select * from tbl1 right join tbl2 on tbl1.empid=tbl2.empid;

--outer join
select * from tbl1 full outer join tbl2 on tbl1.empid=tbl2.empid;

--cross join
select * from tbl1 cross join tbl2;

--Inner Join
select tbl1.empid,tbl1.ename,tbl2.eadd from tbl1 inner join tbl2 on tbl1.empid=tbl2.empid;

--inner join with alias
select t1.empid,t1.ename,t2.eadd from tbl1 as t1 inner join tbl2 as t2 on t1.empid=t2.empid;

--self join--
create table myself
(
empid int,
ename varchar(100),
bus_id int
)
insert into myself values(101,'James',102),(102,'Gita',104),(103,'Anita',101)
select * from myself

select * from myself as m1 inner join myself as m2 on m1.empid=m2.bus_id;

select m1.empid,m1.ename,m2.bus_id from myself as m1 inner join myself as m2 on m1.empid=m2.bus_id;

--Joins with Groupby
use AdventureWorks2019;
select * from HumanResources.Employee;
select * from HumanResources.Department;

--inner join
select e.BusinessEntityID,e.JobTitle,d.Name from HumanResources.Employee as e inner join 
HumanResources.Department as d 
on e.BusinessEntityID=d.DepartmentID order by e.BusinessEntityID asc

--Total Employee
select count(*) from HumanResources.Employee;

--Total Employee According to Jobs
select jobtitle,count(JobTitle)as 'Total Employee' from HumanResources.Employee group by jobtitle;


--
select * from dbo.employeeTable;
select * from dbo.DepartmentTable;

--city wise total employee
select e.employeeid,d.city,e.empname as 'Total Employee' from dbo.employeeTable as e 
inner join dbo.DepartmentTable as d
on e.departmentid=d.departmentid


select e.employeeid,d.city,e.empname as 'Total Employee' from dbo.employeeTable as e 
inner join dbo.DepartmentTable as d
on e.departmentid=d.departmentid where e.employeeid<=3

select d.city,count(e.empname) as 'Total Employee' from dbo.employeeTable as e 
inner join dbo.DepartmentTable as d
on e.departmentid=d.departmentid group by city having d.city in ('Delhi','Meerut')

--join, groupby , where, having
select d.city,count(e.empname) as 'Total Employee' from dbo.employeeTable as e 
inner join dbo.DepartmentTable as d
on e.departmentid=d.departmentid where e.employeeid<=3 group by city having d.city in 
('Delhi','Meerut')


--CTE - Common Table Expression
select * from customers1;

with mycust as
(
select * from customers1 where profession='Retired'
)
select * from mycust;

--cte with group by according to profession
with mycust as
(
select profession,count(gender) as 'Total Male' from customers1 where gender='male'
group by profession
)
select * from mycust;


--cte with group by according to gender
with mycust as
(
select profession,gender,count(gender) as 'Total' from customers1 group by profession,gender
)
select * from mycust order by profession;

use AdventureWorks2019;
select * from dbo.employeeTable;
select * from dbo.DepartmentTable;
insert into dbo.employeeTable values(5,'Hari',104)

--city wise total employee
with empdept as(
select e.employeeid,d.city,e.empname from dbo.employeeTable as e 
inner join dbo.DepartmentTable as d
on e.departmentid=d.departmentid 
)
select city,count(city) as 'Total Employee' from empdept group by city;


create table empsalary
(
EmployeeID int, 
salary money
)
insert into empsalary values(2,50000),(4,60000),(1,80000),(6,95000.25)
select * from empsalary


select * from dbo.employeeTable;
select * from dbo.DepartmentTable;
select * from empsalary

select e.EmployeeID,e.EmpName,e.DepartmentID,d.DepartmentName from dbo.EmployeeTable
as e inner join dbo.DepartmentTable as d on e.DepartmentID=d.DepartmentID

select e.EmployeeID,e.EmpName,e.DepartmentID,d.DepartmentName,s.salary from dbo.EmployeeTable
as e inner join dbo.DepartmentTable as d on e.DepartmentID=d.DepartmentID  inner join
empsalary as s on e.EmployeeID=s.EmployeeID 



with mycte as 
(
select e.EmployeeID,e.EmpName,e.DepartmentID,d.DepartmentName,s.salary from dbo.EmployeeTable
as e inner join dbo.DepartmentTable as d on e.DepartmentID=d.DepartmentID  inner join
empsalary as s on e.EmployeeID=s.EmployeeID 
)
select * from mycte where salary>50000;

select salary from empsalary
--second highest salary using subquery
select max(salary) from empsalary where salary < (select max(salary) from empsalary)

--second method
with secondsalary as
(
select salary,row_number()over(order by salary desc) as RowNumber  from empsalary 
)
select * from secondsalary where RowNumber=2;
--Ranking Functions   (dense rank, rank, row number, ntile)
select * from empsalary
insert into empsalary values(7,60000)
select salary,row_number()over(order by salary desc) as RowNumber  from empsalary 
select salary,dense_rank()over(order by salary desc) as RowNumber  from empsalary 
select salary,rank()over(order by salary desc) as RowNumber  from empsalary 
select salary,ntile(2)over(order by salary desc) as RowNumber  from empsalary 

--clutered and non-clustered








