DECLARE @Count AS INT
declare @Usu AS INT
declare @Prod AS INT
declare @FechaStr AS varchar(100)
declare @Fecha AS DATETIME
declare @Cantidad AS INT

DELETE FROM CompraUsuarioProducto WHERE 1 = 1;

SET @Count = 0
while @Count < 30
BEGIN
	SET @Count = @Count + 1
	SET @Usu = 10 + RAND(CHECKSUM(NEWID())) * 10
	SET @Prod = 1 + RAND(CHECKSUM(NEWID())) * 6
	SET @Cantidad = 1 + RAND(CHECKSUM(NEWID())) * 100
	SET @FechaStr = CAST(ROUND(2018 + RAND(CHECKSUM(NEWID())) * 2, 0) AS VARCHAR)
			+ '-' + CAST(ROUND(1 + RAND(CHECKSUM(NEWID())) * 11, 0) AS VARCHAR)
			+ '-' + CAST(ROUND(1 + RAND(CHECKSUM(NEWID())) * 27, 0) AS VARCHAR);
	-- dateadd(day, (abs(CHECKSUM(newid())) % 3650) * -1, getdate());
	-- set @fecha = DATEADD(DAY,ABS(CHECKSUM(NEWID()))% (1+DATEDIFF(DAY,@fechafin,@fechaini)),@fechaini)
	SET @Fecha = CAST(@FechaStr as datetime)
	INSERT INTO CompraUsuarioProducto (IdUsuario, IdProducto, Fecha, Cantidad)
			VALUES (@Usu, @Prod, @Fecha, @Cantidad)
	PRINT ' ID Usu ' + CAST(@Usu AS VARCHAR) + ' - ' + @FechaStr
END;
PRINT 'Final bucle';