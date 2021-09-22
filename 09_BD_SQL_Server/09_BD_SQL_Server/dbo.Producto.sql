CREATE TABLE [dbo].[Producto] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Nombre] VARCHAR (50) NOT NULL,
    [Precio] DECIMAL (18) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

