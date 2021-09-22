declare @aux_id int
declare cur_u cursor for select u.id from Usuario u

open cur_u
	
fetch next from cur_u into @aux_id

while @@FETCH_STATUS = 0
begin
	select sum(c.Cantidad) TotalCantidad, (select nombre from Usuario where Usuario.id = @aux_id) Nombre
	from CompraUsuarioProducto c where c.IdUsuario = @aux_id
	fetch next from cur_u into @aux_id
end

close cur_u
deallocate cur_u