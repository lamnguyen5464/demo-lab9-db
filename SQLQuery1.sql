Create database MusicPlayer
go 
use MusicPlayer;
 
-- Create table 
create table Songs (
	Id int primary key identity(1,1),
	name nvarchar(50),
	composer nvarchar(50) default 'Unknown',
	singer nvarchar(50) default 'Unknown',
	views int default 0,
	official bit,
	quality bit
)

create table Categories (
	Id int primary key identity(1,1),
	name nvarchar(50),
)

create table SongCategory (
	SongId int ,
	CategoryId int,
	primary key (SongId, CategoryId),
	foreign key(CategoryId) references Categories(Id),
	foreign key(SongId) references Songs(Id),
)

create table Countries (
	Id int primary key identity(1,1),
	name nvarchar(50),
)

create table CategoryCountry (
	CountryId int,
	CategoryId int,
	primary key (CategoryId , CountryId),
	foreign key(CategoryId) references Categories(Id),
	foreign key(CountryId) references Countries(Id),
)

create table Users (
	Id int primary key identity(1,1),
	username varchar(50),
	password varchar(50),
)

create table UserFavourite (
	songId int,
	userId int,
	primary key (songId, userId),
	foreign key(songId) references Songs(Id),
	foreign key(userId) references Users(Id),
)
-- insert data

-- Countries
insert into Countries(name) values 
('Viet nam'),( 'Âu Mỹ'),( 'Châu Á'), ('Khác')
-- Categories
insert into Categories(name) values 
('Nhạc Trẻ'),
('Trữ Tình'), 
('Remix Việt'), 
('Rap Việt'), 
('Tiền Chiến'), 
('Nhạc Trịnh'), 
('Thiếu Nhi'), 
('Nhạc Xưa')
--Category Country
insert into CategoryCountry(CountryId,CategoryId) values 
(1,1), (1,2), (1,3), (1,4), (1,5), (1,6), (1,7), (1,8)

--Songs
insert into Songs(name,singer,official,quality) values 
('Trong Túi Áo Anh', 'Khởi My', 0, 0 ),
('Em Thật Là Ngốc', 'Vũ Duy Khánh', 0 ,0 ),
('Hơn Cả Trái Đất', 'Ánh Minh', 1, 1)

--Users
insert into Users(username,password) values 
('admin', 'admin')

--UserFavourite
insert into UserFavourite(songId,userId) values
(1,1),
(2,1)

-- create function


-- create trigger


-- create stored procedure




--use master 
--drop database MusicPlayer;