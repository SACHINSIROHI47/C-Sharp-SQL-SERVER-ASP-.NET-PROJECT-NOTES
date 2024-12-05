---DATE 21/04/2015

DROP TABLE ACCOUNTS

DROP TABLE TRANSACTIONS

CREATE TABLE ACCOUNTS
(
ACNO CHAR(6) NOT NULL PRIMARY KEY CLUSTERED,
FIRST_NAME VARCHAR(15) NOT NULL,
MIDDLE_NAME VARCHAR(15) NULL,
LAST_NAME VARCHAR(15) NOT NULL,
ADDRESS VARCHAR(80) NOT NULL,
CITY VARCHAR(30) NOT NULL DEFAULT 'MEERUT',
PIN_CODE CHAR(6) DEFAULT '250002',
STATE VARCHAR(25) NOT NULL,
BIRTH_DATE DATETIME NOT NULL,
PHONE_NO VARCHAR(15),
BALANCE MONEY NOT NULL DEFAULT 5000,
OPENING_DATE DATETIME NOT NULL DEFAULT GETDATE(),
AC_TYPE VARCHAR(30)
)

SELECT GETDATE()

DROP TABLE ACCOUNTS

SELECT * FROM ACCOUNTS

INSERT ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,STATE,BIRTH_DATE,PHONE_NO,AC_TYPE)
VALUES('A00001','AJAY','KUMAR','SHARMA','33 D SAKET','UTTAR PRADESH','08/22/1980','9837371123','SAVING')

INSERT ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00002','VIJAY','KUMAR','SHARMA','34 D SAKET','DELHI','250001','UTTAR PRADESH','11/24/1982','9837371155',11000.00,'04/15/2015','SAVING')


INSERT ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00003','AMIT','KUMAR','SHARMA','34 D RAJPUR ROAD','DEHRADUN','228179','UTTARAKHAND','12/27/1992','8837371155',2000.00,'04/19/2015','SAVING')

INSERT ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00002','RAJESH','KUMAR','SHARMA','34 D RAJPUR ROAD','DEHRADUN','228179','UTTARAKHAND','12/27/1992','8837371155',11000.00,'04/19/2015','CURRENT')

INSERT ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00005','MUKESH','KUMAR','SHARMA','34 D RAJPUR ROAD','DEHRADUN','228179','UTTARAKHAND','12/27/1992','8837371155',4000.00,'04/19/2015','CURRENT')



DROP TABLE TRANSACTIONS

SELECT * FROM ACCOUNTS

CREATE TABLE TRANSACTIONS
(
TRAN_ID CHAR(8) NOT NULL PRIMARY KEY,
ACNO CHAR(6) NOT NULL CONSTRAINT FK_ACNO FOREIGN KEY REFERENCES ACCOUNTS(ACNO),
AMOUNT MONEY NOT NULL,
TRAN_DATE DATETIME NOT NULL,
TRAN_TYPE VARCHAR(15) NOT NULL CONSTRAINT CHK_TRAN_TYPE CHECK(TRAN_TYPE IN('DEPOSIT','WITHDRAWL'))
)

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

DROP TABLE TRANSACTIONS

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000001','A00001',2000.00,'04/16/2015','DEPOSIT')

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 2000.00
WHERE ACNO = 'A00001'

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000002','A00002',500.00,'04/16/2015','WITHDRAWL')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000004','A00002',4000.00,'04/16/2015','WITHDRAWL')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000005','A00002',1000.00,'04/16/2015','WITHDRAWL')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000006','A00002',7000.00,'04/16/2015','WITHDRAWL')

DROP TABLE TRANSACTIONS

CREATE TABLE TRANSACTIONS
(
TRAN_ID CHAR(8) NOT NULL PRIMARY KEY,
ACNO CHAR(6) NOT NULL CONSTRAINT FK_ACNO FOREIGN KEY REFERENCES ACCOUNTS(A NO),
AMOUNT MONEY NOT NULL,
TRAN_DATE DATETIME NOT NULL,
TRAN_TYPE VARCHAR(15) NOT NULL
)
 
SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000001','A00001',2000.00,'04/16/2015','DEPOSIT')

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 2000.00
WHERE ACNO = 'A00001'

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000003','A00002',700.00,'04/16/2015','WITHDRAWL')


CREATE TABLE ACCOUNTS
(
ACNO CHAR(6) NOT NULL CONSTRAINT PK_ACNO PRIMARY KEY CLUSTERED
CONSTRAINT CHECK_ACNO CHECK(ACNO LIKE 'A[0-9][0-9][0-9][0-9][0-9]'),
FIRST_NAME VARCHAR(15) NOT NULL,
LAST_NAME VARCHAR(15) NOT NULL,
BALANCE MONEY NOT NULL DEFAULT  ,
AC_TYPE VARCHAR(15) CONSTRAINT CHECK_AC_TYPE CHECK(AC_TYPE IN('SAVING','CURRENT')) 
)

SELECT * FROM ACCOUNTS

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,BALANCE,AC_TYPE)
VALUES('A00001','AJAY','SHARMA',5000.00,'SAVING')

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,BALANCE,AC_TYPE)
VALUES('A00002','JOY','JULIAN',9000.00,'CURRENT')

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,BALANCE,AC_TYPE)
VALUES('A00003','VINITA','JAIN',2000.00,'NOTHING')

ALTER TABLE ACCOUNTS
ADD OPENING_DATE DATETIME 

ALTER TABLE ACCOUNTS
DROP COLUMN OPENING_DATE

UPDATE ACCOUNTS
SET OPENING_DATE = '04/18/2015'
WHERE ACNO = 'A00001'

DROP TABLE TRANSACTIONS 

DROP TABLE DBO.ACCOUNTS 

