CREATE DATABASE HDFC

DROP DATABASE HDFC

CREATE DATABASE SBI
GO

DROP DATABASE SBI

USE SBI

CREATE TABLE ACCOUNTS
(
ACNO CHAR(6) NOT NULL PRIMARY KEY,
FIRST_NAME VARCHAR(15) NOT NULL,
LAST_NAME VARCHAR(15) NOT NULL,
ADDRESS VARCHAR(80) NOT NULL,
CITY VARCHAR(30) NOT NULL,
PIN_CODE CHAR(6),
STATE VARCHAR(25) NOT NULL,
BIRTH_DATE DATETIME NOT NULL,
PHONE_NO VARCHAR(15) NULL,
BALANCE MONEY NOT NULL,
OPENING_DATE DATETIME NOT NULL
)

DROP TABLE ACCOUNTS

SELECT * FROM ACCOUNTS

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE)
VALUES('A00001','AJAY','SHARMA','33 D SAKET','MEERUT','250001','UTTAR PRADESH','08/22/1980','9837371123',15000.00,'04/15/2015')

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE)
VALUES('A00002','VIJAY','SHARMA','34 CIVIL LINES','MEERUT','250001','UTTAR PRADESH','11/24/1982','9837371155',11000.00,'04/15/2015')

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,ADDRESS,CITY,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE)
VALUES('A00003','REEMA','SHARMA','67 D SHASHTRI NAGAR','MEERUT','UTTAR PRADESH','12/27/1990','8837371155',16000.00,'04/15/2015')

INSERT ACCOUNTS
VALUES('A00004','SEEMA','BHARDWAJ','11 RAJPUR ROAD','DEHRADUN','248179','UTTARAKHAND','01/24/1982','8856371155',9000.00,'04/15/2015')

SELECT * FROM ACCOUNTS

SELECT ACNO,FIRST_NAME,LAST_NAME,BALANCE
FROM ACCOUNTS

SELECT ACNO,FIRST_NAME,LAST_NAME,BALANCE
FROM ACCOUNTS
WHERE ACNO = 'A00002'

SELECT * FROM ACCOUNTS
WHERE ACNO = 'A00002'

SELECT * FROM ACCOUNTS
WHERE BALANCE > 10000

SELECT * FROM ACCOUNTS
WHERE CITY = 'DEHRADUN'

SELECT * FROM ACCOUNTS
WHERE BALANCE <= 15000

SELECT * FROM ACCOUNTS

UPDATE ACCOUNTS
SET LAST_NAME = 'KHANNA'
WHERE ACNO = 'A00003'

UPDATE ACCOUNTS
SET ADDRESS = '45 LAJPAT NAGAR',CITY = 'DELHI',STATE = 'DELHI',PIN_CODE = '110009'
WHERE ACNO = 'A00003'

UPDATE ACCOUNTS
SET BALANCE = 4000

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 500

UPDATE ACCOUNTS
SET BALANCE = 25000
WHERE ACNO = 'A00003'

SELECT * FROM ACCOUNTS

DELETE ACCOUNTS

DELETE ACCOUNTS
WHERE ACNO = 'A00002'

SELECT * FROM ACCOUNTS

SELECT LAST_NAME FROM ACCOUNTS

SELECT ALL LAST_NAME FROM ACCOUNTS

SELECT DISTINCT LAST_NAME FROM ACCOUNTS

SELECT * FROM ACCOUNTS

SELECT ACNO,FIRST_NAME,LAST_NAME,BALANCE
INTO MYACCOUNTS
FROM ACCOUNTS

SELECT * FROM MYACCOUNTS

SELECT *
INTO MYACCOUNTS2
FROM ACCOUNTS
WHERE CITY = 'MEERUT'

SELECT * FROM MYACCOUNTS2
