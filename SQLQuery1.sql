Create database MusicPlayer
go 
use MusicPlayer;
 
-- Create table 
create table Songs (
	Id int primary key identity(1,1),
	name nvarchar(50),
	composer nvarchar(50) default 'Unknown',
	singer nvarchar(50) default 'Unknown',
	rdate date default current_timestamp,
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
(N'Việt nam'),(N'Âu Mỹ'),(N'Châu Á'), (N'Khác')
-- Categories
insert into Categories(name) values 
(N'Nhạc Trẻ'),
(N'Trữ Tình'), 
(N'Remix Việt'), 
(N'Rap Việt'), 
(N'Tiền Chiến'), 
(N'Nhạc Trịnh'), 
(N'Thiếu Nhi'), 
(N'Nhạc Xưa')
--Category Country
insert into CategoryCountry(CountryId,CategoryId) values 
(1,1), (1,2), (1,3), (1,4), (1,5), (1,6), (1,7), (1,8)

--Songs
insert into Songs(name,singer, rdate ,official,quality) values 
(N'Trong Túi Áo Anh', N'Khởi My', '12/1/2013'  ,0, 0 ),
(N'Em Thật Là Ngốc', N'Vũ Duy Khánh', '24/7/2021' , 0 ,0 ),
(N'Hơn Cả Trái Đất', N'Ánh Minh', '19/2/2021',1, 1)

--Users
insert into Users(username,password) values 
('admin', 'admin')

--UserFavourite
insert into UserFavourite(songId,userId) values
(1,1),
(2,1)

-- create function
-- create trigger


----------------------Create stored procedure--------------------------

-- Select Countries 
go
create procedure sp_getCountries 
as
begin
begin transaction
set transaction isolation level read committed 
	select * 
	from Countries
	commit transaction
end
----------EXEC
go
exec dbo.sp_getCountries

-- Select Category By CountryId
go
create procedure sp_getCategoryByCountryId @countryId int
as
begin
begin transaction
set transaction isolation level repeatable read
	select Id, name 
	from CategoryCountry cCountry
	join Categories c 
	on cCountry.CategoryId = c.Id
	where CountryId = @countryId
	commit transaction
end
----------EXEC
go
exec dbo.sp_getCategoryByCountryId 1


-- Select Newest Songs 
go
create procedure fn_getNewestSongs
as
begin
begin transaction
set transaction isolation level read committed
	select *
	from Songs
	where year(rdate) > year(CURRENT_TIMESTAMP)
	commit transaction
end

-- Select Hoest Songs
--go
--create procedure fn_getHotestSongs
--as
--begin
--begin transaction
--set transaction isolation level read committed
--	select top 50
--	from Songs
--	order by views
	
--	commit transaction
--end

-- Create



-- Query



-- Drop database
use master 
drop database MusicPlayer;