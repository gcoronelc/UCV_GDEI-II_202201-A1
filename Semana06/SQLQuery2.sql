
insert into clientes
select * from Customers
go


select * from clientes
where CompanyName='Que Del�cia'
go


CREATE INDEX clientes_idx_2
ON clientes(companyname)
go

select * from clientes
where CompanyName='Que Del�cia'
go







