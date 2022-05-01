

select * from Orders;
select * from [Order Details];
select * from Products;
go



ALTER TRIGGER tr_alumno_01
ON alumno
FOR INSERT, UPDATE
AS
BEGIN
	PRINT 'MENSAJE DESDE EL TRIGGER';
	PRINT 'Operación ejecutada correctamente';
END;
GO

select * from alumno;
go

insert into alumno values(1002, 'Juan Perez', 'Lima', '967345856', 'jperez@gmail.com');
go

