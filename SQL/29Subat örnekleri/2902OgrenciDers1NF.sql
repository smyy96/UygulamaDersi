create database OgrenciDers2902
go 

use OgrenciDers2902
go



create table Bolumler
(
	BolumID int primary key identity,
	BolumAdi nvarchar(25) not null
)
go



create table Dersler
(
	DersID int primary key identity,
	DersAdi nvarchar(25) not null,
	BolumID int foreign key references Bolumler(BolumID)
)
go



create table Ogrenciler
(
	OgrenciID int identity primary key,
	OgrenciAdi nvarchar(25) not null,
	OgrenciSoyadi nvarchar(25) not null,
	OgrenciNo char(3) not null,
	BolumID int foreign key references Bolumler(BolumID) not null
)
go

create table OgrencilerDersler
(
	OD_ID int primary key identity,
	OgrenciID int foreign key references Ogrenciler(OgrenciID),
	DersID int foreign key references Dersler(DersID)

)
go


create table SinavTipi
(
	SinavTipiID int primary key identity,
	SinavTipi nvarchar(15) not null
)
go





create table OgrenciDersNotlari
(
	ODN_ID int primary key identity,
	OD_ID int foreign key references OgrencilerDersler(OD_ID),
	SinavTipiID int foreign key references SinavTipi(SinavTipiID),
	SinavNotu decimal(5,2) not null
)

go



insert into Bolumler values
	('Bilgisayar Mühendisliði'),
	('Matematik'),
	('Fizik')




INSERT INTO Dersler (DersAdi, BolumID) VALUES
		('Algoritma', 1),
		('Veritabaný', 1),
		('Dif. Denk', 2),
		('Lineer Cebir', 2),
		('Topoloji', 2),
		('Sayýlar Teoremi', 2),
		('Web Tasarým', 1),
		('C#', 1),
		('EMD', 3),
		('Fizik 1', 3);
go


INSERT INTO Ogrenciler VALUES
		('Ali', 'Veli', '123', 1),
		('Ayþe', 'Fatma', '456', 2),
		('Hasan', 'Hüseyin', '789', 1),
		('Mustafa', 'Mehmet', '159', 3);
go


INSERT INTO OgrencilerDersler VALUES
		(1, 1),
		(1, 2),
		(2, 3),
		(2, 4),
		(2, 5),
		(2, 6),
		(3, 7),
		(3, 8),
		(3, 2),
		(4, 9),
		(4, 10);
go



INSERT INTO SinavTipi VALUES
		('Vize'),
		('Final');
go




INSERT INTO OgrenciDersNotlari VALUES
		(1, 1, 50),
		(1, 2, 75),
		(2, 1, 27),
		(2, 2, 83),
		(3, 1, 74),
		(3, 2, 67),
		(4, 1, 61),
		(4, 2, 39),
		(5, 1, 79),
		(5, 2, 55),
		(6, 1, 99),
		(6, 2, 76),
		(7, 1, 87),
		(7, 2, 34),
		(8, 1, 28),
		(8, 2, 7),
		(9, 1, 43),
		(9, 2, 3),
		(10, 1, 84),
		(10, 2, 45),
		(11, 1, 67),
		(11, 2, 52);
go


--------1NF ------------------
select o.OgrenciAdi,o.OgrenciSoyadi,b.BolumAdi,o.OgrenciNo,d.DersAdi, st.SinavTipi,
	odn.SinavNotu

from Bolumler b 
inner join Dersler d on d.BolumID=b.BolumID
inner join Ogrenciler o on b.BolumID=o.BolumID
inner join OgrencilerDersler od on d.DersID=od.DersID and od.OgrenciID=o.OgrenciID
inner join OgrenciDersNotlari odn on odn.OD_ID=od.OD_ID
inner join SinavTipi st on st.SinavTipiID=odn.SinavTipiID
group by o.OgrenciAdi,o.OgrenciSoyadi,b.BolumAdi,o.OgrenciNo,d.DersAdi,st.SinavTipi, odn.SinavNotu











--------UDF-------
select o.OgrenciAdi,o.OgrenciSoyadi,b.BolumAdi,o.OgrenciNo,d.DersAdi,
	string_agg(cast(odn.SinavNotu as int), ', ')as "Vize,Final"

from Bolumler b 
inner join Dersler d on d.BolumID=b.BolumID
inner join Ogrenciler o on b.BolumID=o.BolumID
inner join OgrencilerDersler od on d.DersID=od.DersID and od.OgrenciID=o.OgrenciID
inner join OgrenciDersNotlari odn on odn.OD_ID=od.OD_ID
inner join SinavTipi st on st.SinavTipiID=odn.SinavTipiID
group by o.OgrenciAdi,o.OgrenciSoyadi,b.BolumAdi,o.OgrenciNo,d.DersAdi



