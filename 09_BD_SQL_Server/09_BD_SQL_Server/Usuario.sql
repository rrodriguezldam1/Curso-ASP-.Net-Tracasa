CREATE TABLE [dbo].[Usuario]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nombre] VARCHAR(MAX) NOT NULL, 
    [edad] TINYINT NOT NULL, 
    [altura] FLOAT NOT NULL, 
    [activo] BIT NOT NULL
)
