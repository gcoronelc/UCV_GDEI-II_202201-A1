-- Enunciado
/*
Desarrolle una VISTA para encontrar los departamentos que tienen más de 5 trabajadores.
Base de datos RH.
*/


/*
1.Analizar cada requerimiento.

   CODIGO         NOMBRE              CANTIDAD
DEPARTAMENTO   DEPARTAMENTO         TRABAJADORES
------------------------------------------------------------

------------------------------------------------------------

¿Por que campo quiere ordenado el reporte?
El orden por defecto debe ser en formas descendente por cantidad de 
trabajadores, pero la solución debe permitirme seleccionar yo el orden.
*/

/*
2. Identificar los datos que debe tener el reporte.

   CODIGO         NOMBRE              CANTIDAD
DEPARTAMENTO   DEPARTAMENTO         TRABAJADORES
------------------------------------------------------------

------------------------------------------------------------

*/

/*
3. Identificar las tablas de donde obtendrá los datos.

CODIGO DEPARTAMENTO: Tabla DEPARTAMENTO
NOMBRE DEPARTAMENTO: Tabla DEPARTAMENTO
CANTIDAD TRABAJADORES: Tabla EMPLEADO
*/


/*
4. Crear la vista en la base de datos.

Paso 1: Calcular la cantidad de trabajadores por departamento
Paso 2: Filtrar los departamentos que tienen mas de 5 trabajadores
Paso 3: Completar los datos
*/


-- Paso 1: Calcular la cantidad de trabajadores por departamento

select  iddepartamento, COUNT(1) empleados
from rh..empleado
group by iddepartamento;
go

-- Paso 2: Filtrar los departamentos que tienen mas de 5 trabajadores

WITH 
V1 as (
	select  iddepartamento, COUNT(1) empleados
	from rh..empleado
	group by iddepartamento
)
select * from v1 
where empleados > 5;
go

-- Paso 3: Completar los datos

create view V_GA_REQ01(CODEPT, NOMDEPT, EMPLEADOS)
AS
WITH 
V1 as (
	select  iddepartamento, COUNT(1) empleados
	from rh..empleado
	group by iddepartamento
),
V2 as (
	select * from v1 
	where empleados > 5
)
select d.iddepartamento, d.nombre, v2.empleados
from rh..departamento d
join V2 on d.iddepartamento = V2.iddepartamento;
go

select * from V_GA_REQ01;
go


/*
5. Verificar su resultado.
*/

select  iddepartamento, COUNT(1) empleados
from rh..empleado
group by iddepartamento
order by 2 desc;
go

select * from V_GA_REQ01 order by 3 desc;
go


/*
6. Consultar la vista desde Microsoft Excel
*/


