select
	p.ProductName, sum(od.UnitPrice*od.Quantity)
from Products as p
inner join [Order Details] as od
	on p.ProductId = od.ProductId
group by p.ProductName;