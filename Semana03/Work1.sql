-- Funciones

select ISNULL(60,100) valor;
go

select ISNULL(null,100) valor;
go

declare @valor int;
set @valor = isnull(60,100);
print @valor;
go

declare @valor int;
set @valor = isnull(null,100);
print @valor;
go

-- BLOQUE ANÓNIMO

BEGIN 
	DECLARE @NUM1 INT, @NUM2 INT, @SUMA INT; 
	SET @NUM1 = CAST( RAND() * 100 AS INT ); 
	SET @NUM2 = CAST( RAND() * 100 AS INT ); 
	SET @SUMA = @NUM1 + @NUM2; 
	PRINT CONCAT( 'NUM1 = ', @NUM1 ); 
	PRINT CONCAT( 'NUM2 = ', @NUM2 ); 
	PRINT CONCAT( 'SUMA = ', @SUMA ); 
END; 
GO



