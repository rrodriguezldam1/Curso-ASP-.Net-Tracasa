CREATE TABLE [dbo].[Usuario] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [email]  VARCHAR (255) NOT NULL,
    [nombre] VARCHAR (50)  NOT NULL,
    [edad]   TINYINT       NOT NULL,
    [altura] FLOAT (53)    NOT NULL,
    [activo] BIT           NOT NULL,
    [idCoche]  INT  NULL,
    [direccion] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([email] ASC),
	CONSTRAINT FK_idCoche_Coche FOREIGN KEY (idCoche) REFERENCES Coche(Id)
);

