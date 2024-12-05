Create database joindatabase
use joindatabase
create table tbl1
(
id int 
);
insert into tbl1 values(1),(1),(2),(NULL),(NULL);
select * from tbl1

create table tbl2
(
id int 
);
insert into tbl2 values(1),(3),(NULL);
select * from tbl2
-------------------------------
select * from tbl1
select * from tbl2

select * from tbl1 inner join tbl2 on tbl1.id=tbl2.id
select * from tbl1 left join tbl2 on tbl1.id=tbl2.id
select * from tbl1 right join tbl2 on tbl1.id=tbl2.id
select * from tbl1
select * from tbl2
select * from tbl1 full outer join tbl2 on tbl1.id=tbl2.id

----------Question2---------
create table t1
(
id int 
);
insert into t1 values(1),(1),(0),(NULL);
select * from t1

create table t2
(
id int 
);
insert into t2 values(1),(0),(NULL),(NULL);
select * from t2


select * from t1
select * from t2
select * from t1 inner join t2 on t1.id=t2.id
select * from t1 left join t2 on t1.id=t2.id
select * from t1 right join t2 on t1.id=t2.id
select * from t1 full outer join t2 on t1.id=t2.id
select * from t1 cross join t2 

---Question-3-------------
create table tt1
(
id int 
);
insert into tt1 values(1),(1),(1),(1);
select * from tt1

create table tt2
(
id int 
);
insert into tt2 values(1),(0),(1),(0);

select * from tt1
select * from tt2
select * from tt1 inner join tt2 on tt1.id=tt2.id
select * from tt1 left join tt2 on tt1.id=tt2.id
select * from tt1 right join tt2 on tt1.id=tt2.id
select * from tt1 full outer join tt2 on tt1.id=tt2.id