CREATE TABLE ACCOUNTS
(
ACNO CHAR(6) NOT NULL CONSTRAINT PK_ACNO PRIMARY KEY CLUSTERED
CONSTRAINT CHECK_ACNO CHECK(ACNO LIKE 'A[0-9][0-9][0-9][0-9][0-9]'),
FIRST_NAME VARCHAR(15) NOT NULL,
LAST_NAME VARCHAR(15) NOT NULL,
BALANCE MONEY NOT NULL DEFAULT  500 CONSTRAINT CHK_BALENCE CHECK(BALANCE >=0),
AC_TYPE VARCHAR(15) CONSTRAINT CHECK_AC_TYPE CHECK(AC_TYPE IN('SAVING','CURRENT')),
PHONE_NO VARCHAR(15) NULL CONSTRAINT CHK_PHONE CHECK(PHONE_NO LIKE '([0-9][0-9][0-9])-[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
ONLINE_BANKING BIT 
)

SELECT * FROM ACCOUNTS

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,BALANCE,AC_TYPE,PHONE_NO,ONLINE_BANKING)
VALUES('A00001','AJAY','SHARMA',5000.00,'SAVING','(121)-2657789',1)


INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,BALANCE,AC_TYPE,PHONE_NO,ONLINE_BANKING)
VALUES('A00002','JAY','SHARMA',200.00,'SAVING',1212421167,1)



INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,AC_TYPE,PHONE_NO,ONLINE_BANKING)
VALUES('A00003','JAY','SHARMA','SAVING',NULL,1)



CREATE TABLE ACCOUNTS
(
ACNO CHAR(6) NOT NULL PRIMARY KEY,
FIRST_NAME VARCHAR(15) NOT NULL,
MIDDLE_NAME VARCHAR(15) NULL,
LAST_NAME VARCHAR(15) NOT NULL,
ADDRESS VARCHAR(80) NOT NULL,
CITY VARCHAR(30) NOT NULL,
PIN_CODE CHAR(6),
STATE VARCHAR(25) NOT NULL,
BIRTH_DATE DATETIME NOT NULL,
PHONE_NO VARCHAR(15),
BALANCE MONEY NOT NULL,
OPENING_DATE DATETIME NOT NULL,
AC_TYPE VARCHAR(15) CONSTRAINT CHECK_AC_TYPE CHECK(AC_TYPE IN('SAVING','CURRENT')) 
)

DROP TABLE ACCOUNTS

SELECT * FROM ACCOUNTS

INSERT ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00001','AJAY','KUMAR','SHARMA','33 D SAKET','MEERUT','250001','UTTAR PRADESH','08/22/1980','9837371123',15000.00,'04/15/2015','SAVING')

INSERT INTO ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00002','VIJAY','KUMAR','SHARMA','34 D SAKET','MEERUT','250001','UTTAR PRADESH','11/24/1982','9837371155',11000.00,'04/15/2015','CURRENT')

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,ADDRESS,CITY,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00003','REEMA','SHARMA','67 D SHASHTRI NAGAR','MEERUT','UTTAR PRADESH','12/27/1990','8837371155',16000.00,'04/15/2015','SAVING')

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,ADDRESS,CITY,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00004','ANITA','BANSAL','67 D SHASHTRI NAGAR','MEERUT','UTTAR PRADESH','12/27/1990','8837371155',16000.00,'04/15/2015','SAVING')

INSERT ACCOUNTS
VALUES('A00004','SEEMA',NULL,'BHARDWAJ','11 RAJPUR ROAD','DEHRADUN','248179','UTTARAKHAND','01/24/1982','8856371155',9000.00,'04/15/2015')


DROP TABLE TRANSACTIONS

CREATE TABLE TRANSACTIONS
(
TRAN_ID CHAR(8) NOT NULL PRIMARY KEY,
ACNO CHAR(6) NOT NULL FOREIGN KEY REFERENCES ACCOUNTS(ACNO),
AMOUNT MONEY NOT NULL,
TRAN_DATE DATETIME NOT NULL,
TRAN_TYPE VARCHAR(15) NOT NULL
)

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000001','A00001',2000.00,'04/16/2015','DEPOSIT')

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 2000.00
WHERE ACNO = 'A00001'

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000002','A00002',500.00,'04/16/2015','WITHDRAWL')

UPDATE ACCOUNTS
SET BALANCE = BALANCE - 500.00
WHERE ACNO = 'A00002'

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000003','A00002',3000.00,'04/16/2015','DEPOSIT')

--DATE 22/042015

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

SELECT ACCOUNTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,TRAN_TYPE
FROM ACCOUNTS INNER JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO


SELECT ACCTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,TRAN_TYPE
FROM ACCOUNTS ACCTS INNER JOIN TRANSACTIONS TRANS
ON ACCTS.ACNO = TRANS.ACNO

SELECT * INTO NEWACCOUNTS
FROM ACCOUNTS

SELECT * FROM NEWACCOUNTS

SELECT ACNO,FIRST_NAME,LAST_NAME,BALANCE
INTO NEWACCOUNTS2
FROM ACCOUNTS

SELECT * FROM NEWACCOUNTS2

SELECT * FROM ACCOUNTS
WHERE AC_TYPE= 'SAVING'

DROP TABLE NEWACCOUNTS_SAVINGS

SELECT * INTO NEWACCOUNTS_SAVINGS
FROM ACCOUNTS
WHERE AC_TYPE= 'SAVING'

SELECT * FROM NEWACCOUNTS_SAVINGS




SELECT ACCTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,TRAN_TYPE
INTO ACCOUNT_TRANSACTIONS
FROM ACCOUNTS ACCTS INNER JOIN TRANSACTIONS TRANS
ON ACCTS.ACNO = TRANS.ACNO

SELECT * FROM ACCOUNT_TRANSACTIONS


SELECT * INTO ACCOUNTS_BACKUP
FROM ACCOUNTS

SELECT * FROM ACCOUNTS_BACKUP

DELETE ACCOUNTS_BACKUP

INSERT  ACCOUNTS_BACKUP
SELECT * FROM ACCOUNTS

