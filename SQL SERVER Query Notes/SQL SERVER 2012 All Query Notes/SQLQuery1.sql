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