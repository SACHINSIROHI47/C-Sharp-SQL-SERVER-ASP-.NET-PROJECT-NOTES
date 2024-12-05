
CREATE TRIGGER [HumanResources].[trgDepartment] ON [HumanResources].[Department] 
AFTER UPDATE AS
BEGIN
    UPDATE [HumanResources].[Department]
    SET [HumanResources].[Department].[ModifiedDate] = GETDATE()
    FROM inserted
    WHERE inserted.[DepartmentID] = [HumanResources].[Department].[DepartmentID];
END;

CREATE TRIGGER [HumanResources].[trgMagic] ON [HumanResources].[EmployeeDepartmentHistory] 
AFTER UPDATE AS
BEGIN
SELECT * FROM DELETED
SELECT * FROM INSERTED
END;


UPDATE HumanResources.EmployeeDepartmentHistory SET DepartmentID = 16
WHERE EmployeeID = 4

