CREATE DATABASE SBI

DROP DATABASE SBI

USE SBI
DROP TABLE USERS

CREATE TABLE USERS
(
UserName VARCHAR(50),
FavoriteColor VARCHAR(30)
)

INSERT USERS(UserName,FavoriteColor)
VALUES('Mikal','Green')

SELECT * FROM USERS


CREATE TABLE USERS
(
UserName VARCHAR(50)PRIMARY KEY,
FavoriteColor VARCHAR(30)
)