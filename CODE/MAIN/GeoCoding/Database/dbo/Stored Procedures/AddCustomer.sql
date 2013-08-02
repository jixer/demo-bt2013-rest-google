-- =============================================
-- Author:		Chris Myers
-- Create date: 20130325
-- Description:	
-- =============================================
CREATE PROCEDURE AddCustomer 
	-- Add the parameters for the stored procedure here
	@firstName nvarchar(150), 
	@lastName nvarchar(150),
	@street1 [nvarchar](255),
	@street2 [nvarchar](255),
	@city [nvarchar](100),
	@state [varchar](2),
	@zip [varchar](12),
	@lat [int],
	@long [int]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Customer]
			   ([FirstName]
			   ,[LastName]
			   ,[Street1]
			   ,[Street2]
			   ,[City]
			   ,[State]
			   ,[Zip]
			   ,[Lat]
			   ,[Long])
		 VALUES
			   (@firstName
			   ,@lastName
			   ,@street1
			   ,@street2
			   ,@city
			   ,@state
			   ,@zip
			   ,@lat
			   ,@long)
END