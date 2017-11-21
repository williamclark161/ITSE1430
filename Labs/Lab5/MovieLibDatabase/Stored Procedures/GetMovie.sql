CREATE PROCEDURE [dbo].[GetMovie]
    @id INT
AS BEGIN
    SET NOCOUNT ON;

    SELECT Id, Title, Length, Description, IsOwned
    FROM Movies
    WHERE Id = @id
END
