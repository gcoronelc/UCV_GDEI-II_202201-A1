/*

Se necesita saber el alumno con mas matriculas por curso, en el año 2021.
Se debe mostrar los empates
El modelo del resultado es el siguiente:

Nombre del curso   Nombre del alumno   Cantidad Matriculas
----------------------------------------------------------------------

*/

/*
1. Analizar cada requerimiento.

Cada alumno puede matricularse en un mismo cursos las veces
que quiera, en diferentes horarios y/o ciclos.

De esta manera podemos encontrar que un alumnos ha estudiado
el curso SQL Server Programación en 5 oportunidades en un años,
pero con diferentes profesores.
*/


/*
2. Identificar los datos que debe tener el reporte.

Nombre del curso   Nombre del alumno   Cantidad Matriculas
----------------------------------------------------------------------
*/

/*
3. Identificar las tablas de donde obtendrá los datos.

- Nombre del curso: CURSO
- Nombre del alumno: ALUMNO
- Cantidad Matriculas: MATRICULA
*/

/*
4. Crear la vista en la base de datos.
*/

-- Paso 1: Los datos base

select cp.IdCurso, m.IdAlumno, m.FecMatricula
from dbo.CursoProgramado cp
join dbo.Matricula m on cp.IdCursoProg=m.IdCursoProg
where cp.IdCiclo like '2021%';
go


-- Paso 2: Cantidad de matriculas por alumno en cada curso

with
v1 as (
	select cp.IdCurso, m.IdAlumno, m.FecMatricula
	from dbo.CursoProgramado cp
	join dbo.Matricula m on cp.IdCursoProg=m.IdCursoProg
	where cp.IdCiclo like '2021%'
)
select IdCurso, IdAlumno, count(FecMatricula) matriculas
from v1
group by IdCurso, IdAlumno;
go


-- Paso 3: Numero maximo de matriculas de un alumno por curso

with
v1 as (
	select cp.IdCurso, m.IdAlumno, m.FecMatricula
	from dbo.CursoProgramado cp
	join dbo.Matricula m on cp.IdCursoProg=m.IdCursoProg
	where cp.IdCiclo like '2021%'
),
v2 as (
	select IdCurso, IdAlumno, count(FecMatricula) matriculas
	from v1
	group by IdCurso, IdAlumno
)
select IdCurso, max(matriculas) mayor_matriculas
from v2 
group by IdCurso;
go

-- Paso 4: Quienes son los alumnos con mayor matriculas

with
v1 as (
	select cp.IdCurso, m.IdAlumno, m.FecMatricula
	from dbo.CursoProgramado cp
	join dbo.Matricula m on cp.IdCursoProg=m.IdCursoProg
	where cp.IdCiclo like '2021%'
),
v2 as (
	select IdCurso, IdAlumno, count(FecMatricula) matriculas
	from v1
	group by IdCurso, IdAlumno
),
v3 as (
	select IdCurso, max(matriculas) mayor_matriculas
	from v2 
	group by IdCurso
)
select v2.* 
from v2 join v3
on v2.IdCurso=v3.IdCurso and v2.matriculas=v3.mayor_matriculas;
go

-- Paso 5: Completar datos

create view v_demo
as
with
v1 as (
	select cp.IdCurso, m.IdAlumno, m.FecMatricula
	from dbo.CursoProgramado cp
	join dbo.Matricula m on cp.IdCursoProg=m.IdCursoProg
	where cp.IdCiclo like '2021%'
),
v2 as (
	select IdCurso, IdAlumno, count(FecMatricula) matriculas
	from v1
	group by IdCurso, IdAlumno
),
v3 as (
	select IdCurso, max(matriculas) mayor_matriculas
	from v2 
	group by IdCurso
),
v4 as (
	select v2.* 
	from v2 join v3
	on v2.IdCurso=v3.IdCurso and v2.matriculas=v3.mayor_matriculas
)
select c.IdCurso, a.NomAlumno, a.ApeAlumno, v4.matriculas
from v4 
join curso c on v4.IdCurso = c.IdCurso
join Alumno a on v4.IdAlumno = a.IdAlumno;
go


/*
5. Verificar su resultado.
*/

select * from v_demo order by 1;

with
v1 as (
	select cp.IdCurso, m.IdAlumno, m.FecMatricula
	from dbo.CursoProgramado cp
	join dbo.Matricula m on cp.IdCursoProg=m.IdCursoProg
	where cp.IdCiclo like '2021%'
)
select IdCurso, IdAlumno, count(FecMatricula) matriculas
from v1
group by IdCurso, IdAlumno
order by 1, 3 desc;
go


/*

6. Consultar la vista desde Microsoft Excel
*/


-- Otra alternativa

WITH v1 AS (	SELECT ShipCity, ProductID, RANK() OVER(PARTITION BY ShipCity ORDER BY Quantity DESC) AS Ranking FROM [Order Details] od	JOIN Orders O ON od.OrderID = O.OrderID )SELECT * FROM v1 WHERE Ranking=1;
go


