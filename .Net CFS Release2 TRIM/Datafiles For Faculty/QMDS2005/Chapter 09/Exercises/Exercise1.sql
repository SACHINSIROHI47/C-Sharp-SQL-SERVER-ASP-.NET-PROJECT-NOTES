CREATE ASSEMBLY AccDetails FROM 'C:\AccountDetails.dll' WITH PERMISSION_SET = UNSAFE


CREATE FUNCTION AccDetails (@acn nvarchar(20)) RETURNS nvarchar(200) AS EXTERNAL NAME [AccDetails].[AccountDetails.Det].details


SELECT dbo.AccDetails('10-4020-000676') AS Details