SELECT ACCTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,TRAN_TYPE
INTO ACCOUNT_TRANSACTIONS2
FROM ACCOUNTS ACCTS INNER JOIN TRANSACTIONS TRANS
ON ACCTS.ACNO = TRANS.ACNO

DELETE ACCOUNT_TRANSACTIONS2

SELECT * FROM ACCOUNT_TRANSACTIONS2

INSERT ACCOUNT_TRANSACTIONS2
SELECT ACCTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,TRAN_TYPE
FROM ACCOUNTS ACCTS INNER JOIN TRANSACTIONS TRANS
ON ACCTS.ACNO = TRANS.ACNO

DROP TABLE CREDIT_CARD

CREATE TABLE CREDIT_CARD
(
CARD_ID CHAR(16)CONSTRAINT PK_CARD_ID PRIMARY KEY,
EXPIRY_DATE DATETIME,
CVV_CODE CHAR(3),
CARD_TYPE VARCHAR(10),
CARD_COMPANY VARCHAR(20)
)

INSERT CREDIT_CARD(CARD_ID,EXPIRY_DATE,CVV_CODE,CARD_TYPE,CARD_COMPANY)
VALUES('3434567798971234','09/15/2020','341','DEBIT','VISA') 

INSERT CREDIT_CARD(CARD_ID,EXPIRY_DATE,CVV_CODE,CARD_TYPE,CARD_COMPANY)
VALUES('3434567298971234','09/15/2025','641','DEBIT','VISA') 

INSERT CREDIT_CARD(CARD_ID,EXPIRY_DATE,CVV_CODE,CARD_TYPE,CARD_COMPANY)
VALUES('3434567799971234','11/15/2020','701','CREDIT','MASTER') 

INSERT CREDIT_CARD(CARD_ID,EXPIRY_DATE,CVV_CODE,CARD_TYPE,CARD_COMPANY)
VALUES('3434567794971234','09/10/2018','668','DEBIT','MASTER') 

SELECT * FROM CREDIT_CARD

DROP TABLE ACCOUNTS

DROP TABLE TRANSACTIONS

CREATE TABLE ACCOUNTS
(
ACNO CHAR(6) NOT NULL PRIMARY KEY,
FIRST_NAME VARCHAR(15) NOT NULL,
MIDDLE_NAME VARCHAR(15) NULL,
LAST_NAME VARCHAR(15) NOT NULL,
ADDRESS VARCHAR(80) NOT NULL,
CITY VARCHAR(30) NOT NULL,
PIN_CODE CHAR(6),
STATE VARCHAR(25) NOT NULL,
BIRTH_DATE DATETIME NOT NULL,
PHONE_NO VARCHAR(15),
BALANCE MONEY NOT NULL,
OPENING_DATE DATETIME NOT NULL,
AC_TYPE VARCHAR(15) CONSTRAINT CHECK_AC_TYPE CHECK(AC_TYPE IN('SAVING','CURRENT')),
CARD_ID CHAR(16)CONSTRAINT FK_CARD_ID FOREIGN KEY REFERENCES CREDIT_CARD(CARD_ID)
)

USE SBI

DROP TABLE ACCOUNTS

DROP TABLE TRANSACTIONS

SELECT * FROM ACCOUNTS

INSERT ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE,CARD_ID)
VALUES('A00001','AJAY','KUMAR','SHARMA','33 D SAKET','MEERUT','250001','UTTAR PRADESH','08/22/1980','9837371123',15000.00,'04/15/2015','SAVING','3434567298971234')

INSERT INTO ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE,CARD_ID)
VALUES('A00002','VIJAY','KUMAR','SHARMA','34 D SAKET','MEERUT','250001','UTTAR PRADESH','11/24/1982','9837371155',11000.00,'04/15/2015','CURRENT','3434567794971234')

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,ADDRESS,CITY,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00003','REEMA','SHARMA','67 D SHASHTRI NAGAR','MEERUT','UTTAR PRADESH','12/27/1990','8837371155',16000.00,'04/15/2015','SAVING')

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,ADDRESS,CITY,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00004','HEMA','KHANNA','67 D NEHRU NAGAR','MEERUT','UTTAR PRADESH','09/11/1980','8835371155',15000.00,'04/16/2015','SAVING')

