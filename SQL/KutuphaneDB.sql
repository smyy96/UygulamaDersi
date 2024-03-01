create database KutuphaneDB
go 

use KutuphaneDB


create table Yazarlar
(
	YazarID int primary key identity,
	YazarAdi nvarchar(50) not null,
	YazarSoyadi nvarchar(50) not null,
)
go



create table Kitaplar
(
	KitapID int primary key identity,
	KitapAdi nvarchar(55) not null,
	YayinYýlý char(4) not null,
	YazarID int not null foreign key references Yazarlar(YazarID)
)
go


create table Kategori
(
	KategoriID int primary key identity,
	KategoriAdi nvarchar(25)
)
go



create table KitapKategori
(
	KitapID int foreign key references Kitaplar(KitapID),
	KategoriID int foreign key references Kategori(KategoriID)

)
go
