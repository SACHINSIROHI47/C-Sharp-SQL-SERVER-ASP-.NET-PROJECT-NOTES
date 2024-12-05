create database Employee
use Employee
create table dept
(
deptid int not null,
deptname char(100),
Addres date,
amt money
)
insert into dept values(101,'IT Dept','Delhi',5050)
select * from dept
insert into dept(deptid,deptname) values(104,'IT Dept')
insert into dept values(106,'adsfas','asf',5012)
----------------Day-2-------------------------------------
select * from dept where deptid=101
select * from dept where deptid>=101 and deptid<=103
select * from dept where deptid between 101 and 103 
select * from dept where deptid not between 101 and 103 
select * from dept where addres in('Delhi','Lucknow')
select * from dept where addres not in('Delhi','Lucknow')
select * from dept where  deptname like 'IT%'
select * from dept where deptname like '_a%'
--------update------
update dept set addres='Kanpur' where deptid=101 
update dept set addres='Lucknow',amt=80000 where deptid=104 
-------delete---------------
delete from dept where deptid=106
delete from dept
----------------Day-3-------------------------------------
--delete, drop and truncate
create table employeeinfo
(
deptid int not null,
deptname char(100),
city char(100),
amt money
)
insert into employeeinfo values(101,'IT Dept','Delhi',5051),(102,'Sales','asf',5012),
(103,'Marketing Dept','Delhi',5050),(104,'AI','asf',5014)

delete from employeeinfo where deptid=101

begin tran
delete from employeeinfo

rollback tran

begin tran
truncate table employeeinfo
rollback tran;

select * from employeeinfo

begin tran
drop table employeeinfo
rollback tran

---Data Modeling Primary key foreign key ---
create table employee
(
empid int primary key not null,
empname char(100),
city char(100),
amt money
)
--
--drop table employee
--truncate table employee
delete from employee where empid=101

select * from employee
insert into employee values(101,'IT Dept','Delhi',5051)
insert into employee values(102,'Sales','asf',5012)
create table deptartment
(
deptid int foreign key references employee(empid) on delete cascade,
deptname char(100) not null
)
--drop table deptartment
select * from deptartment
insert into deptartment values(101,'Gita')
