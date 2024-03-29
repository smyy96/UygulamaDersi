create database IlacRecete
go

use IlacRecete
go


create table Bolumler
(
	BolumId int primary key identity(1,1),
	BolumAdi nvarchar(50) not null
)
go


create table Doktorlar
(
	DoktorId int primary key identity(1,1),
	SicilNo nvarchar(5) not null,
	DoktorAdi nvarchar(50) not null,
	DoktorSoyad nvarchar(50) not null,
	BolumId int foreign key references Bolumler(BolumId)
)
go

create table Ilaclar
(
	IlacId int primary key identity(1,1),
	IlacAdi nvarchar(25) not null,
)
go


create table Receteler
(
	ReceteId int primary key identity(1,1),
	ReceteNo nvarchar(5) not null,
	ReceteTarihi date,
	DoktorId int foreign key references Doktorlar(DoktorId)

)
go


create table IlacRecete
(
	IlacId int foreign key references Ilaclar(IlacId),
	ReceteId int foreign key references Receteler(ReceteId)
)
go


insert into Bolumler values 
				('Dahiliye')
				('�ocuk Hastal�klar�'),



insert into Doktorlar values 
				('123','Ali','Veli',1),
				('456','Ay�e','Fatma',2),
				('789','Hasan','H�seyin',1),
				('159','Mustafa','Mehmet',2)



insert into Ilaclar values 
				('Ila�1'),
				('Ila�2'),
				('Ila�3'),
				('Ila�4'),
				('Ila�5'),
				('Ila�6'),
				('Ila�10'),
				('Ila�11')


insert into Receteler values
				('R741', '1/2/1990',1),
				('R852', '10/20/1990',2),
				('R123', '11/11/1990',3),
				('R456', '11/11/1990',3),
				('R853', '12/20/1990',4),
				('R963', '6/6/1990',2)


insert into IlacRecete values 
				(1,1),
				(2,1),
				(3,6),
				(4,6),
				(5,2),
				(6,2),
				(3,3),
				(2,4),
				(4,4),
				(7,5),
				(8,5)



----- 1NF ------------

create view receteilaclar
as
(
	select r.ReceteNo,r.ReceteTarihi,r.DoktorId,i.IlacAdi from IlacRecete as ir
	inner join Receteler as r on r.ReceteId=ir.ReceteId
	inner join Ilaclar as i on ir.IlacId=i.IlacId
)

select d.DoktorAdi,d.DoktorSoyad,b.BolumAdi,d.SicilNo,rc.ReceteNo,rc.IlacAdi,rc.ReceteTarihi from Doktorlar as d
inner join Bolumler as b on d.BolumId= b.BolumId
inner join dbo.receteilaclar rc on d.DoktorId=rc.DoktorId

---------------------------------------


-------UDF-------------

select 
	d.DoktorAdi,
	d.DoktorSoyad,
	b.BolumAdi,
	d.SicilNo,
	r.ReceteNo,
	string_agg(cast(i.IlacAdi as nvarchar(50)), ', ') AS IlacAdi,
	r.ReceteTarihi 
	
from Doktorlar as d
inner join Bolumler as b on d.BolumId= b.BolumId
inner join Receteler r on d.DoktorId=r.DoktorId
inner join IlacRecete ir on ir.ReceteId=r.ReceteId
inner join Ilaclar as i on i.IlacId=ir.IlacId
group by d.DoktorAdi,d.DoktorSoyad,b.BolumAdi,d.SicilNo,r.ReceteNo,r.ReceteTarihi





