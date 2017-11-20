CREATE PROCEDURE [dbo].[GetAllMovies]	
AS BEGIN
    SET NOCOUNT ON;

    SELECT Id, Title, Length, Description, IsOwned
    FROM Movies
END
