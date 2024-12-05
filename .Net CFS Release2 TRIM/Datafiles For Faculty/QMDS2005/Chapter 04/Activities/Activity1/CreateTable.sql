CREATE TABLE HumanResources.EmployeeReimbursements 
(
RimID int CONSTRAINT pkRim PRIMARY KEY,
Employee_ID int CONSTRAINT fkEid FOREIGN KEY REFERENCES HumanResources.Employee(EmployeeID) NOT NULL,
Amount money CONSTRAINT ckMon CHECK (Amount>0),
RimType varchar(20) CONSTRAINT [ckType] CHECK (RimType IN ('Medical','Cash','Local')),
Pending_with varchar(30) NOT NULL
)
