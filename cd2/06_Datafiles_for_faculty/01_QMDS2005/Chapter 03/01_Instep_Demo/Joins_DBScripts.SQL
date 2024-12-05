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
