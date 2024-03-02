-- 1. AyHesapla adýnda, aldýðý DATETIME cinsinden deðerin üzerinden kaç ay geçtiðini hesaplayan
--ve bu deðeri geri döndüren bir fonksiyon oluþturunuz. Ardýndan, Employees tablosundaki her
--bir çalýþan için iþe baþlama tarihinden bu yana kaç ay geçtiðini, bu fonksiyonu kullanarak
--listeleyiniz.


create function AyHesapla ( @GelenTarih datetime)
returns int 
as
begin
	return datediff(MONTH,@GelenTarih,getdate())
end



select dbo.AyHesapla(e.HireDate) as "Çalýþýlan ay sayýsý" from Employees as e



-- 2. Ýki tarih arasýndaki farký alan ve bu farký gün olarak döndüren bir fonksiyon yazýnýz. Daha
--sonra orders tablosundaki her satýr için OrderDate ile ShippedDate arasýndaki gün sayýsýný, bu
--fonksiyonu kullanarak listeleyiniz.
create function SiparisSuresi (@OrderDate datetime, @ShippedDate datetime)
Returns int
as
begin
	return datediff(Day,@OrderDate,@ShippedDate)
end


select dbo.SiparisSuresi(o.OrderDate,o.ShippedDate)as kargolamaSuresi from Orders as o




-- 3.Employees tablosundan firstname’leri, dýþarýdan gönderilen harf ile baþlayanlarý tablo olarak
--döndüren fonksiyon yazýnýz. Ardýndan bu fonksiyonu kullanarak A ile baþlayanlarý listeleyiniz.

create function GetByChar(@GetChar char)
returns table
as
return(
	select * from Employees as e
	where e.FirstName like @GetChar+'%'
	)

select * from GetByChar('A')




-- 4.Order details tablosundaki unitprice’larýn kýrpýlmýþ ortalamasýný hesaplayan stored procedure
--yazýnýz. (Kýrpýlmýþ ortalama: En küçük ve en büyük deðerler dahil edilmeden hesaplanan
--aritmetik ortalamadýr.


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






