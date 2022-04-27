-- sql examples
-- sql is case insensitive

-- basic sql query
select ContactName as Adı, CompanyName as SirketAdi, City as Sehir from Customers;

-- where
select * from Customers where City = 'Berlin';

-- or
select * from Products where categoryId = 1 or categoryId=3;

-- and
select * from Products where categoryId = 1 and UnitPrice>=10;

-- order by
select * from Products order by UnitPrice -- asc desc;
select * from Products where CategoryId=1 order by UnitPrice desc;

-- count
select count(*) from Products;

-- hangi kategoride kaç farklı ürün var? "distinct"
-- having kümülatif sonuçları, where ise datayı filtreler.
select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<5;

-- inner join
-- inner join eşleşmeyen verileri getirmez
select * from Products
inner join Categories on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10;

-- DTO, data transformation object

-- right, left join
select * from Products p left join [Order Details] od on p.ProductID=od.ProductID;
select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null;