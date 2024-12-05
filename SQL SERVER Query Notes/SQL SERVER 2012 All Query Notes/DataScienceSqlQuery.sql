create database datascience;
use datascience;
create table employee
(
empid int primary key not null,
empname char(100)not null,
empsalary float not null,
addres varchar(200)
);
select * from employee;
insert into employee values(101,'James',80000,'Meerut')
insert into employee values(102,'Ram',40000,'Delhi'),(103,'Gita',20000,'Kanpur')

create table student
(
empid int primary key identity(1001,1) not null,
name varchar(100) not null,
marks float 
);

insert into student values('Ritu',80)
insert into student values('James',70)
insert into student values('Gita',50)
select * from student;

delete employee where empid=103;

update employee set empname='Ram Singh' where empid=102;
select * from employee;

select * from student;
alter table student add addrs varchar(500);
update student set addrs='Meerut' where empid=1002;

alter table student drop column addrs;


alter table student alter column name char(200)not null;

EXEC sp_help 'student'; 


CREATE TABLE Orders (
    OrderID int NOT NULL,
    OrderNumber int NOT NULL,
    PersonID int,
    PRIMARY KEY (OrderID),
);
select * from orders;
insert into orders values(1001,121001,5001)


CREATE TABLE persontable (
    OrderID int NOT NULL,
    productname varchar(100) not null,
    PersonID int PRIMARY KEY not null,
    FOREIGN KEY (orderid) REFERENCES orders(orderid)
);
insert into persontable values(1001,'computer',6001);
select * from persontable;



CREATE TRIGGER trDeleteEmployee2 
ON Employee
FOR DELETE
AS
BEGIN
  PRINT 'YOU CANNOT PERFORM DELETE OPERATION'
  ROLLBACK TRANSACTION
END

DELETE FROM Employee WHERE empid = 102
select * from employee
insert into employee values(103,'Gita',30000,'Ghz')
-----------------

create table employeeaddress 
(
empid int primary key not null,
empname char(50),
addres varchar(200)
)

GRANT SELECT, INSERT, UPDATE ON employeeaddress TO ram;
insert into employeeaddress values(101,'ram','meerut');
insert into employeeaddress values(102,'Gita','Delhi');
select * from employeeaddress;
delete from employeeaddress where empid=102;

--GRANT SELECT, INSERT, UPDATE, DELETE ON EmployeeAddress TO Steve;
USE HR;
GRANT SELECT ON Employee TO public;
USE HR;
REVOKE DELETE ON EmployeeAddress FROM Steve;


CREATE TABLE BikeParts (
    BikeParts_GUID AS 'ABCD-' + RIGHT(REPLICATE('0', 8) + CONVERT(VARCHAR, BikePart_ID), 10),
    BikePart_ID INT IDENTITY(1, 1),
    BikePart_Name VARCHAR(100)
)
INSERT INTO BikeParts VALUES ('Break Cable')
INSERT INTO BikeParts VALUES ('Seat Cover')
INSERT INTO BikeParts VALUES ('Head Light')
INSERT INTO BikeParts VALUES ('Tail Lamp')

SELECT * FROM BikeParts;

use adventureworks2012
select * from person.Address






 




