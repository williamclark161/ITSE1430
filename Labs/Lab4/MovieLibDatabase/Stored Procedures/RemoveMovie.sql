﻿CREATE PROCEDURE [dbo].[RemoveMovie]
    @id INT
AS BEGIN
    SET NOCOUNT ON;

    DELETE FROM Movies
    WHERE Id = @id
END
