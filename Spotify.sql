create database Spotify
use Spotify
CREATE TABLE Artists (
	Id integer Primary Key Identity,
	[Name] nvarchar(100) not null,
	MonthlyListener NVARCHAR(100) NOT NULL
)
insert into Artists values('Eminem','52,669,719'),('Snopp Dogg','23,489,476'),('CamiliaCabello','47,033,111')
CREATE TABLE Alboms (
	Id int Primary Key Identity,
	[Name] nvarchar(100) not null,
	[Date] int not null,
	SongCount int not null,
)
insert into Alboms values('The Eminem Show',2002,13),('Kamikaze',2018,8),('Doggystyle',1993,15),('BODR',2022,6),('Familia',2022,11),('Cinderella',2021,11)

CREATE TABLE Musics ( 
	Id integer  Primary Key Identity,
	[Name] nvarchar(100) not null,
	TotalSecond nvarchar(100),
	ListenerCount int not null,
	AlbomsId int references Alboms(Id)

)
insert into Musics([Name],TotalSecond,ListenerCount,AlbomsId) values('White America','5.25',29900,1),('The Kiss','1.16',56000,1),('The Ringer','5.38',890000,2),
('Bathtub','1.50',30000,3),('Still Smokin','1.31',40000,4),('Celia','2.34',20000,5),('Shake ME','2.13',80000,6)

CREATE TABLE [ArtistToAlboms] (
	Id integer Primary Key Identity,
	ArtistsId int references Artists(Id),
	AlbomsId int references Alboms(Id)
)
insert into ArtistToAlboms Values(1,1),(1,2),(2,3),(2,4),(3,5),(3,6)
--Query1
CREATE VIEW scree_22
AS
Select Musics.[Name] as 'Music',Musics.TotalSecond as 'Total Second',Artists.[Name] as 'Mugenni',Alboms.[Name] as 'Albom'
from Musics
Join Alboms
on Musics.AlbomsId = Alboms.Id
Join ArtistToAlboms
on Alboms.Id =ArtistToAlboms.ArtistsId
Join Artists
on ArtistToAlboms.ArtistsId =Artists.Id
Create view screen
AS
Select Alboms.Name,Alboms.SongCount
from Alboms