CREATE ASSEMBLY ValidateEmailAssembly 
FROM 'C:\ValidateMail\ValidateMail\bin\Debug\ValidateMail.dll'
WITH PERMISSION_SET = UNSAFE


CREATE TABLE Users
(
    UserName nvarchar(200) NOT NULL,
    RealName nvarchar(200) NOT NULL
)

CREATE TABLE UserNameAudit
(
    UserName nvarchar(200) NOT NULL,
    RealName nvarchar(200) NOT NULL
)



CREATE TRIGGER EmailAudit
ON Users FOR INSERT
AS EXTERNAL NAME ValidateEmailAssembly.trgMail.MailValid


   INSERT INTO Users VALUES('peter@yahoo.com', 'Peter')
   INSERT INTO Users VALUES('johnyahoo.com', 'John')
