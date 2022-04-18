CREATE FUNCTION dbo.fn_suma ( @num1 int, @num2 int ) 
RETURNS int 
AS 
BEGIN 
	DECLARE @suma int; 
	SET @suma = @num1 + @num2; 
	RETURN @suma; 
END; 
GO

select dbo.fn_suma( 24, 56 ) as suma;
go

declare @suma int;
set @suma = dbo.fn_suma(65,23);
print concat('Suma: ', @suma);
go


