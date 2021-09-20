CREATE TABLE [dbo].[Usuario] (
    [Id]     INT           NOT NULL IDENTITY(1,1),
	[email] VARCHAR(255)   NOT NULL UNIQUE,
    [nombre] VARCHAR (50) NOT NULL,
    [edad]   TINYINT       NOT NULL,
    [altura] FLOAT (53)    NOT NULL,
    [activo] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