INSERT ACCOUNTS(ACNO,FIRST_NAME,LAST_NAME,ADDRESS,CITY,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00005','AMIT','CHAUHAN','45 SHASHTRI NAGAR','MEERUT','UTTAR PRADESH','12/22/1980','8837671155',12000.00,'04/16/2015','CURRENT')

INSERT ACCOUNTS
VALUES('A00004','SEEMA',NULL,'BHARDWAJ','11 RAJPUR ROAD','DEHRADUN','248179','UTTARAKHAND','01/24/1982','8856371155',9000.00,'04/15/2015')


SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

SELECT * FROM CREDIT_CARD

SELECT ACCTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,
TRAN_TYPE,ACCTS.CARD_ID,EXPIRY_DATE,CARD_TYPE
FROM ACCOUNTS ACCTS INNER JOIN TRANSACTIONS TRANS
ON ACCTS.ACNO = TRANS.ACNO
INNER JOIN CREDIT_CARD CCARD
ON ACCTS.CARD_ID = CCARD.CARD_ID

DELETE ACCOUNT_TRANSACTIONS2


SELECT ACCTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,
TRAN_TYPE,ACCTS.CARD_ID,EXPIRY_DATE,CARD_TYPE
INTO ACCOUNTS_TRANS_CARD
FROM ACCOUNTS ACCTS INNER JOIN TRANSACTIONS TRANS
ON ACCTS.ACNO = TRANS.ACNO
INNER JOIN CREDIT_CARD CCARD
ON ACCTS.CARD_ID = CCARD.CARD_ID


SELECT * FROM ACCOUNTS_TRANS_CARD

DELETE ACCOUNTS_TRANS_CARD

INSERT ACCOUNTS_TRANS_CARD
SELECT ACCTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,
TRAN_TYPE,ACCTS.CARD_ID,EXPIRY_DATE,CARD_TYPE
FROM ACCOUNTS ACCTS INNER JOIN TRANSACTIONS TRANS
ON ACCTS.ACNO = TRANS.ACNO
INNER JOIN CREDIT_CARD CCARD
ON ACCTS.CARD_ID = CCARD.CARD_ID

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

SELECT * FROM CREDIT_CARD

INSERT ACCOUNTS_TRANS_CARD
SELECT ACCTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,
TRAN_TYPE,ACCTS.CARD_ID,EXPIRY_DATE,CARD_TYPE
FROM ACCOUNTS ACCTS INNER JOIN TRANSACTIONS TRANS
ON ACCTS.ACNO = TRANS.ACNO
INNER JOIN CREDIT_CARD CCARD
ON ACCTS.CARD_ID = CCARD.CARD_ID
WHERE TRAN_TYPE = 'DEPOSIT'

--GROUP BY
SELECT * FROM ACCOUNTS

SELECT AC_TYPE,SUM(BALANCE)
FROM ACCOUNTS
GROUP BY AC_TYPE

SELECT AC_TYPE,'TOTAL BALANCE'=SUM(BALANCE)
FROM ACCOUNTS
GROUP BY AC_TYPE


SELECT AC_TYPE,SUM(BALANCE)
FROM ACCOUNTS
WHERE OPENING_DATE < '04/16/2015'
GROUP BY AC_TYPE


SELECT AC_TYPE,SUM(BALANCE)
FROM ACCOUNTS
GROUP BY AC_TYPE
HAVING SUM(BALANCE) > 25000

SELECT AC_TYPE,SUM(BALANCE)
FROM ACCOUNTS
WHERE OPENING_DATE < '04/16/2015'
GROUP BY AC_TYPE
HAVING SUM(BALANCE) > 25000

--23/04/2015

SELECT * FROM ACCOUNTS

SELECT ACNO,BALANCE
FROM ACCOUNTS

SELECT [ACNO],[BALANCE]
FROM ACCOUNTS

SELECT FIRST_NAME,LAST_NAME FROM ACCOUNTS

SELECT 'Mr./Miss ' + FIRST_NAME + ' ' + LAST_NAME  
FROM ACCOUNTS

SELECT 'Mr./Miss ' + FIRST_NAME + ', ' + LAST_NAME AS 'FULL NAME' 
FROM ACCOUNTS

SELECT 'Mr./Miss ' + FIRST_NAME + ', ' + LAST_NAME AS FULL_NAME 
FROM ACCOUNTS

SELECT TOP 3 'Mr./Miss ' + FIRST_NAME + ', ' + LAST_NAME AS FULL_NAME 
FROM ACCOUNTS

SELECT * FROM ACCOUNTS
WHERE STATE = 'UTTAR PRADESH'

SELECT * FROM ACCOUNTS
WHERE BALANCE > 15000

SELECT * FROM ACCOUNTS
WHERE BALANCE >= 15000

SELECT GETDATE()

SELECT CONVERT(datetime,'04/23/2015',101)

SELECT CONVERT(datetime,'23/04/2015',103)

SELECT CONVERT(datetime,'23/04/2015',104)

SELECT CONVERT(VARCHAR(25),GETDATE(),101)

SELECT CONVERT(VARCHAR(25),GETDATE(),102)

SELECT CONVERT(VARCHAR(25),GETDATE(),103)

SELECT GETDATE()

SELECT * FROM ACCOUNTS
WHERE BALANCE = 15000

SELECT * FROM ACCOUNTS
ORDER BY FIRST_NAME ASC

SELECT * FROM ACCOUNTS
ORDER BY FIRST_NAME DESC

SELECT * FROM ACCOUNTS
ORDER BY BALANCE ASC

SELECT * FROM ACCOUNTS
ORDER BY BALANCE DESC

SELECT * FROM ACCOUNTS
ORDER BY FIRST_NAME ASC,BALANCE ASC

SELECT * FROM ACCOUNTS
ORDER BY FIRST_NAME DESC,BALANCE DESC

SELECT * FROM TRANSACTIONS
ORDER BY ACNO ASC,AMOUNT ASC

SELECT * FROM TRANSACTIONS
ORDER BY ACNO DESC,AMOUNT DESC

SELECT * FROM TRANSACTIONS
ORDER BY ACNO ASC,AMOUNT DESC

SELECT * FROM TRANSACTIONS
WHERE TRAN_TYPE = 'WITHDRAWL' 
ORDER BY ACNO DESC,AMOUNT DESC

SELECT BALANCE FROM ACCOUNTS

SELECT * FROM ACCOUNTS

SELECT SUM(BALANCE) FROM ACCOUNTS

SELECT AVG(BALANCE) FROM ACCOUNTS

SELECT MIN(BALANCE) FROM ACCOUNTS

SELECT MAX(BALANCE) FROM ACCOUNTS

SELECT SUM(BALANCE) FROM ACCOUNTS

SELECT COUNT(BALANCE) FROM ACCOUNTS

SELECT SUM(BALANCE) FROM ACCOUNTS
WHERE AC_TYPE = 'SAVING'

SELECT COUNT(BALANCE) FROM ACCOUNTS
WHERE AC_TYPE = 'SAVING'

SELECT COUNT(BALANCE) FROM ACCOUNTS
WHERE BALANCE > 15000

--GROUP BY

SELECT AC_TYPE,SUM(BALANCE),COUNT(BALANCE) FROM ACCOUNTS
GROUP BY AC_TYPE

SELECT AC_TYPE,'TOTAL'=SUM(BALANCE),'NUMBER'=COUNT(BALANCE) 
FROM ACCOUNTS
GROUP BY AC_TYPE

SELECT AC_TYPE,'TOTAL'=SUM(BALANCE),'NUMBER'=COUNT(BALANCE) 
FROM ACCOUNTS
WHERE BALANCE >10000
GROUP BY AC_TYPE

SELECT AC_TYPE,'TOTAL'=SUM(BALANCE),'NUMBER'=COUNT(BALANCE) 
FROM ACCOUNTS
GROUP BY AC_TYPE
HAVING SUM(BALANCE) > 25000

SELECT AC_TYPE,'TOTAL'=SUM(BALANCE),'NUMBER'=COUNT(BALANCE) 
FROM ACCOUNTS  
WHERE BALANCE >10000  --CHECKING TABLE RECORDS
GROUP BY AC_TYPE
HAVING SUM(BALANCE) > 25000 --CHECKING GROUP TOTAL

SELECT * FROM ACCOUNTS

SELECT AC_TYPE
FROM ACCOUNTS
GROUP BY AC_TYPE
HAVING SUM(BALANCE) > 25000

SELECT SUM(BALANCE)
FROM ACCOUNTS
HAVING SUM(BALANCE) > 25000

SELECT SUM(BALANCE)
FROM ACCOUNTS
HAVING SUM(BALANCE) > 125000

SELECT ACNO FROM TRANSACTIONS
 
SELECT DISTINCT ACNO FROM TRANSACTIONS

--JOINING TABLE

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

SELECT * FROM CREDIT_CARD

SELECT * FROM 
ACCOUNTS JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO

SELECT * FROM ACCOUNTS
JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO
JOIN CREDIT_CARD
ON CREDIT_CARD.CARD_ID = ACCOUNTS.CARD_ID

--24/04/2015

SELECT ACNO, BALANCE FROM ACCOUNTS

SELECT ACNO, BALANCE FROM SBI.DBO.ACCOUNTS




SELECT ACCTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,
TRAN_TYPE,ACCTS.CARD_ID,EXPIRY_DATE,CARD_TYPE
FROM ACCOUNTS ACCTS INNER JOIN TRANSACTIONS TRANS
ON ACCTS.ACNO = TRANS.ACNO
INNER JOIN CREDIT_CARD CCARD
ON ACCTS.CARD_ID = CCARD.CARD_ID


SELECT ACCOUNTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,
TRAN_TYPE
FROM ACCOUNTS JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO

SELECT ACCOUNTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,TRAN_DATE,
TRAN_TYPE,ACCOUNTS.CARD_ID,EXPIRY_DATE,CARD_TYPE
FROM ACCOUNTS JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO
JOIN CREDIT_CARD
ON ACCOUNTS.CARD_ID = CREDIT_CARD.CARD_ID

SELECT ACCOUNTS.ACNO,FIRST_NAME,LAST_NAME,AMOUNT,
TRAN_DATE,TRAN_TYPE
FROM ACCOUNTS INNER JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

SELECT ACCOUNTS.ACNO,FIRST_NAME,LAST_NAME,
AMOUNT,TRAN_DATE,TRAN_TYPE
FROM ACCOUNTS LEFT OUTER JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO

SELECT ACCOUNTS.ACNO,FIRST_NAME,LAST_NAME,
AMOUNT,TRAN_DATE,TRAN_TYPE
FROM ACCOUNTS RIGHT OUTER JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

DROP TABLE TRANSACTIONS

CREATE TABLE TRANSACTIONS
(
TRAN_ID CHAR(8) NOT NULL PRIMARY KEY,
ACNO CHAR(6) NOT NULL,
AMOUNT MONEY NOT NULL,
TRAN_DATE DATETIME NOT NULL,
TRAN_TYPE VARCHAR(15) NOT NULL
)
 
SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000001','A00001',2000.00,'04/16/2015','DEPOSIT')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000002','A00002',700.00,'04/16/2015','WITHDRAWL')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000003','A00007',2000.00,'04/16/2015','DEPOSIT')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000004','A00008',100.00,'04/16/2015','WITHDRAWL')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000005','A00009',600.00,'04/16/2015','WITHDRAWL')

