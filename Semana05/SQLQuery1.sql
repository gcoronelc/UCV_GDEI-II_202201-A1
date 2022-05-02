/*

SELECT ...
FROM ...
WHERE ...
GROUP BY ...
HAVING ...
ORDER BY ....

*/



SELECT * 
FROM northwind..orders
go

SELECT shipCountry Pais, count(1) CantVentas 
FROM northwind..orders
WHERE year(OrderDate)=1997
GROUP BY shipCountry
HAVING count(1)<10
ORDER BY 1
go


