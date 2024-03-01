create database SinemaBilet
go

use SinemaBilet
go


Create table Movie
(
	MovieID int primary key identity,
	MovieName nvarchar(50) not null,
	MovieDescription nvarchar(200),
	Duration tinyint not null
)
go


create table Categories	
(
	 CategoryID int primary key identity,
	 CategoryName nvarchar(15) not null,
)
go


create table Saloons
(
	SaloonID int primary key identity,
	SaloonName char(1) not null,
	SaloonCap tinyint not null,
	   	 
)
go


create table Sessions
(
	SessionID int primary key identity,
	SessionTime time not null,
)
go



create table MovieCategories
(
	MovieID int foreign key references Movie(MovieID),
	CategoryID  int foreign key references Categories(CategoryID),
)
go



create table BroadcastTime
(
	WeekCode varchar(3) unique not null,
	WeekFirstDay date not null,
	WeekLastDay date not null

)
go


create table SaloonSession
(
	SaloonSessionID int primary key identity,
	SaloonID int foreign key references Saloons(SaloonID),
	SessionID int foreign key references Sessions(SessionID),
	constraint UC_SaloonSession unique (SaloonID, SessionID)
	--constraint PK_SaloonSession primary key (SaloonID, SessionID)
)
go


create table Screenings
(
	MovieID int foreign key references Movie(MovieID),
	WeekCode varchar(3) foreign key references BroadcastTime(WeekCode),
	SaloonSessionID int foreign key references SaloonSession(SaloonSessionID)
	constraint PK_Screenings PRIMARY KEY (MovieID, WeekCode,SaloonSessionID),
	--constraint PK_Screenings PRIMARY KEY (MovieID, WeekCode, SaloonID, SessionID)
)






insert into Movie values
	('The Shawshank Redemption','Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.',142),
	('Back to the Future','Marty McFly, a 17-year-old high school student, is accidentally sent 30 years into the past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown.',114),
	('Forrest Gump','Forrest Gump, while not intelligent, has accidentally been present at many historic moments, but his true love, Jenny Curran, eludes him.',142),
	('Fight Club','An insomniac office worker, looking for a way to change his life, crosses paths with a devil-may-care soap maker, forming an underground fight club that evolves into something much, much more.',140),
	('The Lion King','Lion cub and future king Simba searches for his identity. His eagerness to please others and penchant for testing his boundaries sometimes gets him into trouble.',90)




--exec sp_rename 'Categories.Category','CategoryName','column'




insert into Categories values
	('Action'),('Sci-Fi'),('Crime'),('Adventure'),('Comedy'),('Drama'),('Animation'),('Fantasy')



insert into MovieCategories values
((select MovieID from Movie where MovieName='The Shawshank Redemption'),(select CategoryID from Categories where CategoryName='Drama'))


insert into MovieCategories values (1,3)





