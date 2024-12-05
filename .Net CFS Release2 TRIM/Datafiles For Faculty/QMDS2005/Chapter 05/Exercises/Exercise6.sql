SELECT JobCandidateID, Resume.value('declare namespace 
ns="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/Resume";
(/ns:Resume/ns:Name/ns:Name.First)[1]','nvarchar(20)') AS [First Name],
Resume.value('declare namespace 
ns="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/Resume";
(/ns:Resume/ns:Name/ns:Name.Last)[1]','nvarchar(20)') AS [Last Name],
Resume.value('declare namespace 
ns="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/Resume";
(/ns:Resume/ns:Skills)[1]','nvarchar(max)') AS [Skills]
FROM HumanResources.JobCandidate
