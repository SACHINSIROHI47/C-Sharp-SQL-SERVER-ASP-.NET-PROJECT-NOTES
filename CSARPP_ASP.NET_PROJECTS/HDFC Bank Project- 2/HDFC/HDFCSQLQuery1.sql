CREATE DATABASE HDFCBank

DROP DATABASE HDFCBank

USE HDFCBank

DROP TABLE USERS

CREATE TABLE USERS
(
UserName VARCHAR(25) PRIMARY KEY,
PASSWORD VARCHAR(25)
)

SELECT * FROM USERS

INSERT USERS(UserName,PASSWORD)
values('admin','rgpg007')

INSERT USERS(UserName,PASSWORD)
values('user1','meerut')


SELECT * FROM USERS WHERE UserName='adminh'

DROP TABLE ACCOUNTS

CREATE TABLE ACCOUNTS
(
ACNO CHAR(6) PRIMARY KEY,
ACCOUNT_TYPE VARCHAR(10),
FIRST_NAME VARCHAR(30),
LAST_NAME VARCHAR(30),
ADDRESS VARCHAR(60),
STATE VARCHAR(40),
CITY VARCHAR(40),
DATE_OF_BIRTH DATETIME,
OPENING_DATE DATETIME,
BALANCE MONEY,
PHONE_NO VARCHAR(15),
AC_IMAGE VARCHAR(100)
)

SELECT * FROM ACCOUNTS

DELETE ACCOUNTS

SELECT ACNO FROM ACCOUNTS

UPDATE ACCOUNTS 
SET ACCOUNT_TYPE='Current',FIRST_NAME='KANIKA'
,LAST_NAME = 'BATNAGAR'
WHERE ACNO='A00003'


SELECT * FROM ACCOUNTS

SELECT * FROM ACCOUNTS WHERE ACNO='A00002'

SELECT ACNO FROM ACCOUNTS  ORDER BY ACNO ASC

SELECT max(ACNO) FROM ACCOUNTS


DELETE ACCOUNT WHERE ACNO = 'A00002'

DROP TABLE TRANSACTIONS

DELETE TRANSACTIONS

DROP TABLE TRANSACTIONS
CREATE TABLE TRANSACTIONS
(
TRAN_ID CHAR(6) PRIMARY KEY,
ACNO CHAR(6),
TRAN_TYPE VARCHAR(10),
AMOUNT MONEY,
DOC_TYPE VARCHAR(10),
DOC_NUMBER VARCHAR(20),
TRAN_DATE DATETIME
CONSTRAINT cons_doctype_docnumber unique(DOC_TYPE,DOC_NUMBER)
)

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS  

ORDER BY TRAN_ID ASC

DELETE TRANSACTIONS
WHERE TRAN_ID = 'T00002'