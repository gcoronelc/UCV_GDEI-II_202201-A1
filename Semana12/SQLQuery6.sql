
select * from moneda;
go

insert into dbo.moneda values('13','"ABC''s"');
select @@error [error]
go



select chr_sucucodigo, count(1) cuentas
from cuenta
where dec_cuensaldo>14000
group by chr_sucucodigo;
go