SELECT ACCOUNTS.ACNO,FIRST_NAME,LAST_NAME,
TRANSACTIONS.ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE
FROM ACCOUNTS RIGHT OUTER JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO

SELECT ACCOUNTS.ACNO,FIRST_NAME,LAST_NAME,
AMOUNT,TRAN_DATE,TRAN_TYPE
FROM ACCOUNTS LEFT JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO

SELECT ACCOUNTS.ACNO,FIRST_NAME,LAST_NAME,
AMOUNT,TRAN_DATE,TRAN_TYPE
FROM ACCOUNTS RIGHT JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO


SELECT ACCOUNTS.ACNO,FIRST_NAME,LAST_NAME,
AMOUNT,TRAN_DATE,TRAN_TYPE
FROM ACCOUNTS RIGHT JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO
ORDER BY FIRST_NAME DESC

SELECT 'Mr./Miss ' + FIRST_NAME + ', ' + LAST_NAME AS FULL_NAME 
FROM ACCOUNTS

SELECT ACNO,BALANCE,BALANCE+500 AS NEW_BALANCE 
FROM ACCOUNTS

SELECT ACNO,BALANCE,BALANCE*6/100 AS '6% INTEREST' 
FROM ACCOUNTS

SELECT ACCOUNTS.ACNO,BALANCE,BALANCE*6/100 AS '6% INTEREST' 
FROM ACCOUNTS JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO

SELECT ACNO,OPENING_DATE,' DATE' AS 'Account Opening Date' 
FROM ACCOUNTS 

SELECT * FROM ACCOUNTS

UPDATE ACCOUNTS
SET LAST_NAME = 'BHARDWAJ'
WHERE ACNO = 'A00003'

UPDATE ACCOUNTS
SET ADDRESS = '45 LAJPAT NAGAR',CITY = 'DELHI',STATE = 'DELHI',PIN_CODE = '110009'
WHERE ACNO = 'A00003'

UPDATE ACCOUNTS
SET BALANCE = 4000

UPDATE ACCOUNTS
SET BALANCE = 25000
WHERE ACNO = 'A00003'

