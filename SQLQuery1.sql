create database CS486_Team13_DB
go
use CS486_Team13_DB;

create table Contestants (
	id int primary key identity(1,1),
	name nvarchar(50),
	birthday date,
	university nvarchar(50),
	moreInfo nvarchar(200),
)

create table Examiners (
	id int primary key identity(1,1),
	name nvarchar(50),
	birthday date,
	moreInfo nvarchar(200),
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
(N'Mike Hawk',N'1966-01-01',N'D.C University',N''),
(N'Hugh Dick',N'1966-01-02',N'D.C University',N''),
(N'Gary Nick',N'1966-01-03',N'D.C University',N''),
(N'Nick Kurt',N'1966-01-04',N'D.C University',N''),
(N'Kurt Cobain',N'1966-01-05',N'D.C University',N''),
(N'Samuel Jason',N'1987-12-31',N'South Korea University',N''),
(N'Michael Jorgan',N'1988-01-01',N'South Korea University',N''),
(N'Timmy Brown',N'1988-01-02',N'South Korea University',N''),
(N'Adolf Watzel',N'1988-01-03',N'South Korea University',N''),
(N'Watson Misha',N'1988-01-04',N'South Korea University',N''),
(N'Ivan Michinov',N'1988-01-05',N'South Korea University',N''),
(N'Emily Quethas',N'1954-03-25',N'Harvard University',N''),
(N'Jackson Chan',N'1954-03-26',N'Harvard University',N''),
(N'Velma Krill',N'1954-03-27',N'Harvard University',N''),
(N'Scooby Doo',N'1954-03-28',N'Harvard University',N''),
(N'Phuc Yu',N'2002-03-31',N'Harvard University',N''),
(N'Dat Bich',N'2002-04-01',N'Harvard University',N''),
(N'Phat At',N'2002-04-02',N'Harvard University',N''),
(N'Jin Jau',N'2002-04-03',N'Harvard University',N''),
(N'Nathan Kilm',N'2002-04-04',N'Harvard University',N''),
(N'Dallas Muck',N'2002-04-05',N'Harvard University',N''),
(N'Gate Mire',N'1998-02-28',N'Riverdale University',N''),
(N'Konrad Hart',N'1998-03-01',N'Riverdale University',N''),
(N'Watashi Baka',N'1998-03-02',N'Riverdale University',N''),
(N'Tony Star',N'1998-03-03',N'Riverdale University',N''),
(N'Kernel Cornface',N'1998-03-04',N'Riverdale University',N''),
(N'Masuri Yabai',N'1998-03-05',N'Riverdale University',N''),
(N'Canola Oil',N'1998-03-06',N'Riverdale University',N''),
(N'Bacon Choco',N'1998-03-07',N'Riverdale University',N''),
(N'Banana Frim',N'1998-03-08',N'Riverdale University',N''),
(N'Coco Nico',N'1998-03-09',N'Riverdale University',N''),
(N'David Whittaker',N'1998-03-10',N'Riverdale University',N''),
(N'Caryn Jake',N'1944-08-30',N'Riverdale University',N''),
(N'Pik Lik',N'1944-08-31',N'Riverdale University',N''),
(N'Lakey Pikey',N'1944-09-01',N'Riverdale University',N''),
(N'Harvey Dent',N'1944-09-02',N'Riverdale University',N''),
(N'Bruce Wayne',N'1944-09-03',N'Riverdale University',N''),
(N'Clark Kent',N'1944-09-04',N'Riverdale University',N'')

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

insert into Results(ContestantID,ExaminerID,RoundID,Role,Feedback,Score)
values
(1,1,1,N'apprentice',N'Good',10),      
(1,2,1,N'apprentice',N'Good',10),      
(1,3,1,N'apprentice',N'Good',10),      
(2,1,1,N'apprentice',N'Pretty good',9),
(2,2,1,N'apprentice',N'Pretty good',9),
(2,3,1,N'apprentice',N'Pretty good',9),
(3,1,1,N'apprentice',N'Nice',10),      
(3,2,1,N'apprentice',N'Nice',9),       
(3,3,1,N'apprentice',N'Nice',10),      
(4,1,1,N'apprentice',N'Good voice',9), 
(4,2,1,N'apprentice',N'Good voice',10),
(4,3,1,N'apprentice',N'Nice',8),       
(5,1,1,N'apprentice',N'Excellent',10), 
(5,2,1,N'apprentice',N'Excellent',10), 
(5,3,1,N'apprentice',N'Excellent',10), 
(6,1,1,N'apprentice',N'Nice',9),       
(6,2,1,N'apprentice',N'Good',9),       
(6,3,1,N'apprentice',N'Pretty good',9),
(7,1,1,N'Covers',N'Good expression',8),
(7,2,1,N'Covers',N'Good expression',8),
(7,3,1,N'Covers',N'Nice',8),
(8,1,1,N'Covers',N'Good voice',8),     
(8,2,1,N'Covers',N'Nice',8),
(8,3,1,N'Covers',N'Good',8),
(9,1,1,N'Covers',N'Has potential but too rough',5),
(9,2,1,N'Covers',N'Not my cup of tea but not too bad',5),
(9,3,1,N'Covers',N'Need more training',5),
(10,1,1,N'Covers',N'Has potential but too rough',6),
(10,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(10,3,1,N'Covers',N'Need more training',6),
(11,1,1,N'Covers',N'Has potential but too rough',6),
(11,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(11,3,1,N'Covers',N'Need more training',6),
(12,1,1,N'Covers',N'Has potential but too rough',6),
(12,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(12,3,1,N'Covers',N'Need more training',6),
(13,1,1,N'Covers',N'Has potential but too rough',6),
(13,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(13,3,1,N'Covers',N'Need more training',6),
(14,1,1,N'Covers',N'Has potential but too rough',6),
(14,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(14,3,1,N'Covers',N'Need more training',6),
(15,1,1,N'Covers',N'Has potential but too rough',6),
(15,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(15,3,1,N'Covers',N'Need more training',6),
(16,1,1,N'Covers',N'Has potential but too rough',6),
(16,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(16,3,1,N'Covers',N'Need more training',6),
(17,1,1,N'Covers',N'Has potential but too rough',6),
(17,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(17,3,1,N'Covers',N'Need more training',6),
(18,1,1,N'Covers',N'Has potential but too rough',6),
(18,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(18,3,1,N'Covers',N'Need more training',6),
(19,1,1,N'Covers',N'Has potential but too rough',6),
(19,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(19,3,1,N'Covers',N'Need more training',6),
(20,1,1,N'Covers',N'Has potential but too rough',6),
(20,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(20,3,1,N'Covers',N'Need more training',6),
(21,1,1,N'Covers',N'Has potential but too rough',6),
(21,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(21,3,1,N'Covers',N'Need more training',6),
(22,1,1,N'Covers',N'Has potential but too rough',6),
(22,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(22,3,1,N'Covers',N'Need more training',6),
(23,1,1,N'Covers',N'Has potential but too rough',6),
(23,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(23,3,1,N'Covers',N'Need more training',6),
(24,1,1,N'Covers',N'Has potential but too rough',6),
(24,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(24,3,1,N'Covers',N'Need more training',6),
(25,1,1,N'Covers',N'Has potential but too rough',6),
(25,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(25,3,1,N'Covers',N'Need more training',6),
(26,1,1,N'Covers',N'Has potential but too rough',6),
(26,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(26,3,1,N'Covers',N'Need more training',6),
(27,1,1,N'Covers',N'Has potential but too rough',6),
(27,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(27,3,1,N'Covers',N'Need more training',6),
(28,1,1,N'Covers',N'Has potential but too rough',6),
(28,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(28,3,1,N'Covers',N'Need more training',6),
(29,1,1,N'Covers',N'Has potential but too rough',6),
(29,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(29,3,1,N'Covers',N'Need more training',6),
(30,1,1,N'Covers',N'Has potential but too rough',6),
(30,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(30,3,1,N'Covers',N'Need more training',6),
(31,1,1,N'Covers',N'Has potential but too rough',6),
(31,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(31,3,1,N'Covers',N'Need more training',6),
(32,1,1,N'Covers',N'Has potential but too rough',6),
(32,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(32,3,1,N'Covers',N'Need more training',6),
(33,1,1,N'Covers',N'Has potential but too rough',6),
(33,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(33,3,1,N'Covers',N'Need more training',6),
(34,1,1,N'Covers',N'Has potential but too rough',6),
(34,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(34,3,1,N'Covers',N'Need more training',6),
(35,1,1,N'Covers',N'Has potential but too rough',6),
(35,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(35,3,1,N'Covers',N'Need more training',6),
(36,1,1,N'Covers',N'Has potential but too rough',6),
(36,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(36,3,1,N'Covers',N'Need more training',6),
(37,1,1,N'Covers',N'Has potential but too rough',6),
(37,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(37,3,1,N'Covers',N'Need more training',6),
(38,1,1,N'Covers',N'Has potential but too rough',6),
(38,2,1,N'Covers',N'Not my cup of tea but not too bad',6),
(38,3,1,N'Covers',N'Need more training',6),
(1,1,2,N'apprentice',N'my ears are not wrong',10),
(1,2,2,N'apprentice',N'Keep it going',10),
(1,3,2,N'apprentice',N'You did not disappoint me',10),
(2,1,2,N'apprentice',N'Please do it better next time',9),
(2,2,2,N'apprentice',N'You are drowsy on the throne',9),
(2,3,2,N'apprentice',N'You did not improve much',9),
(3,1,2,N'apprentice',N'You are a bit sloppy',8),
(3,2,2,N'apprentice',N'I think you need more practice',8),
(3,3,2,N'apprentice',N'You are in danger zone',8),
(4,1,2,N'Covers',N'This is not going well for you',7),
(4,2,2,N'Covers',N'I do not see your improvement',5),
(4,3,2,N'Covers',N'You can do better than this',7),
(5,1,2,N'Covers',N'This is not going well for you',5),
(5,2,2,N'Covers',N'I do not see your improvement',7),
(5,3,2,N'Covers',N'You can do better than this',7),
(6,1,2,N'Covers',N'This is not going well for you',5),
(6,2,2,N'Covers',N'I do not see your improvement',5),
(6,3,2,N'Covers',N'You can do better than this',5),
(7,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',5),
(7,2,2,N'Covers',N'Get help',5),
(7,3,2,N'Covers',N'You are done',5),
(8,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',5),
(8,2,2,N'Covers',N'Get help',5),
(8,3,2,N'Covers',N'You are done',5),
(38,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',5),
(38,2,2,N'Covers',N'Get help',5),
(38,3,2,N'Covers',N'You are done',5),
(10,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',5),
(10,2,2,N'Covers',N'Get help',5),
(10,3,2,N'Covers',N'You are done',5),
(11,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',5),
(11,2,2,N'Covers',N'Get help',5),
(11,3,2,N'Covers',N'You are done',5),
(12,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',6),
(12,2,2,N'Covers',N'Get help',6),
(12,3,2,N'Covers',N'You are done',6),
(13,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',7),
(13,2,2,N'Covers',N'Get help',6),
(13,3,2,N'Covers',N'You are done',6),
(14,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',5),
(14,2,2,N'Covers',N'Get help',8),
(14,3,2,N'Covers',N'You are done',5),
(15,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',9),
(15,2,2,N'Covers',N'Get help',7),
(15,3,2,N'Covers',N'You are done',5),
(16,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',4),
(16,2,2,N'Covers',N'Get help',7),
(16,3,2,N'Covers',N'You are done',8),
(17,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',7),
(17,2,2,N'Covers',N'Get help',5),
(17,3,2,N'Covers',N'You are done',7),
(18,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',5),
(18,2,2,N'Covers',N'Get help',8),
(18,3,2,N'Covers',N'You are done',7),
(19,1,2,N'Covers',N'You are going to get eliminated if you keep on like this',5),
(19,2,2,N'Covers',N'Get help',5),
(19,3,2,N'Covers',N'You are done',5),
(1,1,3,N'apprentice',N'Keep it going',10),
(1,2,3,N'apprentice',N'do not stop improving',10),
(1,3,3,N'apprentice',N'You might be the winner',10),
(2,1,3,N'apprentice',N'You are catching up',9),
(2,2,3,N'apprentice',N'Just bit more',9),
(2,3,3,N'apprentice',N'I believe in you',9),
(3,1,3,N'Covers',N'You are in danger',8),
(3,2,3,N'Covers',N'I do not think you can win this',8),
(3,3,3,N'Covers',N'This is bland',8),
(4,1,3,N'Covers',N'This is not going well for you',7),
(4,2,3,N'Covers',N'I do not see your improvement',5),
(4,3,3,N'Covers',N'You can do better than this',7),
(5,1,3,N'Covers',N'This is not going well for you',6),
(5,2,3,N'Covers',N'I do not see your improvement',5),
(5,3,3,N'Covers',N'You can do better than this',5),
(6,1,3,N'Covers',N'I do not think you can move on',4),
(6,2,3,N'Covers',N'I see a bit of hope',6),
(6,3,3,N'Covers',N'Come back next year',4),
(7,1,3,N'Covers',N'This is not okay',3),
(7,2,3,N'Covers',N'Pack your belongings and get out',3),
(7,3,3,N'Covers',N'I rather hear a cow mooing',3),
(8,1,3,N'Covers',N'Okay',6),
(8,2,3,N'Covers',N'I can see room of improvement',8),
(8,3,3,N'Covers',N'Keep trying',7),
(15,1,3,N'Covers',N'You are going to get eliminated if you keep on like this',6),
(15,2,3,N'Covers',N'Get help',6),
(15,3,3,N'Covers',N'You are done',6),
(19,1,3,N'Covers',N'You are rising up',8),
(19,2,3,N'Covers',N'You can win but not enough',7),
(19,3,3,N'Covers',N'I disagree with the others two',6),
(1,1,4,N'apprentice',N'I knew it',10),
(1,2,4,N'apprentice',N'Congratulation',10),
(1,3,4,N'apprentice',N'You are the winner',10),
(2,1,4,N'Covers',N'Better luck next time',9),
(2,2,4,N'Covers',N'Better luck next time',9),
(2,3,4,N'Covers',N'Better luck next time',9),
(3,1,4,N'Covers',N'Better luck next time',8),
(3,2,4,N'Covers',N'Better luck next time',8),
(3,3,4,N'Covers',N'Better luck next time',8),
(4,1,4,N'Covers',N'Better luck next time',7),
(4,2,4,N'Covers',N'Better luck next time',5),
(4,3,4,N'Covers',N'Better luck next time',7)


----------------------------------- TRIGGER 
go
CREATE TRIGGER trg_Results_Score
ON Results
FOR INSERT, UPDATE
AS
	BEGIN
	IF EXISTS(SELECT * FROM Results WHERE score < 0 OR score > 100)
	THROW 50000, 'Score must greater than 0', 1
	END

GO
CREATE TRIGGER trg_Rounds
ON Rounds
FOR INSERT, UPDATE
AS
	BEGIN
	IF EXISTS(SELECT * FROM Rounds WHERE numberOfficial < 0 OR numberReserve < 0)
	THROW 50000, 'Number of constestants must greater than 0', 1
	END

GO
CREATE TRIGGER trg_Rounds_numberContestants
ON Rounds
FOR INSERT, UPDATE
AS
	BEGIN
	IF EXISTS(SELECT * FROM Rounds WHERE numberOfficial > numberReserve)
	THROW 50000, 'Number of members of official group must less than number of members of reserve group', 1
	END
	GO
create trigger trg_illegal_contestants
on Contestants
FOR INSERT, UPDATE
AS
begin
  if exists(select birthday from Contestants where birthday>CURRENT_TIMESTAMP )
  begin
    THROW 50001, 'This person has not born yet', 1;
  end
end
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
--exec sp_getListContestants

-- getContestantsByRoundId
go
create procedure sp_getContestantsByRoundId @roundId int
as 
begin
begin transaction
set transaction isolation level read committed
	select c.Id, c.name, c.birthday, c.university,c.moreInfo,r.role as 'role', avg(r.score) as 'averageScore'
	from Contestants c
	join Results r on c.Id = r.ContestantID
	where r.RoundID = @roundId
	group by c.Id,c.name, c.birthday, c.university,c.moreInfo, r.role
	order by avg(r.score) desc
	commit transaction;
end
-- EXEC
--exec sp_getContestantsByRoundId 1

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
--exec sp_getListExaminers 

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
--exec sp_getListRounds




----------------------------------- NOSELECT SECTION


--use master
--drop database CS486_Team13_DB;
