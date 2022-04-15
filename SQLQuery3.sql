Create database PG
use Pg
create table Worker(
Id int unique,
[Name] nvarchar(15) not null,
Surname nvarchar(15) not null,
duty nvarchar(15) not null,
salary money not null
)
create table Branch(
Id int unique,
[Name] nvarchar(15) not null,
WorkerCount int not null,
CreateTime DateTime default getdate()
)
create table Managers(
Id int unique,
[Name] nvarchar(15) not null,
Surname nvarchar(15) not null,
duty nvarchar(15) not null,
salary money not null
)
insert into Worker values(1,'Yusif','Azimov','Hacker',3000),(2,'Qurban','Ezim','Db Manager',2000),(3,'Sultan','Sultanov','Hacker',1000),(4,'Murad','Nese','Programmer',2500)
insert into Managers values(1,'Tehran','Mensimov','Hacker',10000),(2,'Tural huseynov','Ezim','Db Manager',7000),(3,'Qehreman','Nazarbayev','Masinist',1000)
Select * From Worker where salary < (Select avg(salary)  from Worker)
Select * From Managers where salary>(select avg(salary) from Worker)
insert into Worker values(1,'Azersu',89),(2,'Azerisiq',40),(3,'Azeriqaz',50),(4,'Komunal Yigaz',25)
Select * From Worker where BranchId =(select [Name] from Branch where Id  = 1)

alter table Worker
add BranchId int references Branch(Id)