SELECT * FROM ACCOUNTS


UPDATE ACCOUNTS
SET BALANCE = BALANCE - 7000
WHERE ACNO = 'A00003'


UPDATE ACCOUNTS
SET BALANCE = BALANCE + 1000
WHERE PIN_CODE LIKE '25%'

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 1000
WHERE PIN_CODE NOT LIKE '25%'

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 1000
WHERE CITY <> 'MEERUT'

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 1000
WHERE PIN_CODE LIKE '25%'

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 1000
WHERE PIN_CODE LIKE '[25]%'

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 1000
WHERE PIN_CODE LIKE '[^25]%'

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 1000
WHERE PIN_CODE LIKE '[25____]%'

INSERT INTO ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00006','AMITABH','KUMAR','SHARMA','34 D SAKET','MEERUT','250001','UTTAR PRADESH','11/24/1982','9837371155',11000.00,'04/15/2015','CURRENT')

INSERT INTO ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00007','ABHIJAY','KUMAR','SHARMA','34 D SAKET','MEERUT','250001','UTTAR PRADESH','11/24/1982','9837371155',11000.00,'04/15/2015','CURRENT')

INSERT INTO ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00008','VINEET','KUMAR','SHARMA','67 RAJPUR ROAD','DEHRADUN','248179','UTTARAKHAND','11/24/1982','9837371155',11000.00,'04/15/2015','CURRENT')

INSERT INTO ACCOUNTS(ACNO,FIRST_NAME,MIDDLE_NAME,LAST_NAME,ADDRESS,CITY,PIN_CODE,STATE,BIRTH_DATE,PHONE_NO,BALANCE,OPENING_DATE,AC_TYPE)
VALUES('A00009','GEETA','KUMAR','SHARMA','55 JHAKHAN','DEHRADUN','248179','UTTARAKHAND','11/24/1982','9837371155',11000.00,'04/15/2015','CURRENT')

SELECT ACNO,FIRST_NAME,BALANCE
FROM ACCOUNTS
WHERE FIRST_NAME LIKE '[A]%'

SELECT ACNO,FIRST_NAME,BALANCE
FROM ACCOUNTS
WHERE FIRST_NAME LIKE 'A%'

SELECT ACNO,FIRST_NAME,BALANCE
FROM ACCOUNTS
WHERE FIRST_NAME LIKE 'A%Y'

SELECT ACNO,FIRST_NAME,BALANCE
FROM ACCOUNTS
WHERE FIRST_NAME LIKE 'A__Y'

SELECT ACNO,FIRST_NAME,BALANCE
FROM ACCOUNTS
WHERE FIRST_NAME LIKE 'A_____Y'

SELECT ACNO,FIRST_NAME,BALANCE
FROM ACCOUNTS
WHERE FIRST_NAME LIKE '[^A]%'


SELECT * FROM ACCOUNTS

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 1000
WHERE PIN_CODE IN('250001','248179','220001')


SELECT ACNO,FIRST_NAME,BALANCE
FROM ACCOUNTS
WHERE FIRST_NAME LIKE '%JA%'

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 1000
WHERE FIRST_NAME LIKE '%JA%'

'%20%' 
67209788
'%20!%' 
45520!90

'%20!%%' ESCAPE '!'
5520%89

SELECT ACNO,FIRST_NAME,BALANCE
FROM ACCOUNTS
HAVING SUM(BALANCE) > 25000


SELECT AC_TYPE
FROM ACCOUNTS
GROUP BY AC_TYPE
HAVING SUM(BALANCE) > 25000

--27/04/2015
--SUB QUERY

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

SELECT ACNO,BALANCE            --OUTER QUERY
FROM ACCOUNTS
WHERE ACNO 
IN(SELECT ACNO FROM TRANSACTIONS  --INNER QUERY
   GROUP BY ACNO
   HAVING SUM(AMOUNT) > 1000)

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 500
WHERE ACNO 
IN(SELECT ACNO FROM TRANSACTIONS
   GROUP BY ACNO
   HAVING SUM(AMOUNT) > 1000)
   
DROP TABLE TRANSACTIONS

CREATE TABLE TRANSACTIONS
(
TRAN_ID CHAR(8) NOT NULL PRIMARY KEY,
ACNO CHAR(6) NOT NULL,
AMOUNT MONEY NOT NULL,
TRAN_DATE DATETIME NOT NULL CONSTRAINT DEF_TRAN_DATE DEFAULT GETDATE(),
TRAN_TYPE VARCHAR(15) NOT NULL
)
 
SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_TYPE)
VALUES('T0000001','A00001',2000.00,'DEPOSIT')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_TYPE)
VALUES('T0000002','A00002',700.00,'WITHDRAWL')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000003','A00007',2000.00,'04/20/2015','DEPOSIT')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_TYPE)
VALUES('T0000004','A00008',100.00,'WITHDRAWL')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_TYPE)
VALUES('T0000005','A00009',600.00,'WITHDRAWL')

  
SELECT * FROM TRANSACTIONS

SELECT DATEPART(YYYY,GETDATE()) 

SELECT DATEPART(YYYY,'04/17/2014') 

SELECT ACNO,TRAN_DATE,DATEPART(YYYY,TRAN_DATE) 
FROM TRANSACTIONS

SELECT ACNO,DATEPART(YYYY,TRAN_DATE) 
FROM TRANSACTIONS

SELECT ACNO,TRAN_DATE,DATEPART(YY,TRAN_DATE) 
FROM TRANSACTIONS

SELECT ACNO,TRAN_DATE,DATEPART(QQ,TRAN_DATE) 
FROM TRANSACTIONS

SELECT ACNO,TRAN_DATE,DATEPART(MM,TRAN_DATE) 
FROM TRANSACTIONS

SELECT ACNO,TRAN_DATE,DATEPART(DY,TRAN_DATE) 
FROM TRANSACTIONS

