CREATE PROCEDURE [dbo].[UpdateMovie]
    @id INT,
	@title NVARCHAR(100),
    @length INT,    
    @description NVARCHAR(MAX) = NULL,
	@isOwned BIT = 0
AS BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT * FROM Movies WHERE Id = @id)
	BEGIN
		RAISERROR('Movie not found', 16, 1)
		RETURN
	END

	UPDATE Movies
	SET 
		Title = @title,
		Description = @description, 
		Length = @length,
		IsOwned = @isOwned
	WHERE Id = @id
END
