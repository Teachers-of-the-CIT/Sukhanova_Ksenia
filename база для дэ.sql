create database Perfumer
go

use Perfumer

create table Clients
(
Id	INT primary key identity,
[Role]	NVARCHAR (50) not null,
[Name]	NVARCHAR (100) not null,
Surname	NVARCHAR (100) not null,
MiddleName	NVARCHAR (100) not null,
[Login]	NVARCHAR (100) not null,
[Password]	NVARCHAR (100) not null
);

create table IssuePoint
(
Id	INT primary key identity,
Code	INT not null,
City	NVARCHAR (200) not null,
Street	NVARCHAR (200) not null,
House	INT not null,
);

create table [Orders]
(
Id	INT primary key identity,
Number	INT not null,
OrderDate	DATE not null,
DeliveryDate	DATE not null,
IssuePointId	INT not null,
ClientId	INT null,
OrderCode	INT not null,
[Status]	NVARCHAR (100) not null,

foreign key (IssuePointId) references IssuePoint (Id),
foreign key (ClientId) references Clients (Id)
);

create table ProductCategory
(
Id	INT primary key identity,
Name	NVARCHAR (MAX) not null
);

create table Products
(
Id	INT primary key identity,
Category	INT not null,
Sale	INT not null,
Count	INT not null,
Description	NVARCHAR (MAX) not null,
Image	NVARCHAR (MAX) null

foreign key (Category) references ProductCategory (Id)
);

create table OrderProduct
(
Id	INT primary key identity,
OrderId	INT not null,
ProductId	INT not null,
[Count]	INT not null,

foreign key (OrderId) references [Orders] (Id),
foreign key (ProductId) references Products (Id)
);
