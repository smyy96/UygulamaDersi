CREATE DATABASE RestoranDB
GO

USE RestoranDB
GO

--Tablolarý Oluþturma

CREATE TABLE Calisanlar
(
	CalisanID INT PRIMARY KEY IDENTITY,
	Adi NVARCHAR(25) NOT NULL,
	Soyadi NVARCHAR(25) NOT NULL,
	DogumTarihi DATE NOT NULL,
	Gorevi NVARCHAR(50) NOT NULL,
	OlusturmaZamani DATE NOT NULL,
	DuzenlemeZamani DATE NULL,
	Versiyon INT NOT NULL,

	Durumu BIT NOT NULL
)
GO

CREATE TABLE Gorevler
(
	GorevlerID INT PRIMARY KEY IDENTITY,
	Adi NVARCHAR(25) NOT NULL,
	Aciklama NVARCHAR(100) NULL,
	OlusturmaZamani DATE NOT NULL,
	DuzenlemeZamani DATE NULL,
	Versiyon INT NOT NULL,
	Durumu BIT NOT NULL
)
GO

CREATE TABLE Urunler
(
	UrunlerID INT PRIMARY KEY IDENTITY,
	Adi NVARCHAR(25) NOT NULL,
	KategoriAdi NVARCHAR(25) NOT NULL,
	Aciklama NVARCHAR(100) NULL,
	Miktar DECIMAL(6,2) NOT NULL, --( Örnek = 5.75 | 10 )
	MiktarTipi NVARCHAR(10) NOT NULL, --( Örnek = Kilo | Kutu )
	OlusturmaZamani DATE NOT NULL,
	DuzenlemeZamani DATE NULL,
	Versiyon INT NOT NULL,
	Durumu BIT NOT NULL
)
GO

CREATE TABLE Menu
(
	MenuID INT PRIMARY KEY IDENTITY,
	Adi NVARCHAR(25) NOT NULL,
	KategoriAdi NVARCHAR(25) NOT NULL,
	Aciklama NVARCHAR(100) NULL,
	Kalori INT NOT NULL,
	ServisSuresi INT NOT NULL,
	Fiyat DECIMAL(6,2) NOT NULL,
	OlusturmaZamani DATE NOT NULL,
	DuzenlemeZamani DATE NULL,
	Versiyon INT NOT NULL,
	Durumu BIT NOT NULL
)
GO

CREATE TABLE MenuRecete
(
	MenuReceteID INT PRIMARY KEY IDENTITY,
	Adi NVARCHAR(25) NOT NULL,
	UrunAdi NVARCHAR(25) NOT NULL,
	Miktar DECIMAL(6,2) NOT NULL,
	MiktarTipi NVARCHAR(10) NOT NULL,	
	OlusturmaZamani DATE NOT NULL,
	DuzenlemeZamani DATE NULL,
	Versiyon INT NOT NULL,
	Durumu BIT NOT NULL
)
GO


--Tablolara veri ekleme

INSERT INTO Calisanlar (Adi, Soyadi, DogumTarihi, Gorevi, OlusturmaZamani, Versiyon, Durumu)
VALUES
  ('Sumeyye', 'Coskun', '1990-05-15', 'Garson', GETDATE(),  1, 1),
  ('Burhan', 'Altýntop', '1985-02-20', 'Aþçý', GETDATE(), 1, 1),
  ('Makbule', 'Kral', '1995-08-10', 'Kasiyer', GETDATE(), 1, 1),
  ('Aslý', 'Sütçüoðlu', '1992-11-25', 'Mutfak Þefi', GETDATE(), 1, 1),
  ('Þahika', 'Koçarslanlý', '1988-07-03', 'Temizlik Görevlisi', GETDATE(), 1, 1)
GO


INSERT INTO Gorevler (Adi, Aciklama, OlusturmaZamani, Versiyon, Durumu)
VALUES
  ('Garson', 'Servis yapma', GETDATE(), 1, 1),
  ('Aþçý', 'Yemek piþirme', GETDATE(), 1, 1),
  ('Kasiyer', 'Hesap iþlemleriyle ilgilenme', GETDATE(), 1, 1),
  ('Mutfak Þefi', 'Mutfak iþlerini yönetme', GETDATE(), 1, 1),
  ('Temizlik Görevlisi', 'Temizlik iþlerini yapma', GETDATE(), 1, 1)
