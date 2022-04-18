USE RH; 
GO 

CREATE FUNCTION dbo.fn_empleados ( @p_dpto int ) 
RETURNS TABLE 
AS 
RETURN 
	SELECT idempleado, apellido, nombre 
	FROM dbo.empleado 
	WHERE iddepartamento = @p_dpto; 
GO 

SELECT * FROM dbo.fn_empleados(105); 
GO

CREATE procedure usp_empleados ( @p_dpto int ) 
AS 
BEGIN
	SELECT idempleado, apellido, nombre 
	FROM dbo.empleado 
	WHERE iddepartamento = @p_dpto; 
END;
GO 

EXEC usp_empleados 103;
GO

CREATE procedure usp_empleados2 ( @p_dpto int ) 
AS 
BEGIN
	SELECT * FROM dbo.fn_empleados(@p_dpto);
END;
GO

EXEC usp_empleados 105;
GO