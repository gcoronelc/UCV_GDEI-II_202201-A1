/*
Desarrolle una función que reporte de la cantidad de alumnos matriculados 
y las vacantes disponibles de un determinado curso. 
Base de datos EDUTEC.
*/

/*
1. Analizar del requerimiento.

Los cursos se programan por ciclo, en cada ciclo se pueden programar
varios curso, y un mismo curso se puede programar varias veces 
en un mismo ciclo, incluso con diferentes profesores.

Se asumira que el reporte es para el administrador, y necesita
saber los cursos programados en un determinado ciclo.

*/

select * from edutec..CursoProgramado
where IdCiclo = '2021-01'
order by IdCurso;
go


/*
2. Identificar los datos que debe retornar la función.
3. Identificar las tablas de donde obtendrá los datos.
4. Crear la función en la base de datos.
5. Verificar su resultado.
*/

alter function v_ejercicio3 (@ciclo char(7), @curso char(4))
RETURNS TABLE 
AS RETURN
select cp.IdCursoProg, cp.IdCurso, c.NomCurso, cp.Matriculados, cp.Vacantes
from CursoProgramado cp
join curso c on cp.IdCurso = c.IdCurso
where cp.idciclo=@ciclo and cp.IdCurso=@curso;
go

select * from dbo.v_ejercicio3('2021-01','C004');
go

