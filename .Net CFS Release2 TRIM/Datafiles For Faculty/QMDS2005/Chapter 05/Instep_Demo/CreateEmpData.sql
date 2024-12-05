CREATE TABLE EmpData
(
EmpName	varchar(20)	 NULL,
EmpNo int NOT NULL,
EmpAddress varchar(60)	NULL,
Salary int	NULL
)

INSERT EmpData
VALUES ('Yang Kan', 101, '123 Nanjing Lu', 2500)

INSERT EmpData (EmpName, EmpAddress, EmpNo, Salary)
VALUES ('Yang Kan', '123 Nanjing Lu', 101, 2500)

INSERT EmpData (EmpName, EmpAddress, Salary, EmpNo)
VALUES ('Yang Kan', '123 Nanjing Lu', 2500, 101)

INSERT EmpData
VALUES ('Yang Kan', 101, NULL, 2500)

INSERT EmpData (EmpName, EmpNo, Salary)
VALUES ('Yang Kan', 101, 2500)




