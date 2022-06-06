

CREATE FUNCTION dbo.fn_suma ( @num1 int, @num2 int ) 
RETURNS int 
AS 
BEGIN 
	DECLARE @suma int; 
	SET @suma = @num1 + @num2; 
	RETURN @suma; 
END; 
GO

select dbo.fn_suma(34,56) suma;
go

/*

SELECT    -> Seleccionas las columnas
FROM      -> Seleccionas las tablas y los JOIN
WHERE     -> Filtro de filas que se consultan directamente de la base de datos
GROUP BY  -> Resumenes en base a grupos de las filas recupradas
HAVING    -> Filtro a nivel de grupos creados por GROUP BY
ORDER BY  -> Ordenar el resultado

*/

SELECT idempleado, apellido, nombre, iddepartamento
FROM dbo.empleado 
WHERE iddepartamento = 103;
go

-- Función de tabla en línea

ALTER FUNCTION dbo.fn_empleados ( @p_dpto int ) 
RETURNS TABLE 
AS 
RETURN 
	SELECT idempleado, apellido, nombre, iddepartamento
	FROM dbo.empleado 
	WHERE iddepartamento = @p_dpto; 
GO


SELECT * FROM dbo.fn_empleados(103);
go

-- Función de tabla de multiples instrucciones

ALTER FUNCTION dbo.fn_catalogo ( ) 
RETURNS @tabla TABLE ( 
	codigo int identity(1,1) primary key not null, 
	nombre varchar(50) not null, 
	precio money not null 
) 
AS 
BEGIN 
	INSERT INTO @tabla(nombre,precio) values('Televisor', 1500.00); 
	INSERT INTO @tabla(nombre,precio) values('Refrigeradora', 1450.00); 
	INSERT INTO @tabla(nombre,precio) values('Lavadora', 1350.00); 
	RETURN; 
END; 
GO


SELECT * FROM dbo.fn_catalogo();
GO


