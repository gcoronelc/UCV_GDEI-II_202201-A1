

select * from Northwind..Categories;
select * from Northwind..Products;
go


select C.CategoryName, P.ProductName, P.UnitPrice, P.UnitsInStock
from Northwind..Categories C
join Northwind..Products P on C.CategoryID = P.CategoryID;
go





