CREATE TABLE [dbo].[Customer] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (150) NOT NULL,
    [LastName]  NVARCHAR (150) NOT NULL,
	[Street1]	NVARCHAR (255) NOT NULL,
	[Street2]	NVARCHAR (255),
	[City]		NVARCHAR (100) NOT NULL,
	[State]		VARCHAR(2) NOT NULL,
	[Zip]		VARCHAR(12) NOT NULL,
    [Lat]       INT            NOT NULL,
    [Long]      INT            NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC)
);

