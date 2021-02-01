select * from Products where CategoryID=1 order by UnitPrice desc --eger order bydan sonra boş bırakılırsa varsayılan olan asc olur ve artan şekilde sıralanır desc olursa azalan şekilde sıralanır

select count(*) Adet from Products -- ürünler tablosundaki satır sayısını adet stünu olarak verir

select CategoryID, count(*) from Products group by CategoryID --her kategoride kaç tane ürün var bilgisini verir

select CategoryID, count(*) from Products group by CategoryID having count(*)<10 --içerik sayısı 10 dan az olan kategorileri ve içinde kaçtane içerik bulundugunu verecek

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID -- sadece iki tablodada eşleşen verileri getirir

select * from Products p left join [Order Details] od on p.CategoryID = od.ProductID 
--isimlerde boşluk kullanılırsa köşeli parantez içine alınmalıdır -- products=p order details =od olarak kısaltıldı -- soldaki tabloda olup sagdaki tabloda olmayanlarıda getirir

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null -- null lar boş demektir kullanılırken önüne is konur -- hiç siparişi bulunmayan kullanıcıları getirir