/* 1.	Create a schema.
==========================*/

CREATE XML SCHEMA COLLECTION EmployeeSchemaCollection as 
'<?xml version="1.0"?> 
<xsd:schema 
        targetNamespace="http://schemas.adventure-works.com/Employees" 
        xmlns="http://schemas.adventure-works.com/Employees" 
        elementFormDefault="qualified" 
        attributeFormDefault="unqualified" 
        xmlns:xsd="http://www.w3.org/2001/XMLSchema" > 
<xsd:element name="EmployeeDetails"> 
<xsd:complexType> 
<xsd:sequence> 
        <xsd:element name="PreviousEmploymentOrg" minOccurs="1" maxOccurs="5"> 
		<xsd:complexType>
		<xsd:simpleContent>
		<xsd:extension base="xsd:string">
		 		<xsd:attribute name="PreviousEmploymentAddress" type="xsd:string" /> 
                <xsd:attribute name="PreviousEmploymentDesig" type="xsd:string" /> 
                <xsd:attribute name="PreviousEmploymentDuration" type="xsd:string" /> 
		</xsd:extension>
		</xsd:simpleContent>
		</xsd:complexType>	
		</xsd:element>
</xsd:sequence> 
</xsd:complexType>      
</xsd:element>
</xsd:schema>'


/* 2.	Create the EmployeeHistoryDetails table by using the schema.
======================================================================*/

CREATE TABLE EmployeeHistoryDetails
(
	EmployeeID int,
	EmploymentHistory XML(EmployeeSchemaCollection)
)



/* 3.	Insert records in the EmployeeHistoryDetails table.
============================================================*/


INSERT INTO EmployeeHistoryDetails VALUES (1001, 
'<?xml version="1.0"?>
<EmployeeDetails xmlns="http://schemas.adventure-works.com/Employees">
	<PreviousEmploymentOrg 
		PreviousEmploymentAddress = "New Jersey"
		PreviousEmploymentDesig = "Software Developer"
		PreviousEmploymentDuration = "3 Years"> HP </PreviousEmploymentOrg>
	</EmployeeDetails>')

INSERT INTO EmployeeHistoryDetails VALUES (1002, 
'<?xml version="1.0"?>
<EmployeeDetails xmlns="http://schemas.adventure-works.com/Employees">
	<PreviousEmploymentOrg 
		PreviousEmploymentAddress = "New York"
		PreviousEmploymentDesig = "Project Manager"
		PreviousEmploymentDuration = "2 Years"> IBM </PreviousEmploymentOrg>
</EmployeeDetails>')




/* 4.	Verify the insertion of records.
===========================================*/

SELECT * FROM EmployeeHistoryDetails
