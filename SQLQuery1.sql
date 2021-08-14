﻿create database SuperVoice
go
use SuperVoice;

create table Contestants (
	id int primary key identity(1,1),
	name nvarchar(50),
	birthday date,
	university nvarchar(50),
	moreInfo text,
)

create table Examiners (
	id int primary key identity(1,1),
	name nvarchar(50),
	birthday date,
	moreInfo text,
)

create table Rounds (
	Id int primary key identity(1,1),
	name nvarchar(50),
	numberReserve int,
	numberOfficial int,
)

create table Results(
	id int primary key identity(1,1),
	contestantID int,
	examinerID int,
	roundID int,
	feedback text,
	score int check (score >= 0 AND score <=100),
	role nvarchar(50) --check (Role in ('official', 'reverse'))	
	foreign key (ContestantID) references Contestants(Id),
	foreign key (ExaminerID) references Examiners(Id),
	foreign key (RoundID) references Rounds(Id),
)
----------------------------------- INSERTION
-- Contestants
insert into Contestants(name,Birthday,University,moreInfo)
values
(N'Mike Hawk',N'1966/01/01',N'D.C University',N''),
(N'Hugh Dick',N'1966/01/02',N'D.C University',N''),
(N'Gary Nick',N'1966/01/03',N'D.C University',N''),
(N'Nick Kurt',N'1966/01/04',N'D.C University',N''),
(N'Kurt Cobain',N'1966/01/05',N'D.C University',N'')

-- Examiners
insert into Examiners(name,Birthday,moreInfo)
values
(N'Henry Lu',N'1990-01-02',N'1st Singer Award'),
(N'Jackie Chan',N'1950-05-08',N'Top 1 actor China'),
(N'Chen Long',N'1970-02-07',N'Best director in China')

-- Rounds
insert into Rounds(name,numberReserve,numberOfficial)
values
(N'Audition',32,6),
(N'2vs2',16,3),
(N'Semi Final',8,2),
(N'Final',4,1)

go
insert into Results(ContestantID,ExaminerID,RoundID,Role,Feedback,Score)
values
(1,1,1,N'',N'Good',10),
(1,2,1,N'',N'Good',10),
(1,3,1,N'',N'Good',10),
(2,1,1,N'',N'Pretty good',9),
(2,2,1,N'',N'Pretty good',9),
(2,3,1,N'',N'Pretty good',9),
(3,1,1,N'',N'Nice',10),
(3,2,1,N'',N'Nice',9),
(3,3,1,N'',N'Nice',10),
(4,1,1,N'',N'Good voice',9),
(4,2,1,N'',N'Good voice',10),
(4,3,1,N'',N'Nice',8),
(5,1,1,N'',N'Excellent',10),
(5,2,1,N'',N'Excellent',10),
(5,3,1,N'',N'Excellent',10)


----------------------------------- TRIGGER 
--create trigger tg_checkOfficialAndReverse 
--as 
--begin


--------------------------------- SELECT SECTION 
-- getListContestants
go
create procedure sp_getListContestants 
as 
begin
begin transaction
set transaction isolation level read committed
	select * from Contestants
	commit transaction;
end
-- EXEC
exec sp_getListContestants

-- getContestantsByRoundId
go
create procedure sp_getContestantsByRoundId @roundId int
as 
begin
begin transaction
set transaction isolation level read committed
	select c.Id, c.name, c.birthday, c.university, avg(r.score) as 'averageScore'
	from Contestants c
	join Results r on c.Id = r.ContestantID
	where r.RoundID = @roundId
	group by c.Id,c.name, c.birthday, c.university
	commit transaction;
end
-- EXEC
exec sp_getContestantsByRoundId 1

-- getListExaminers
go 
create procedure sp_getListExaminers
as
begin 
begin transaction
set transaction isolation level read committed
	select * from Examiners
	commit transaction;
end
-- EXEC
exec sp_getListExaminers 

-- getListRounds
go 
create procedure sp_getListRounds
as
begin 
begin transaction
set transaction isolation level read committed
	select * from Rounds
	commit transaction;
end

-- EXEC
exec sp_getListRounds




-- getResultByContestantId
--go 
--create procedure sp_getResultsByContestantId
--as
--begin
--begin transaction
--set transaction isolation level read committed

--end
-- 

----------------------------------- NOSELECT SECTION


use master
drop database SuperVoice