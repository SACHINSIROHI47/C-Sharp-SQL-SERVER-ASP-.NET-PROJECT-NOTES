-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE AptechProcedure 
	-- Add the parameters for the stored procedure here
	@p1 int = 0, 
	@p2 int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT @p1, @p2

END
GO


----------------------------------------------------------------------
-- run this in query window 2
BEGIN TRANSACTION
 
--2
UPDATE ##TableB
SET Val = N'F'
WHERE ID = 1
--------------------------------------
WAITFOR DELAY '00:00:07'
 
 
--4
UPDATE ##TableA
SET Val = N'H'
WHERE ID = 1
 
 
COMMIT
 
SELECT Val, GETDATE() AS CompletionTime FROM ##TableA WHERE ID=1
SELECT Val, GETDATE() AS CompletionTime FROM ##TableB WHERE ID=1