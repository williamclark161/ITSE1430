CREATE TABLE [dbo].[Movies]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Title] NVARCHAR(100) NOT NULL,
    [Description] NVARCHAR(MAX),
    [Length] INT NOT NULL,
    [IsOwned] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [CK_Movies_TitleSet] CHECK (LEN([Title]) > 0), 
    CONSTRAINT [AK_Movies_Title] UNIQUE ([Title]), 
    CONSTRAINT [CK_Movies_LengthPositive] CHECK ([Length] >= 0)
)
