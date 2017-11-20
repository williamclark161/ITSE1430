CREATE PROCEDURE [dbo].[AddMovie]
	@title NVARCHAR(100),
    @length INT,    
    @description NVARCHAR(MAX) = NULL,
	@isOwned BIT = 0
AS BEGIN
    SET NOCOUNT ON;

    INSERT INTO Movies (Title, Length, Description, IsOwned) VALUES (@title, @length, @description, @isOwned)

    SELECT SCOPE_IDENTITY()
END
