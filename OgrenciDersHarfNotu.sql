create database DersOgrenci
Go

use DersOgrenci
go


create table Ogrenciler
(
	OgrenciNo int unique not null,
	OgrenciAdi nvarchar(25) not null,
	OgrenciSoyadi nvarchar(25) not null,

	constraint Ck_OgrenciNo check (len(OgrenciNo)=7),
	constraint PK_OgrenciNo primary key (OgrenciNo)
)

go


create table Ogretmenler
(
	OgretmenID int primary key identity(100,1),
	OgretmenAdi nvarchar(25) not null,
	OgretmenSoyadi nvarchar(25) not null
)

go

--create table OgrenciOgretmen
--(
--	OgretmenID int foreign key references Ogretmenler(OgretmenID),
--	OgrenciNo int foreign key references Ogrenciler(OgrenciNo)
--)



create table Dersler
(
	DersNo int not null unique,
	DersAdi nvarchar(50) not null,
	OgretmenID int foreign key references Ogretmenler(OgretmenID),

	constraint PK_DersNo primary key (DersNo)
)
go

create table DersOgrenci
(
	DO_ID int primary key identity(1,1),
	OgrenciNo int foreign key references Ogrenciler(OgrenciNo),
	DersNo int foreign key references Dersler(DersNo)
)

go

create table HarfNotlar�
(
	HarfID tinyint primary key identity(1,1),
	HarfNotu char(2) not null,
)

go


create table Notlar
(
	DO_ID int foreign key references DersOgrenci(DO_ID),
	Vize tinyint default 0,
	Final tinyint default 0,
	HarfID tinyint default 9 foreign key references HarfNotlar�(HarfID),
)

go

INSERT INTO HarfNotlar� (HarfNotu) VALUES
	('AA'),
	('BA'),
	('BB'),
	('CB'),
	('CC'),
	('DC'),
	('DD'),
	('FD'),
	('FF');


go


INSERT INTO Ogretmenler (OgretmenAdi, OgretmenSoyadi)
VALUES 
('�zlem', 'U�ar'),
('Altan', 'Mesut'),
('Ayd�n', 'Carus'),
('Zeki', 'Durmu�'),
('Nebahat', 'Y�ld�z');
go


INSERT INTO Ogrenciler (OgrenciNo, OgrenciAdi, OgrenciSoyadi)
VALUES 
	(2001001, 'Ahmet', 'Solmaz'),
	(2001002, 'Selim', 'Solmaz'),
	(2001003, 'Ahmet', 'Vardar'),
	(2001004, 'Sezai', 'Kantar'),
	(2001005, 'Seyhan', 'G�lmez');

go





INSERT INTO Dersler (DersNo, DersAdi, OgretmenID)
VALUES 
	(202, 'Matematik 2', 100),
	(203, 'Fizik 2', 100),
	(204, 'Bilgisayar M�hendisli�ine Giri� 2', 102),
	(205, 'Atat�rk �lkeleri ve �nk�lap Tarihi 2', 103),
	(206, 'T�rk Dili 2', 104),
	(702, 'Veri Taban� Y�netimi', 101);

go


INSERT INTO DersOgrenci (DersNo, OgrenciNo)
VALUES 
	(202, 2001001),
	(203, 2001001),
	(204, 2001001),
	(205, 2001001),
	(206, 2001001),
	(202, 2001005),
	(203, 2001005),
	(204, 2001005),
	(702, 2001002),
	(702, 2001003),
	(702, 2001004);

go



INSERT INTO Notlar (DO_ID, Vize, Final, HarfID)
VALUES 
	(1, 70, 60, 3),
	(2, 80, 40, 3),
	(3, 60, 45, 1),
	(4, 90, 95, 2),
	(5, 70, 75, 3),
	(6, 80, 95, 1),
	(7, 80, 70, 2),
	(8, 60, 70, 1),
	(9, 60, 50, 3),
	(10, 60, 60, 2),
	(11, 65, 55, 3);
go


--��renci Ad�, Soyad� ve Ald��� Derslerin Adlar�:

select concat(o.OgrenciAdi,' ',o.OgrenciSoyadi) as AdSoyad, d.DersAdi 
from Ogrenciler as o
inner join DersOgrenci as do on
	o.OgrenciNo=do.OgrenciNo
inner join Dersler as d on
	d.DersNo=do.DersNo

go



-- ��rencilerin Vize ve Final Notlar�:

select concat(o.OgrenciAdi,' ',o.OgrenciSoyadi) as AdSoyad, n.Vize, n.Final from Ogrenciler as o
inner join DersOgrenci as do on
	do.OgrenciNo=o.OgrenciNo
inner join Notlar as n on
	n.DO_ID=do.DO_ID
go


-- Her ��rencinin Ald��� Derslerin Harf Notlar�

select concat(o.OgrenciAdi,' ',o.OgrenciSoyadi) as AdSoyad, d.DersAdi , hn.HarfNotu from Ogrenciler as o
inner join DersOgrenci as do on
	do.OgrenciNo=o.OgrenciNo
inner join Notlar as n on
	n.DO_ID=do.DO_ID
inner join HarfNotlar� as hn on
	hn.HarfID=n.HarfID
inner join Dersler as d on
	d.DersNo=do.DersNo

go

