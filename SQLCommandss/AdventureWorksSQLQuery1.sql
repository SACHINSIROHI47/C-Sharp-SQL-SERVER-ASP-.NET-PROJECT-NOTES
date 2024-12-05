
USE AdventureWorks

SELECT * FROM HumanResources.Employee

SELECT * FROM Person.Contact

SELECT * FROM HumanResources.Employee

SELECT EmployeeID, ContactID, LoginID, Title 
FROM HumanResources.Employee

SELECT 'Department Number'= DepartmentID,'Department Name'= Name
FROM HumanResources.Department 

SELECT EmployeeID, 'Designation: ', Title
FROM HumanResources.Employee

SELECT EmployeeID, Rate,Per_Day_Rate = 8 * Rate 
FROM HumanResources.EmployeePayHistory

SELECT * FROM HumanResources.Department 
WHERE GroupName = 'Research and Development'

SELECT EmployeeID, NationalIDNumber, Title, VacationHours 
FROM HumanResources.Employee      
WHERE VacationHours < 5

SELECT EmployeeID, NationalIDNumber, Title, VacationHours 
FROM HumanResources.Employee      
WHERE VacationHours = 5

SELECT EmployeeID, NationalIDNumber, Title, VacationHours 
FROM HumanResources.Employee      
WHERE VacationHours <= 5

SELECT EmployeeID, NationalIDNumber, Title, VacationHours 
FROM HumanResources.Employee      
WHERE VacationHours != 5

SELECT EmployeeID, Title, LoginID 
FROM HumanResources.Employee                       	
WHERE Title IN ('Recruiter', 'Stocker')

SELECT EmployeeID, Title, LoginID 
FROM HumanResources.Employee                       	
WHERE Title NOT IN ('Recruiter', 'Stocker')


SELECT * FROM HumanResources.Department 
WHERE GroupName = 'Manufacturing' OR GroupName = ' Quality Assurance'

SELECT * FROM HumanResources.Department 
WHERE GroupName = 'Manufacturing' AND Name = 'Production'

SELECT * FROM HumanResources.Department 
WHERE GroupName = 'Manufacturing' AND NOT Name = 'Production'

SELECT * FROM HumanResources.Department 
WHERE NOT GroupName = 'Manufacturing'

SELECT * FROM HumanResources.Department 
WHERE GroupName = 'Manufacturing'

SELECT EmployeeID, VacationHours                	
FROM HumanResources.Employee                         	
WHERE VacationHours BETWEEN 20 AND 50

SELECT EmployeeID, VacationHours                	
FROM HumanResources.Employee                         	
WHERE VacationHours NOT BETWEEN 20 AND 50

SELECT EmployeeID, Title, LoginID 
FROM HumanResources.Employee                       	
WHERE Title IN ('Recruiter', 'Stocker')

SELECT EmployeeID, Title, LoginID 
FROM HumanResources.Employee                       	
WHERE Title NOT IN ('Recruiter', 'Stocker')

SELECT EmployeeID, NationalIDNumber, Title, VacationHours 
FROM HumanResources.Employee      
WHERE VacationHours IN(5,10,15,28)

SELECT * FROM HumanResources.Employee

SELECT * FROM HumanResources.Employee
WHERE BirthDate in ('05/15/1972','01/23/1965')

SELECT * FROM HumanResources.Department
WHERE Name LIKE 'Pro%'

--WILD CARD CHARACTER %

SELECT * FROM HumanResources.Department
WHERE Name LIKE 'M%'

SELECT * FROM HumanResources.Department
WHERE Name LIKE '[MSR]%'

SELECT * FROM HumanResources.Department
WHERE Name LIKE '[A-E]%'

SELECT * FROM HumanResources.Department
WHERE Name NOT LIKE '[MSR]%'

SELECT * FROM HumanResources.Department
WHERE Name LIKE '[^MSR]%'

SELECT * FROM HumanResources.Department
WHERE Name LIKE '[^A-E]%'

SELECT EmployeeID, EndDate
FROM HumanResources.EmployeeDepartmentHistory  
WHERE EndDate IS NULL

SELECT EmployeeID, EndDate
FROM HumanResources.EmployeeDepartmentHistory  
WHERE EndDate IS NOT NULL

SELECT GroupName, DepartmentID, Name
FROM HumanResources.Department
ORDER BY GroupName 

SELECT GroupName, DepartmentID, Name
FROM HumanResources.Department
ORDER BY GroupName ASC

SELECT GroupName, DepartmentID, Name
FROM HumanResources.Department
ORDER BY GroupName DESC

SELECT GroupName, DepartmentID, Name
FROM HumanResources.Department
ORDER BY GroupName, DepartmentID

SELECT  DepartmentID, Name
FROM HumanResources.Department
ORDER BY GroupName, DepartmentID

SELECT TOP 10 * FROM HumanResources.Employee

SELECT TOP 10 PERCENT * FROM HumanResources.Employee

SELECT TOP 10 EmployeeID,Title 
FROM HumanResources.Employee

SELECT Title FROM
HumanResources.Employee
WHERE Title LIKE 'PR%'

SELECT DISTINCT Title FROM
HumanResources.Employee
WHERE Title LIKE 'PR%'

SELECT * FROM Production.ProductModel 
WHERE Name LIKE 'HL%'
















