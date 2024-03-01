
-- 1.Soru

create procedure SP_Cal�sanSehir
as
begin
	select e.FirstName, e.LastName, e.Title from Employees as e 
		where e.City is not null
end



exec SP_Cal�sanSehir





-- 2.Soru t�m kategori isimleriyle, bu kategorilere ait olan �r�nlerin adlar�n� listeleyen bir SP yaz�p kullan�n�z

create procedure SP_KategoriUrun
as
begin
	select p.ProductName, c.CategoryName from Categories as c
	inner join Products as p on p.CategoryID=c.CategoryID
end



exec SP_KategoriUrun






-- 3.Soru Kategori ID'sini parametre olarak alan ve kategorisi ID'si, bu ID'ye e�it olan �r�nlerin adlar�n� ve kategorilerini listeleyen SP yaz�p kullan�n�z.
create procedure SP_KategoriIDUrun
@kategoriID int
as
begin
	select p.ProductName, c.CategoryName from Categories as c
	inner join Products as p on p.CategoryID=c.CategoryID
	where c.CategoryID=@kategoriID
end



exec SP_KategoriIDUrun @kategoriID=1




-- 4.Soru  2 adet parametre alan bir SP yaz�n�z. Bir parametresi categoriId, di�eri ise productId olsun.Bu SP, KategoriId'si parametre olarak  
--g�nderilen kategoriId'ye e�it olan, productId'si de parametre olarak g�nderilen productId'den 
--b�y�k olan �r�nlerin �r�n id, �r�n ad ve kategori adlar�n� listelesin.Bu SP'yi kullan�n�z.


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



-- 5.Soru  View nedir? K�saca yaz�n�z.
-- yapt���m�z sorgular� tablo �eklinde kullanmak i�in view kullan�r�z. Sorgular�m�z� view olarak olu�turursak o sorguda olusan sonuclar� 
-- ba�ka sorgularda tablo olarak kullanabiliriz


-- 6.Soru  TerritoryDescription'�nda "san" ge�enlerin   TerritoryDescription, RegionDescription 'lar�n� listeleyen bir view olu�turup �a��r�n�z.
create view sunOlanlar
as
(
	select t.TerritoryDescription, r.RegionDescription from Region as r
	inner join Territories as t on r.RegionID=t.RegionID
	where t.TerritoryDescription like '%san%'
)


select * from sunOlanlar



-- 7.Soru  : Union ve UnionAll nedir? Aralar�ndaki fark nedir? Bir �rnekle g�steriniz. (SQL yaz�n�z)
-- birden fazla sorguyu tek tabloda birle�tir. colon say�s� ve t�rleri ayn� olmal�

(select e.FirstName, e.LastName, e.BirthDate from Employees as e)
union all
(select e.FirstName, e.LastName, e.BirthDate  from Employees as e
	where e.FirstName like 'A%'
)





-- h�zl� veri sorgulamak i�in 
-- 8.Soru Index nedir? K�saca a��klay�n�z.
--veri taban�nda cok b�y�k oldugu zaman arama ve sorgulama i�lemleri uzun zamanlar al�yor bunun i�in indexleme kullan�yoruz sorgulama i�elmelerimde verimi artt�r�yor.



-- 9. Candidate key

--Minimal bir s�per anahtard�r.
--Tekrarlanan veri i�ermeyen bir s�per anahtara aday anahtar ad� verilir.
--Bir kayd� benzersiz �ekilde tan�mlayabilen minimum nitelik k�mesi.
--Benzersiz de�erler i�ermelidir.
--NULL de�erler i�erebilir.
--Her tabloda en az tek bir aday anahtar� bulunmal�d�r.
--Bir tablonun birden fazla aday anahtar� olabilir ancak yaln�zca bir birincil anahtar� olabilir.
--Aday Anahtar�n�n de�eri benzersizdir ve bir tan�mlama grubu i�in bo� olabilir.
--Bir ili�kide birden fazla aday anahtar� olabilir. 

-- super key

--Aday anahtara s�f�r veya daha fazla �zellik eklemek s�per anahtar� olu�turur.
--Aday anahtar s�per anahtard�r ancak bunun tersi do�ru de�ildir.
--S�per Anahtar de�erleri NULL da olabilir.







-- 10.Soru  Parametre olarak 3 adet say� alan ve bunlar�n toplam�n� yazan SP yaz�n�z.
create procedure SP_SayiToplam
@sayi1 int,
@sayi2 int,
@sayi3 int
as
begin
	select (@sayi1+@sayi2+@sayi3) as Toplam
end

exec SP_SayiToplam 10,20,30



-- 11.Soru  Parametre olarak 3 adet say� alan ve bunlar�n ortalamas�n� yazan SP yaz�n�z.

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





-- 12.Soru  G�REV12: A�a��daki sorguyu yaz�p �al��t�r�n�z. Having ile where'in kullan�ld��� yerleri inceleyiniz. Birbirleri yerlerine yaz�labilir mi?
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



