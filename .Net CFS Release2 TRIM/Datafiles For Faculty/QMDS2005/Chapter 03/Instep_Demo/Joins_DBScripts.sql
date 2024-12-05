CREATE TABLE ComputerDetails
(
CompID int, 
CompDescription varchar(100),
Price money
)

INSERT INTO ComputerDetails VALUES(1, 'Pentium D 3 GHtz, 1 GB RAM, nVdia G Force', 2000)

INSERT INTO ComputerDetails VALUES(2, 'Pentium 4 2.6 GHtz, 512 MB RAM, Intel 911', 600)


CREATE TABLE AddOnDetails
(
AddOnID int, 
AddOnDescription varchar(100),
Price money 
)

INSERT INTO AddOnDetails VALUES(1, 'Creative Speakers, Joystick, LCD Screen', 200)

INSERT INTO AddOnDetails VALUES(2, 'Sony Speakers, LCD Screen', 160)

INSERT INTO AddOnDetails VALUES(3, 'LCD Screen, Wireless mouse', 120)
create table Employee
(
EmployeeID int,
EmployeeName varchar(20),
EmployeeEducationCode int
)

create table Education
(
EmployeeEducationCode int,
Education varchar(10)
)
insert into Employee values(1,'Ron',1)
insert into Employee values(2,'Harry',3)
insert into Employee values(3,'Sam',4)
insert into Employee values(4,'John',null)

insert into Education values(1,'B.Com.')
insert into Education values(2,'Bsc.')
insert into Education values(3,'MBA')
insert into Education values(4,'MCA')

create table DeptDetails
(
	DeptNo int,
	DeptName varchar(30)
)

Insert DeptDetails values (10, 'System')
Insert DeptDetails values (20, 'Admin')
Insert DeptDetails values (30, 'Operation')

create table EmployeeDetails 
(
	EmployeeID int,
	EmpName varchar(30),
	Designation varchar(30),
	Salary int,
	DeptNo int
)

Insert EmployeeDetails values (1, 'John', 'Executive', 25000, 10)
Insert EmployeeDetails values (2, 'Smith', 'Manager', 45000, 10)
Insert EmployeeDetails values (3, 'Robert', 'Clerk', 10000, 10)
Insert EmployeeDetails values (4, 'Jack', 'Clerk', 12000, 20)
Insert EmployeeDetails values (5, 'Sylvia', 'Executive', 32000, 20)