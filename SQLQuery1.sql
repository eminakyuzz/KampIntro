select CompanyName SirketAdi,ContactName Adi,City Sehir from Customers

select* from Customers where City='London'

select* from products where CategoryID=1 or CategoryID=3

select* from products where CategoryID=1 and UnitPrice>10

select * from Products order by ProductName

select * from Products order by CategoryID,ProductName

select * from Products order by UnitPrice

select * from Products order by UnitPrice desc

select * from Products where CategoryID=1 order by UnitPrice desc

select COUNT(*) from Products

select count (*) iki_numaralı_Adedi from Products where CategoryID=2

select categoryId,count(*) from Products group by CategoryID

select count(*) from Products group by CategoryID 

select categoryId,count(*) from Products group by CategoryID having count(*)<10

select * from Products inner join Categories on Products.CategoryID=Categories.CategoryID

select ProductName,Categories.CategoryName from 
Products inner join Categories on Products.CategoryID=Categories.CategoryID

select Categories.CategoryName ,Products.ProductID,Products.ProductName,Products.UnitPrice
from Products inner join Categories on Products.CategoryID=Categories.CategoryID

select Categories.CategoryName ,Products.ProductID,Products.ProductName,Products.UnitPrice
from Products inner join Categories on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice<100 order by Products.UnitPrice desc

select * from Products p left join [Order Details] od on p.ProductID=od.ProductID

select* from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

select p.ProductName,sum(od.Quantity*od.UnitPrice) as Total_Income from [Order Details] od
inner join Products p ON od.ProductID=p.ProductID
inner Join Orders ON od.OrderID=Orders.OrderID
group by p.ProductName










