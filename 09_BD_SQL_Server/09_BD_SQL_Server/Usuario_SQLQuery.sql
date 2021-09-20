-- select distinct edad from dbo.Usuario
-- select COUNT(distinct edad) from dbo.Usuario

-- select * from [dbo].[Usuario] where edad > 40
-- select * from [dbo].[Usuario] where ACTIVO = 0

-- select * from [dbo].[Usuario] where ACTIVO = 0 and altura < 1.8
-- select * from [dbo].[Usuario] where ACTIVO = 0 or edad >= 25
-- select * from [dbo].[Usuario] where not(ACTIVO = 0 or edad >= 25)

--SELECT *
--FROM Usuario
--ORDER BY edad DESC, activo DESC

--SELECT *
--FROM Usuario
--WHERE coche is not null

--SELECT TOP 5 *
--FROM Usuario
--WHERE coche is null
--order by edad desc;

--SELECT * FROM (
--	SELECT TOP 5 *
--	FROM Usuario
--	WHERE coche is null
--	order by edad desc) as subconsulta
--order by nombre;

--select count(activo) from Usuario group by activo;

--SELECT * FROM (
--	SELECT TOP 3 *
--	FROM Usuario
--	order by altura) as subconsulta
--order by edad;

--SELECT * FROM Usuario
--    WHERE coche IN (
--        SELECT coche FROM Usuario
--            GROUP BY coche
--            HAVING COUNT(*)>1
--);

SELECT top 1 * FROM Usuario
WHERE coche is not null
order by edad desc;

SELECT top 1 * FROM Usuario
WHERE coche is null and activo = 0
order by edad;

select avg(edad) as'Edad Media Inactivos' from usuario where activo = 0;
select avg(edad) as 'Edad Media Activos' from usuario where activo = 1;
select avg(edad) as 'Edad Media Sin Coche' from usuario where coche is null;
select avg(edad) as 'Edad Media Con Coche' from usuario where coche is not null;