GO


INSERT INTO Urunler VALUES ('Su', 'Ýçecek', '500 ml', 2, 'Adet', GETDATE(), NULL, 1, 1)
INSERT INTO Urunler VALUES ('Kýrmýzý Et', 'Et', '1 kg', 25.75, 'Kilo', GETDATE(), NULL, 1, 1)
INSERT INTO Urunler VALUES ('Makarna', 'Makarna', '500 gr', 10, 'Kilo', GETDATE(), NULL, 1, 1)
INSERT INTO Urunler VALUES ('Marul', 'Sebze', 'Yeþillik', 1, 'Adet', GETDATE(), NULL, 1, 1)
INSERT INTO Urunler VALUES ('Kola', 'Ýçecek', '330 ml', 3, 'Adet', GETDATE(), NULL, 1, 1)
GO


INSERT INTO Menu VALUES ('Ýskender', 'Ana Yemek', 'Bol soslu iskender', 750, 20, 350, GETDATE(), NULL, 1, 1)
INSERT INTO Menu VALUES ('Pesto Soslu Makarna', 'Ana Yemek', 'Et soslu makarna', 600, 25, 223, GETDATE(), NULL, 1, 1)
INSERT INTO Menu VALUES ('Mevsim Salata', 'Salata', 'Yeþillikler ve çilek ile hazýrlanmýþ salata', 50, 10, 150, GETDATE(), NULL, 1, 1)
INSERT INTO Menu VALUES ('Su', 'Ýçecek', '500 ml', 0, 0, 15.5, GETDATE(), NULL, 1, 1)
INSERT INTO Menu VALUES ('Kola', 'Ýçecek', '330 ml', 150, 5, 45, GETDATE(), NULL, 1, 1)
GO


INSERT INTO MenuRecete (Adi, UrunAdi, Miktar, MiktarTipi, OlusturmaZamani, DuzenlemeZamani, Versiyon, Durumu)
VALUES
  ('Ýskender', 'Et', 300, 'Gram', GETDATE(), NULL, 1, 1),
  ('Pesto Soslu Makarna', 'Makarna', 200, 'Gram', GETDATE(), NULL, 1, 1),
  ('Kola', 'Kola', 150, 'Adet', GETDATE(), NULL, 1, 1),
  ('Mevsim Salata', 'Salata', 1, 'Adet', GETDATE(), NULL, 1, 1),
  ('Su', 'Su', 1, 'Adet', GETDATE(), NULL, 1, 1)
GO



/*
ALTER TABLE Calisanlar
ALTER COLUMN DuzenlemeZamani DATETIME --Düzenleme zamanýnda saattinde gözükmesi için 	


ALTER TABLE Menu
ALTER COLUMN DuzenlemeZamani DATETIME	


-- UPDATE

UPDATE Calisanlar
SET Adi='Sümeyye',
Soyadi='Coþkun',
DuzenlemeZamani=GETDATE()
WHERE Adi='Sumeyye' --id kullanmadýðýmýz için ad ile arama yaptým


UPDATE Menu
SET Fiyat=657,
DuzenlemeZamani=GETDATE()
WHERE Adi='Ýskender'


-- DELETE


DELETE FROM MenuRecete 
WHERE Adi = 'Su'


DELETE FROM Menu 
WHERE Fiyat < 50


--SELECT


SELECT Adi, Kalori, Fiyat
FROM Menu
WHERE Kalori<250 and ServisSuresi<10


-- ALTER


ALTER TABLE Calisanlar    --Maas kolonu ekleme calýsanlar tablosuna
ADD Maas DECIMAL(8,2)


UPDATE Calisanlar
SET Maas = CONVERT(DECIMAL, YEAR(DogumTarihi)) + 2500.50 --yeni eklenen maas kolonuna calýsanlarýn dogum yýlýna 2500.50tl ekleyerek güncelleme yaptým


ALTER TABLE Calisanlar
DROP COLUMN Maas


-- DROP

DROP TABLE Gorevler

DROP DATABASE RestoranDB
GO

-- RENAME

EXEC sp_rename 'MenuRecete', 'UrunRecete' 
GO

EXEC sp_rename 'Calisanlar.Maas', 'CalisanMaasi', 'COLUMN'
GO


*/