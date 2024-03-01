
-- 1.Soru

create procedure SP_CalýsanSehir
as
begin
	select e.FirstName, e.LastName, e.Title from Employees as e 
		where e.City is not null
end



exec SP_CalýsanSehir





-- 2.Soru tüm kategori isimleriyle, bu kategorilere ait olan ürünlerin adlarýný listeleyen bir SP yazýp kullanýnýz

create procedure SP_KategoriUrun
as
begin
	select p.ProductName, c.CategoryName from Categories as c
	inner join Products as p on p.CategoryID=c.CategoryID
end



exec SP_KategoriUrun






-- 3.Soru Kategori ID'sini parametre olarak alan ve kategorisi ID'si, bu ID'ye eþit olan ürünlerin adlarýný ve kategorilerini listeleyen SP yazýp kullanýnýz.
create procedure SP_KategoriIDUrun
@kategoriID int
as
begin
	select p.ProductName, c.CategoryName from Categories as c
	inner join Products as p on p.CategoryID=c.CategoryID
	where c.CategoryID=@kategoriID
end



exec SP_KategoriIDUrun @kategoriID=1




-- 4.Soru  2 adet parametre alan bir SP yazýnýz. Bir parametresi categoriId, diðeri ise productId olsun.Bu SP, KategoriId'si parametre olarak  
--gönderilen kategoriId'ye eþit olan, productId'si de parametre olarak gönderilen productId'den 
--büyük olan ürünlerin ürün id, ürün ad ve kategori adlarýný listelesin.Bu SP'yi kullanýnýz.


create procedure SP_KategoriIDUrunID
@kategoriID int,
@UrunID int
as
begin
	select p.ProductName, c.CategoryName from Categories as c
	inner join Products as p on p.CategoryID=c.CategoryID
	where c.CategoryID=@kategoriID and p.ProductID>@UrunID
end


exec SP_KategoriIDUrunID  @kategoriID=4,@UrunID=5



-- 5.Soru  View nedir? Kýsaca yazýnýz.
-- yaptýðýmýz sorgularý tablo þeklinde kullanmak için view kullanýrýz. Sorgularýmýzý view olarak oluþturursak o sorguda olusan sonuclarý 
-- baþka sorgularda tablo olarak kullanabiliriz


-- 6.Soru  TerritoryDescription'ýnda "san" geçenlerin   TerritoryDescription, RegionDescription 'larýný listeleyen bir view oluþturup çaðýrýnýz.
create view sunOlanlar
as
(
	select t.TerritoryDescription, r.RegionDescription from Region as r
	inner join Territories as t on r.RegionID=t.RegionID
	where t.TerritoryDescription like '%san%'
)


select * from sunOlanlar



-- 7.Soru  : Union ve UnionAll nedir? Aralarýndaki fark nedir? Bir örnekle gösteriniz. (SQL yazýnýz)
-- birden fazla sorguyu tek tabloda birleþtir. colon sayýsý ve türleri ayný olmalý

(select e.FirstName, e.LastName, e.BirthDate from Employees as e)
union all
(select e.FirstName, e.LastName, e.BirthDate  from Employees as e
	where e.FirstName like 'A%'
)





-- hýzlý veri sorgulamak için 
-- 8.Soru Index nedir? Kýsaca açýklayýnýz.
--veri tabanýnda cok büyük oldugu zaman arama ve sorgulama iþlemleri uzun zamanlar alýyor bunun için indexleme kullanýyoruz sorgulama iþelmelerimde verimi arttýrýyor.



-- 9. Candidate key

--Minimal bir süper anahtardýr.
--Tekrarlanan veri içermeyen bir süper anahtara aday anahtar adý verilir.
--Bir kaydý benzersiz þekilde tanýmlayabilen minimum nitelik kümesi.
--Benzersiz deðerler içermelidir.
--NULL deðerler içerebilir.
--Her tabloda en az tek bir aday anahtarý bulunmalýdýr.
--Bir tablonun birden fazla aday anahtarý olabilir ancak yalnýzca bir birincil anahtarý olabilir.
--Aday Anahtarýnýn deðeri benzersizdir ve bir tanýmlama grubu için boþ olabilir.
--Bir iliþkide birden fazla aday anahtarý olabilir. 

-- super key

--Aday anahtara sýfýr veya daha fazla özellik eklemek süper anahtarý oluþturur.
--Aday anahtar süper anahtardýr ancak bunun tersi doðru deðildir.
--Süper Anahtar deðerleri NULL da olabilir.







-- 10.Soru  Parametre olarak 3 adet sayý alan ve bunlarýn toplamýný yazan SP yazýnýz.
create procedure SP_SayiToplam
@sayi1 int,
@sayi2 int,
@sayi3 int
as
begin
	select (@sayi1+@sayi2+@sayi3) as Toplam
end

exec SP_SayiToplam 10,20,30



-- 11.Soru  Parametre olarak 3 adet sayý alan ve bunlarýn ortalamasýný yazan SP yazýnýz.

create procedure SP_SayiToplamOrtalama
@sayi1 int,
@sayi2 int,
@sayi3 int
as
begin
	declare @toplam int
	set @toplam=(@sayi1+@sayi2+@sayi3)/3
	select @toplam as ortalama
end

exec SP_SayiToplamOrtalama 10,20,360





-- 12.Soru  GÖREV12: Aþaðýdaki sorguyu yazýp çalýþtýrýnýz. Having ile where'in kullanýldýðý yerleri inceleyiniz. Birbirleri yerlerine yazýlabilir mi?
select OrderId, Sum(UnitPrice * Quantity*(1-Discount)) as ToplamTutar
from [Order Details]
where OrderID between 10500 and 11000
group by OrderId
having Sum(UnitPrice * Quantity*(1-Discount)) between 2500 and 3500
order by 2 desc




select OrderId, Sum(UnitPrice * Quantity*(1-Discount)) as ToplamTutar
from [Order Details]
--where OrderID between 10500 and 11000
group by OrderId
having Sum(UnitPrice * Quantity*(1-Discount)) between 2500 and 3500 and(OrderID between 10500 and 11000)
order by 2 desc



