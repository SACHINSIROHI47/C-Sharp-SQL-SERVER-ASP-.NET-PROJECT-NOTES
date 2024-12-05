create database aptech
use aptech
create table stdlogin
(
userid int primary key not null,
pwd varchar(20) not null
)
select * from stdlogin
insert into stdlogin values(101,'aptech');