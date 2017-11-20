/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
DECLARE @count INT

SELECT @count = COUNT(*) FROM Movies

IF @count = 0
BEGIN
    INSERT INTO Movies (Title, Description, Length, IsOwned) VALUES
        ('Pulp Fiction', 'My #1 Of All Time', 154, 1),
        ('Wonder Woman', 'Best DCEU Film So Far', 141, 0),
        ('The Lion King', 'Very Heart Felt Film', 88, 1),
        ('iFull Metal Jacket', 'IMO, Kubrick Masterpiece', 116, 1)
END