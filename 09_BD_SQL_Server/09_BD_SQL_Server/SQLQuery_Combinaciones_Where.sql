--select * from Coche as c, Usuario as u where c.id = u.idCoche and u.edad > 23;
--select c.* from Coche as c, Usuario as u where c.id = u.idCoche and u.edad > 23;
--select u.* from Coche as c, Usuario as u where c.id = u.idCoche and u.edad > 23;
select sum(c.Cantidad) as cantidad 
from Producto as p inner join CompraUsuarioProducto as c on p.id = c.idproducto inner join Usuario as u on c.idUsuario = u.id
where c.IdUsuario = u.id and c.IdProducto = p.id and u.edad > 23;

