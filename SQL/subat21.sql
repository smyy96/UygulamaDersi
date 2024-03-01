select HedefStokDuzeyi from Urunler order by HedefStokDuzeyi



select u.UrunAdi,k.KategoriAdi from Urunler as u
inner join Kategoriler as k on k.KategoriID=u.KategoriID
where k.KategoriAdi='Produce'





select u.UrunAdi, t.SirketAdi,k.KategoriAdi, t.Telefon 
from Tedarikciler as t
inner join  Urunler as u on t.TedarikciID=u.TedarikciID
inner join Kategoriler as k on k.KategoriID=u.KategoriID



declare @toplam int = 0

select distinct(t.SirketAdi)
from Tedarikciler as t
inner join  Urunler as u on t.TedarikciID=u.TedarikciID
inner join Kategoriler as k on k.KategoriID=u.KategoriID



select * from Personeller

select per.Adi, p.Adi from Personeller as p
inner join Personeller as per on p.BagliCalistigiKisi=per.PersonelID


select Adi from Personeller



select * from Personeller as p
inner join Personeller as per on p.BagliCalistigiKisi=per.PersonelID




select bol.TerritoryTanimi, bo.BolgeTanimi from Bolgeler as bol
inner join Bolge as bo on bo.BolgeID=bol.BolgeID


select * from Personeller



select u.UrunAdi, t.SirketAdi,k.KategoriAdi, t.Telefon 
from Tedarikciler as t
inner join  Urunler as u on t.TedarikciID=u.TedarikciID
inner join Kategoriler as k on k.KategoriID=u.KategoriID




select u.KategoriID, count(*) as urunSayisi from Urunler as u
inner join Kategoriler as k on k.KategoriID=u.KategoriID
group by u.KategoriID



select * from Personeller



select PersonelID, count(*) as satisAdet  from Satislar 
group by PersonelID


select per.Adi, count(*) as satisAdet  from Personeller as per
inner join Satislar as sat on sat.PersonelID=per.PersonelID
group by per.Adi




select per.Adi, count(*) as satisAdet  from Personeller as per
inner join Satislar as sat on sat.PersonelID=per.PersonelID
where per.PersonelID>5
group by per.Adi
having count(*) > 50



select k.KategoriAdi, count(*) as adet from Kategoriler as k
inner join Urunler as u on u.KategoriID=k.KategoriID
where k.KategoriID>5
group by k.KategoriAdi
having count(*)>10