SELECT ACNO,TRAN_DATE,DATEPART(WK,TRAN_DATE) 
FROM TRANSACTIONS

SELECT ACNO,TRAN_DATE,DATEPART(DW,TRAN_DATE) 
FROM TRANSACTIONS

SELECT ACNO,TRAN_DATE,DATEPART(HH,TRAN_DATE) 
FROM TRANSACTIONS

SELECT ACNO,TRAN_DATE,DATEPART(MI,TRAN_DATE) 
FROM TRANSACTIONS

SELECT ACNO,TRAN_DATE,DATEPART(SS,TRAN_DATE) 
FROM TRANSACTIONS

SELECT ACNO,TRAN_DATE,DATEPART(MS,TRAN_DATE) 
FROM TRANSACTIONS


SELECT ACNO,BALANCE            --OUTER QUERY
FROM ACCOUNTS
WHERE ACNO 
IN(SELECT ACNO FROM TRANSACTIONS  --INNER QUERY
   WHERE DATEPART(YYYY,TRAN_DATE)=2015
   GROUP BY ACNO
   HAVING SUM(AMOUNT) > 1000)

UPDATE ACCOUNTS
SET BALANCE = BALANCE + 500
WHERE ACNO 
IN(SELECT ACNO FROM TRANSACTIONS
   WHERE DATEPART(YYYY,TRAN_DATE)=2015
   GROUP BY ACNO
   HAVING SUM(AMOUNT) > 1000)

SELECT ACNO,BALANCE            --OUTER QUERY
FROM ACCOUNTS
WHERE ACNO 
NOT IN(SELECT ACNO FROM TRANSACTIONS  --INNER QUERY
   WHERE DATEPART(YYYY,TRAN_DATE)=2015
   GROUP BY ACNO
   HAVING SUM(AMOUNT) > 1000)
   
   
SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS 

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_TYPE)
VALUES('T0000006','A00002',18500,'WITHDRAWL')  
   
SELECT ACNO,BALANCE            --OUTER QUERY
FROM ACCOUNTS
WHERE BALANCE 
IN(SELECT AMOUNT FROM TRANSACTIONS  --INNER QUERY
   WHERE DATEPART(YYYY,TRAN_DATE)=2015 
   AND TRAN_TYPE = 'WITHDRAWL')
   

UPDATE ACCOUNTS
SET BALANCE = 0
WHERE BALANCE
IN(SELECT AMOUNT FROM TRANSACTIONS  --INNER QUERY
   WHERE DATEPART(YYYY,TRAN_DATE)=2015 
   AND TRAN_TYPE = 'WITHDRAWL')
   
SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS 

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_TYPE)
VALUES('T0000007','A00001',28500,'WITHDRAWL')  
   
SELECT ACCOUNTS.ACNO,BALANCE            
FROM ACCOUNTS JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO
AND DATEPART(YYYY,TRAN_DATE)=2015
AND ACCOUNTS.BALANCE = TRANSACTIONS.AMOUNT


UPDATE ACCOUNTS
SET BALANCE = 0           
FROM ACCOUNTS JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO
AND DATEPART(YYYY,TRAN_DATE)=2015
AND ACCOUNTS.BALANCE = TRANSACTIONS.AMOUNT 

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS 

DELETE ACCOUNTS

TRUNCATE TABLE ACCOUNTS --FASTER THAN DELETE COMMAND
                        -- ONE TIME ENTRY IN LOG FILE
DELETE ACCOUNTS
WHERE ACNO = 'A00004'

DELETE ACCOUNTS
WHERE DATEPART(YYYY,OPENING_DATE) = 2005

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000008','A00007',2000.00,'04/20/2003','DEPOSIT')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000009','A00007',2000.00,'04/20/2005','DEPOSIT')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000010','A00007',2000.00,'04/20/2004','DEPOSIT')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000011','A00003',2000.00,'04/20/2004','DEPOSIT')


SELECT ACNO,TRAN_DATE
FROM TRANSACTIONS
WHERE DATEPART(YYYY,TRAN_DATE) <= 2005

DELETE TRANSACTIONS
WHERE DATEPART(YYYY,TRAN_DATE) <= 2005

SELECT * FROM ACCOUNTS
WHERE LAST_NAME = 'SHARMA'

DELETE ACCOUNTS
WHERE LAST_NAME = 'SHARMA'

--28/04/2015

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

DROP TRIGGER ACCOUNT_DELETE_TRIGGER

CREATE TRIGGER ACCOUNT_DELETE_TRIGGER
ON ACCOUNTS
FOR DELETE
AS
BEGIN
DECLARE @ACNO CHAR(7)
SELECT @ACNO = ACNO FROM DELETED
DELETE TRANSACTIONS
WHERE ACNO = @ACNO
PRINT @ACNO+' RECORD HAS BEEN DELETED FROM ACCOUNTS TRANSACTION TABLE'
END

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

DELETE ACCOUNTS
WHERE ACNO = 'A00001'

DELETE TRANSACTIONS
WHERE ACNO = 'A00002'

DROP TRIGGER TRANSACTION_INSERT_TRIGGER

CREATE TRIGGER TRANSACTION_INSERT_TRIGGER
ON TRANSACTIONS
FOR INSERT
AS
BEGIN
DECLARE @ACNO CHAR(7)
DECLARE @AMOUNT MONEY
DECLARE @TRAN_TYPE VARCHAR(15)
DECLARE @BALANCE MONEY
SELECT @ACNO = ACNO FROM INSERTED
SELECT @AMOUNT = AMOUNT FROM INSERTED
SELECT @TRAN_TYPE = TRAN_TYPE FROM INSERTED
IF @TRAN_TYPE = 'DEPOSIT'
BEGIN
	UPDATE ACCOUNTS
	SET BALANCE = BALANCE + @AMOUNT
	WHERE ACNO = @ACNO	
