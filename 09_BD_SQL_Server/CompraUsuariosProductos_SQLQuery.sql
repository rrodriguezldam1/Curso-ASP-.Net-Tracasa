declare @count as int
declare @Usu as int
declare @Prod as int
declare @Fecha as datetime
declare @FechaStr as varchar(100)
declare @Cantidad as int

DELETE FROM CompraUsuarioProducto WHERE 1 = 1;

set @count = 0
while @count < 300
begin
	set @count = @count + 1
	set @Usu = 10 + rand(CHECKSUM(newid())) * 10
	set @Prod = 1 + rand(CHECKSUM(newid())) * 5
	set @Cantidad = 1 + rand(CHECKSUM(newid())) * 100
	set @FechaStr = dateadd(day, (abs(checksum(newid())) % 3650) * -1, GETDATE());
	insert into CompraUsuarioProducto (IdUsuario, IdProducto, Fecha, Cantidad) values (@Usu, @Prod, @FechaStr, @Cantidad)
	print ' ID Usu ' + cast(@Usu as varchar) + ' - ' + cast(@Prod as varchar) + @FechaStr
end
print 'Final bucle';