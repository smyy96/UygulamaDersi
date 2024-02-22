

select p.Adi, s.SevkAdi,s.SevkAdresi from Satislar as s
inner join Personeller as p on s.PersonelID = p.PersonelID
where s.PersonelID=1 and len(s.SevkAdresi)>20

select * from Personeller




select s.SatisID,  p.Adi, power(sqrt((sd.BirimFiyati*Miktar)-(sd.BirimFiyati*Miktar*sd.Ýndirim)),3) as sonuc from Satislar as s
inner join Personeller as p on s.PersonelID = p.PersonelID
inner join [Satis Detaylari] as sd on sd.SatisID=s.SatisID
where s.PersonelID=1
group by s.SatisID



select k.KategoriID , count(*) as adet from Kategoriler as k
inner join Urunler as u on k.KategoriID=u.KategoriID
group by k.KategoriID




select k.KategoriAdi , count(*) as adet from Kategoriler as k
inner join Urunler as u on k.KategoriID=u.KategoriID
group by k.KategoriAdi





select u.UrunAdi from Tedarikciler as t
inner join Urunler as u on u.TedarikciID=t.TedarikciID
where t.Faks is not null




select u.UrunAdi from Tedarikciler as t
inner join Urunler as u on u.TedarikciID=t.TedarikciID
where t.Faks is null


select m.MusteriAdi from Satislar as s
inner join Musteriler as m on s.MusteriID= m.MusteriID
inner join Personeller as p on p.PersonelID=s.PersonelID
where p.Adi='Nancy' and year(s.SatisTarihi) > 1997






select sum(u.HedefStokDuzeyi*BirimFiyati) from Urunler as u
inner join Kategoriler as k on k.KategoriID= u.KategoriID
inner join Tedarikciler as t on t.TedarikciID=u.TedarikciID
where k.KategoriAdi='seafood' and t.SirketAdi like '%Ltd%'








select CONCAT(p.Adi,' ',p.SoyAdi)as "ad soyad", count(*) as adet from Personeller as p
inner join Satislar as s on s.PersonelID = p.PersonelID
where p.Adi like 'm%'
group by CONCAT(p.Adi,' ',p.SoyAdi)
having count(*)>100




select CONCAT(p.Adi,' ',p.SoyAdi)as "ad soyad", count(*) as adet from Personeller as p
inner join Satislar as s on s.PersonelID = p.PersonelID
where p.Adi like 'm%'
group by CONCAT(p.Adi,' ',p.SoyAdi)
having count(*)>100


select top 1 CONCAT(p.Adi,' ',p.SoyAdi), count(*) as adet from Personeller as p
inner join Satislar as s on s.PersonelID = p.PersonelID
group by CONCAT(p.Adi,' ',p.SoyAdi)
order by count(*) desc


