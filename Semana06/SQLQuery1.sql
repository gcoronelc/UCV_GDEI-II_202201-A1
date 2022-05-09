

select * from northwind..customers
go


select * into clientes
from northwind..customers
go

select * from clientes
where ContactName='Aria Cruz'
go

CREATE CLUSTERED INDEX clientes_idx_1
ON clientes(contactname)
go



