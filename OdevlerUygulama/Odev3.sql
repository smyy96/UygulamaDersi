-- 1. AyHesapla ad�nda, ald��� DATETIME cinsinden de�erin �zerinden ka� ay ge�ti�ini hesaplayan
--ve bu de�eri geri d�nd�ren bir fonksiyon olu�turunuz. Ard�ndan, Employees tablosundaki her
--bir �al��an i�in i�e ba�lama tarihinden bu yana ka� ay ge�ti�ini, bu fonksiyonu kullanarak
--listeleyiniz.


create function AyHesapla ( @GelenTarih datetime)
returns int 
as
begin
	return datediff(MONTH,@GelenTarih,getdate())
end



select dbo.AyHesapla(e.HireDate) as "�al���lan ay say�s�" from Employees as e



-- 2. �ki tarih aras�ndaki fark� alan ve bu fark� g�n olarak d�nd�ren bir fonksiyon yaz�n�z. Daha
--sonra orders tablosundaki her sat�r i�in OrderDate ile ShippedDate aras�ndaki g�n say�s�n�, bu
--fonksiyonu kullanarak listeleyiniz.
create function SiparisSuresi (@OrderDate datetime, @ShippedDate datetime)
Returns int
as
begin
	return datediff(Day,@OrderDate,@ShippedDate)
end


select dbo.SiparisSuresi(o.OrderDate,o.ShippedDate)as kargolamaSuresi from Orders as o




-- 3.Employees tablosundan firstname�leri, d��ar�dan g�nderilen harf ile ba�layanlar� tablo olarak
--d�nd�ren fonksiyon yaz�n�z. Ard�ndan bu fonksiyonu kullanarak A ile ba�layanlar� listeleyiniz.

create function GetByChar(@GetChar char)
returns table
as
return(
	select * from Employees as e
	where e.FirstName like @GetChar+'%'
	)

select * from GetByChar('A')




-- 4.Order details tablosundaki unitprice�lar�n k�rp�lm�� ortalamas�n� hesaplayan stored procedure
--yaz�n�z. (K�rp�lm�� ortalama: En k���k ve en b�y�k de�erler dahil edilmeden hesaplanan
--aritmetik ortalamad�r.


create proc Ortalama
as
	select AVG(UnitPrice) as "Ortalama UnitPrice"
	from [Order Details]
	where UnitPrice not in (
		select max(UnitPrice) from [Order Details]
		union
		select min(UnitPrice) from [Order Details] )



Ortalama;



















--select avg(UnitPrice) from [Order Details]
--	where UnitPrice not in 
--		(
--			(select top 1 UnitPrice from [Order Details]
--			 order by UnitPrice)
--			 union
--			 (select top 1 UnitPrice from [Order Details]
--			 order by UnitPrice desc)
--		 )






