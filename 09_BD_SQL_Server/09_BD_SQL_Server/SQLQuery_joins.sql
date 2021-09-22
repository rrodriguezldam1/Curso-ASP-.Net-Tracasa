--select u.id, u.email, c.Id, c.Marca 
--from Usuario as u inner join Coche as c on u.idCoche = c.Id;

--select u.id, u.email, c.Id, c.Marca 
--from Usuario as u left join Coche as c on u.idCoche = c.Id;

--select u.id, u.email, c.Id, c.Marca 
--from Usuario as u right join Coche as c on u.idCoche = c.Id;

--select u.id, u.email, c.Id, c.Marca 
--from Usuario as u full outer join Coche as c on u.idCoche = c.Id;




--EJERCICIOS




--select SUM(c.Cantidad) from Producto as P, CompraUsuarioProducto as C, Usuario as U 
--			where C.IdUsuario = U.Id and C.IdProducto = P.Id and U.edad <= 20 
--		1 - Esta consulta con JOIN
select sum(c.Cantidad) cantidadTotal
from Producto p inner join CompraUsuarioProducto c on p.id = c.idProducto inner join Usuario u on c.idUsuario = u.id
where u.edad > 23;

--Por cada usuario, nombre de usuario y nombre de producto,
--		2 - El precio del producto de sus compras
--		3 - Cuanto se ha gastado en total en cada producto
--		4 - Cuantas copias del producto ha comprado

select u.nombre, p.Nombre, (c.Cantidad * p.Precio) Coste, c.Cantidad
from Producto p inner join CompraUsuarioProducto c on p.id = c.idProducto inner join Usuario u on c.idUsuario = u.id;

-- Todas las ventas (dinero) 2019
select sum(p.Precio * c.Cantidad) Total
from Producto p inner join CompraUsuarioProducto c on p.id = c.idProducto
where c.Fecha > '01/01/2019';

-- Todos los usuarios que compraron en el 2019
select distinct u.nombre
from Usuario u inner join CompraUsuarioProducto c on u.id = c.IdUsuario
where c.Fecha between '01/01/2019' and '01/01/2020';

--7 - Qué productos se han vendido mejor a lo largo del 2018, 2019 y 2020
select p.nombre
from Producto p inner join CompraUsuarioProducto c on p.id = c.IdProducto
where c.Fecha > '01/01/2018' and c.Fecha < '01/01/2020'
order by c.Cantidad;

--8 - El coche cuyo propietario ha comprado más a lo largo de la historia
declare @aux_id int
declare @aux_mayorCant int
declare @aux_mayorId int
declare @marca varchar
declare cur_u cursor for select c.IdUsuario from CompraUsuarioProducto c

set @aux_mayorCant = 0

open cur_u
	
fetch next from cur_u into @aux_id

while @@FETCH_STATUS = 0
begin
	IF (@aux_mayorCant < (select sum(com.Cantidad) from CompraUsuarioProducto com left join Usuario u on com.IdUsuario = u.id where com.IdUsuario = @aux_id and u.idCoche is not null group by com.IdUsuario))
	begin
		   set @aux_mayorCant = (select sum(com.Cantidad) from CompraUsuarioProducto com where com.IdUsuario = @aux_id group by com.IdUsuario)
		   set @aux_mayorId = (select com.IdUsuario from CompraUsuarioProducto com where com.IdUsuario = @aux_id group by com.IdUsuario)
		   print cast(@aux_mayorId as varchar) + ' ha comprado ' + cast(@aux_mayorCant as varchar)
	end
	fetch next from cur_u into @aux_id
	if @@FETCH_STATUS != 0
	begin
		print cast(@aux_mayorId as varchar) + ' ha sido el mayor comprador ';
		select c.Marca, c.Modelo from Coche c inner join Usuario u on c.Id = u.idCoche where u.Id = @aux_mayorId;
	end
end

close cur_u
deallocate cur_u

--9 - La media de edad de los compradores de cada uno de los productos (melón, cuajada...)
select p.nombre , avg(u.edad) MediaEdad
from Producto p inner join CompraUsuarioProducto c on p.id = c.IdProducto 
	inner join Usuario u on c.IdUsuario = u.id 
group by p.Nombre;

--10 - Qué productos han comprado los usuarios del Bici
select p.nombre
from Producto p inner join CompraUsuarioProducto c on p.id = c.IdProducto 
	inner join Usuario u on c.IdUsuario = u.id inner join Coche co on co.id = u.idCoche
where u.idCoche in (select coc.Id from coche coc where coc.Marca = 'Bici');