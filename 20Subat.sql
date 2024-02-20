create database Sinema

create table Filmler
(
	FilmID int primary key identity(1,1),
	FilmAd nvarchar(100) not null

)


create table Kategori
(
	KategoriID int primary key identity (1,1),
	KategoriAdý nvarchar(25) not null
)


create table FilmKategoriCross --filmtur
(
	FilmID int foreign key references Filmler(FilmID),
	KategoriID int foreign key references Kategori(KategoriID),
	
)


create table Yonetmenler
(
	YonetmenID int primary key identity (1,1),
	YonetmenAdi nvarchar(25) not null,
)



create table FilmYonetmenlerYonetme --yonetme
(
	FilmID int foreign key references Filmler(FilmID),
	YonetmenID int foreign key references Yonetmenler(YonetmenID),
)



create table Oyuncular
(
	OyuncuID int primary key identity (1,1),
	OyuncuAdi nvarchar(25) not null,
)


create table FilmOyuncularOynama --oynama
(
	FilmID int foreign key references Filmler(FilmID),
	OyuncuID int foreign key references Oyuncular(OyuncuID),
)


create table Kullanici
(
	KullaniciID int primary key identity (1,1),
	KullaniciAdi nvarchar(25) not null,
	
)


create table FilmKullaniciFavori --favoriler
(
	FilmID int foreign key references Filmler(FilmID),
	KullaniciID int foreign key references Kullanici(KullaniciID),

)

create table FilmKullaniciYorum --favoriler
(
	FilmID int foreign key references Filmler(FilmID),
	KullaniciID int foreign key references Kullanici(KullaniciID),
	Yorum nvarchar(250) not null
)