END
ELSE IF @TRAN_TYPE = 'WITHDRAWL'
BEGIN
	SELECT @BALANCE = BALANCE
	FROM ACCOUNTS
	WHERE ACNO = @ACNO
	IF @AMOUNT > @BALANCE
	BEGIN
		PRINT 'INSUFFICIENT BALANCE, TRANSACTION IS NOT POSSIBLE'
		ROLLBACK TRANSACTION
	END
	ELSE
	BEGIN	 
		UPDATE ACCOUNTS
		
		SET BALANCE = BALANCE - @AMOUNT
		WHERE ACNO = @ACNO
		--COMMIT TRANSACTION
		PRINT 'TRANSACTION HAS BEEN DONE'	
	END
END
ELSE 
BEGIN
	ROLLBACK TRANSACTION
	PRINT 'INVALID TRANSACTION TYPE'	
END
END

SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000012','A00001',2000.00,'04/20/2004','DEPOSIT')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000014','A00001',9000.00,'04/20/2004','WITHDRAWL')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000015','A00001',6000.00,'04/20/2004','WITH')

INSERT TRANSACTIONS(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000017','A00001',3000.00,'04/20/2004','WITHDRAWL')


DELETE ACCOUNTS           

DELETE ACCOUNTS           
FROM ACCOUNTS
WHERE ACNO = 'A00002'

SELECT * FROM ACCOUNTS

SELECT ACNO,AMOUNT         
FROM TRANSACTIONS
GROUP BY ACNO
HAVING SUM(AMOUNT) > 1000

SELECT * FROM TRANSACTIONS

SELECT ACNO         
FROM TRANSACTIONS
GROUP BY ACNO
HAVING SUM(AMOUNT) > 1000


SELECT ACNO,FIRST_NAME,LAST_NAME        
FROM ACCOUNTS
WHERE ACNO 
IN(SELECT ACNO FROM TRANSACTIONS
    GROUP BY ACNO
    HAVING SUM(AMOUNT) > 1000)

DELETE ACCOUNTS           
FROM ACCOUNTS
WHERE ACNO 
IN(SELECT ACNO FROM TRANSACTIONS 
   GROUP BY ACNO
   HAVING SUM(AMOUNT) > 1000)
   
SELECT * FROM ACCOUNTS

SELECT * FROM TRANSACTIONS
   
SELECT ACCOUNTS.ACNO,FIRST_NAME,BALANCE           
FROM ACCOUNTS JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO
AND FIRST_NAME LIKE 'AM%'

DELETE ACCOUNTS          
FROM ACCOUNTS JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO
AND FIRST_NAME LIKE '%M%'

SELECT * FROM ACCOUNTS  
WHERE LAST_NAME = 'SHARMA'

DELETE ACCOUNTS  
WHERE LAST_NAME = 'SHARMA'


CREATE VIEW ACCOUNT_VIEW
AS
SELECT ACNO,FIRST_NAME,LAST_NAME,BALANCE,AC_TYPE
FROM ACCOUNTS

SELECT * FROM ACCOUNT_VIEW

CREATE VIEW ACCOUNT_TRANSACTION_VIEW
AS
SELECT ACCOUNTS.ACNO,FIRST_NAME,BALANCE,AMOUNT,
TRAN_DATE,TRAN_TYPE           
FROM ACCOUNTS JOIN TRANSACTIONS
ON ACCOUNTS.ACNO = TRANSACTIONS.ACNO

SELECT * FROM ACCOUNT_TRANSACTION_VIEW

CREATE VIEW TRANSACTION_VIEW
AS
SELECT * FROM TRANSACTIONS


SELECT * FROM TRANSACTION_VIEW


INSERT TRANSACTION_VIEW(TRAN_ID,ACNO,AMOUNT,TRAN_DATE,TRAN_TYPE)
VALUES('T0000008','A00009',600.00,'04/16/2015','WITHDRAWL')

UPDATE TRANSACTION_VIEW
SET AMOUNT = 15000
WHERE TRAN_ID = 'T0000004'

DELETE TRANSACTION_VIEW
WHERE TRAN_ID = 'T0000004'


--26/05/15---

BEGIN TRANSACTION TRAN1
SELECT * FROM ACCOUNTS
COMMIT TRANSACTION  TRAN1

BEGIN TRANSACTION TRAN1
SELECT * FROM ACCOUNTS
ROLLBACK TRANSACTION  TRAN1

 
SELECT * FROM ACCOUNTS


BEGIN TRAN T1;
SELECT * FROM ACCOUNTS
BEGIN TRAN M2 WITH MARK;
SELECT * FROM TRANSACTIONS
COMMIT TRAN M2;
COMMIT TRAN T1;

SELECT COUNT(*) FROM HumanResources.JobCandidate

SELECT * FROM AdventureWorks.HumanResources.JobCandidate


BEGIN TRANSACTION CandidateDelete
USE AdventureWorks;
IF(SELECT COUNT(*) FROM AdventureWorks.HumanResources.JobCandidate)>11
BEGIN
	DELETE FROM AdventureWorks.HumanResources.JobCandidate
    WHERE JobCandidateID = 13;
    PRINT 'RECORDS HAS BEEN DELETED'
    COMMIT TRANSACTION CandidateDelete
END
ELSE
BEGIN
	ROLLBACK TRANSACTION CandidateDelete
    PRINT 'RECORDS HAS NOT BEEN DELETED'
END
GO


DECLARE @TranName VARCHAR(20);
SELECT @TranName = 'MyTransaction';

BEGIN TRANSACTION @TranName
USE AdventureWorks;
IF(SELECT COUNT(*) FROM AdventureWorks.HumanResources.JobCandidate)>18
BEGIN
	DELETE FROM AdventureWorks.HumanResources.JobCandidate
    WHERE JobCandidateID = 16;
    PRINT 'RECORDS HAS BEEN DELETED'
    COMMIT TRANSACTION @TranName
END
ELSE
BEGIN
	ROLLBACK TRANSACTION @TranName
    PRINT 'RECORDS HAS NOT BEEN DELETED'
   END
GO






   






