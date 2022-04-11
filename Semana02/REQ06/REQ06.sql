-- Enunciado
/*
Desarrolle una VISTA para encontrar el empleado que tiene el menor salario por departamento.
Base de datos RH.
*/

/*
1. Analizar cada requerimiento.

Cada empleado pertenece a un departamento, donde cada uno tiene un sueldo según 
su categoría o escala, adicionalmente puede tener otros beneficios de tal manera
que varios empleados de una misma categoría tengan sueldos diferentes.

El objetivo es conocer quien el empleado que tiene el menor sueldo en cada departamento,
es posible que varios empleados tengan ese menor sueldo.

*/

/*
2. Identificar los datos que debe tener el reporte.

- Codigo y nombre del departamento
- Nombre del trabajador
- Nombre del Cargo del trabajador
- sueldo del trabajador

CODIGO          NOMBRE
DEPARTAMENTO    DEPARTAMENTO  ......
-----------------------------------------------------------------

*/

/*
3. Identificar las tablas de donde obtendrá los datos.

- Codigo y nombre del departamento: tabla departamento- Nombre del trabajador: tabla empleado- Nombre del Cargo del trabajador: tabla cargo- sueldo del trabajador: tabla empleado

*/


/*
4. Crear la vista en la base de datos.

Paso 1: Calcular sueldo de cada trabajador
Paso 2: Identificar el sueldo minimo por departamento
Paso 3: Identificar el empleado(s) con el sueldo minimo por departamento
Paso 4: Completar los datos

*/

select * from rh..empleado;
go

-- Paso 1: Calcular sueldo de cada trabajador

select idempleado, iddepartamento, idcargo, sueldo + ISNULL(comision,0) as sueldo
from rh..empleado;
go

-- Paso 2: Identificar el sueldo minimo por departamento

with 
v1 as (
	select idempleado, iddepartamento, idcargo, sueldo + ISNULL(comision,0) as sueldo
	from rh..empleado
)
select iddepartamento, min(sueldo) sueldo_minimo 
from v1
group by iddepartamento;


-- Paso 3: Identificar el empleado(s) con el sueldo minimo por departamento

with 
v1 as (
	select idempleado, apellido, nombre, iddepartamento, idcargo, sueldo + ISNULL(comision,0) as sueldo
	from rh..empleado
),
v2 as (
	select iddepartamento, min(sueldo) sueldo_minimo 
	from v1
	group by iddepartamento
)
select v1.* 
from v1 join v2 on v1.iddepartamento = v2.iddepartamento and v1.sueldo = v2.sueldo_minimo;
go

-- Paso 4: Completar los datos

create view v_GA_REQ06
as
with 
v1 as (
	select idempleado, apellido, nombre, iddepartamento, idcargo, sueldo + ISNULL(comision,0) as sueldo
	from rh..empleado
),
v2 as (
	select iddepartamento, min(sueldo) sueldo_minimo 
	from v1
	group by iddepartamento
),
v3 as (
	select v1.* 
	from v1 join v2 on v1.iddepartamento = v2.iddepartamento and v1.sueldo = v2.sueldo_minimo
)
select 
	d.iddepartamento, d.nombre as nombre_departamento,
	v3.nombre, v3.apellido, c.nombre as cargo, v3.sueldo
from v3 join rh..departamento d on v3.iddepartamento=d.iddepartamento
join cargo c on v3.idcargo = c.idcargo
go

select * from v_GA_REQ06;
go

/*
5. Verificar su resultado.
*/

select * from v_GA_REQ06;

select iddepartamento, min(sueldo + ISNULL(comision,0)) as sueldo_minimo
from rh..empleado
group by iddepartamento;
go


/*
6. Consultar la vista desde Microsoft Excel.
*/

