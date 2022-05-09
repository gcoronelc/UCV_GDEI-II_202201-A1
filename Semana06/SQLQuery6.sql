/*
Se necesita hacer búsquedas de empleados por apellido y nombre, se le pide diseñar
la mejor solución, justifique su respuesta.
Implementar su propuesta y verificarla recogiendo las evidencias del caso.
*/
/*
1. Analizar del requerimiento.

Normalmente la busqueda de información se realiza por varias columnas.
En este caso, se buscara por 2 columnas de la tabla empleado.
*/

/*
2. Diseñar una solución.

select * from empleado;

select * from empleado
where apellido like '%villa%' and nombre like '%nora%'

para esta consulta, el inice es:

CREATE INDEX empleado_idx_1
ON empleado(apellido,nombre);

*/

/*
3. Implementar la solución.
*/

select * into empleado2
from empleado;
go

-- Profesor, ejecutelo 10 veces minimo
insert into empleado2 
select * from empleado;
go

CREATE INDEX empleado_idx_1
ON empleado2(apellido,nombre);
go



/*
4. Verificar su funcionamiento.
*/

ALTER INDEX [empleado_idx_1] ON [dbo].[empleado2] DISABLE
GO

select * from empleado2
where apellido like '%villa%' and nombre like '%nora%';

ALTER INDEX [empleado_idx_1] ON [dbo].[empleado2] REBUILD; 
GO

select * from empleado2
where apellido = 'villa' and nombre = 'nora';
GO

select * from empleado2
where apellido LIKE '%villa%' and nombre LIKE '%nora%';
GO

select * from empleado2
where CONTAINS(apellido,'villa') and CONTAINS(nombre,'nora');
GO


/*
5. Recoger evidencias.

6. Elaborar informe que incluya conclusiones y recomendaciones.
*/