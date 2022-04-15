Create database Library
use Library
Create table Books(
Id int Primary Key Identity,
[Name] nvarchar(15) not null,
AuthorId int references Authors(Id)
)
create table Authors (
Id int Primary Key Identity,
[Name] nvarchar(15) not null,
Surname nvarchar(15) not null
)
create table Genres (
Id int Primary Key Identity,
Genre nvarchar(15) not null
)
Create Table AuthorGenre(
Id int primary key Identity,
AuthorId int references Authors(Id),
GenreId int references Genres (Id)
)
Insert into Books values(1,'Hokmdar'),(2,'Sofinin dunyasi'),(3,'Narnia'),(4,'Twilight')
insert into Genres Values ('Comedy'),('Triller'),('Detective')
insert into AuthorGenre Values(1,1),(2,2),(3,3)
insert into Authors Values ('Zelimkhan Yaqub'),('Keramet Boyukcol'),('Semed Vurgun') 
Select * from AuthorGenre as ATG
join Authors as A on ATG.AuthorId = A.Id
join Genres as G on ATG.GenreId = G.Id
join Books as B on B.AuthorId = A.Id
