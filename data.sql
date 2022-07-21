CREATE DATABASE MANAGEMENT
GO 

USE MANAGEMENT
GO

CREATE TABLE MonthlyFunding
(
	MSSV INT PRIMARY KEY,
	funded BIT DEFAULT 0-- 0 | 1
)
GO

CREATE TABLE Account
(
	MSSV INT PRIMARY KEY,
	display_name NVARCHAR(20) NOT NULL UNIQUE,
	password NVARCHAR(500) NOT NULL,
	role NVARCHAR(10) NOT NULL DEFAULT N'user'

	FOREIGN KEY (MSSV) REFERENCES MonthlyFunding(MSSV)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
GO

CREATE TABLE SpecialFunding
(
	MSSV INT PRIMARY KEY,
	sum_money INT DEFAULT 0,
	time DATE

	FOREIGN KEY (MSSV) REFERENCES MonthlyFunding(MSSV)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
GO

CREATE TABLE Person
(
	MSSV INT NOT NULL, 
	first_name NVARCHAR(20) NOT NULL DEFAULT N'NULL',
	last_name NVARCHAR(50) NOT NULL DEFAULT N'NULL' ,
	email NVARCHAR(50) PRIMARY KEY,
	phone_number NVARCHAR(20) NOT NULL DEFAULT N'NULL'

	FOREIGN KEY (MSSV) REFERENCES Account(MSSV)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
GO

CREATE TABLE Announcement
(
	announcement_id INT PRIMARY KEY IDENTITY,
	Author_id INT,
	link NVARCHAR(500) DEFAULT N'NULL',
	time SMALLDATETIME,
	description NVARCHAR(200) DEFAULT N'NULL',
	type NVARCHAR(50) DEFAULT '*',

	FOREIGN KEY (Author_id) REFERENCES Account(MSSV)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1]
(
 @strInput NVARCHAR(4000)
)
RETURNS NVARCHAR(4000)
AS
BEGIN 
 IF @strInput IS NULL RETURN @strInput
 IF @strInput = '' RETURN @strInput
 DECLARE @RT NVARCHAR(4000)
 DECLARE @SIGN_CHARS NCHAR(136)
 DECLARE @UNSIGN_CHARS NCHAR (136)
 SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế
 ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý
 ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ
 ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'
 +NCHAR(272)+ NCHAR(208)
 SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee
 iiiiiooooooooooooooouuuuuuuuuuyyyyy
 AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII
 OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 DECLARE @COUNTER int
 DECLARE @COUNTER1 int
 SET @COUNTER = 1
 WHILE (@COUNTER <=LEN(@strInput))
 BEGIN 
 SET @COUNTER1 = 1
 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
 BEGIN
 IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1))
 = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
 BEGIN 
 IF @COUNTER=1
 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1)
 + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
 ELSE
 SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1)
 +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1)
 + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)
 BREAK
 END
 SET @COUNTER1 = @COUNTER1 +1
 END
 SET @COUNTER = @COUNTER +1
 END
 SET @strInput = replace(@strInput,' ','-')
 RETURN @strInput
END
GO

INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520033)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520093)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520110)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520117)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520006)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520012)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520029)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520063)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520064)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520069)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520085)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520373)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520378)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520436)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520474)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520142)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520239)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21522407)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21521845)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21522034)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21521109)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520150)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21520800)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21521821)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21522282)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21522883)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21521604)
INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(21521501)
GO

CREATE TABLE KHTN2021 
(
	id INT IDENTITY PRIMARY KEY,
	current_income INT DEFAULT 0,
	current_outcome INT DEFAULT 0, 
	num_months INT DEFAULT 0,
	charge INT,
	next_month_charge INT,
	current_month INT
)

INSERT INTO dbo.KHTN2021 (current_income, current_outcome, num_months, charge)
	VALUES (1620, 3960, 3, 20)
GO

INSERT INTO dbo.MonthlyFunding (MSSV) VALUES(00000000)
INSERT INTO dbo.SpecialFunding (MSSV, sum_money) VALUES(00000000, 2000)
INSERT INTO dbo.SpecialFunding (MSSV, sum_money) VALUES(21520033, 200)
INSERT INTO dbo.SpecialFunding (MSSV, sum_money) VALUES(21520093, 180)
INSERT INTO dbo.SpecialFunding (MSSV, sum_money) VALUES(21520117, 300)
INSERT INTO dbo.SpecialFunding (MSSV, sum_money) VALUES(21522034, 150)
INSERT INTO dbo.SpecialFunding (MSSV, sum_money) VALUES(21522407, 200)

INSERT INTO dbo.Announcement (Author_id, time, description, type) 
	VALUES ( 21520378 , '2022-07-17' , 'test' , 'test' )

UPDATE dbo.KHTN2021 SET current_month = 7 

INSERT INTO dbo.KHTN2021 (current_income, current_outcome, num_months, charge, next_month_charge, current_month)
	VALUES (1620, 3960, 3, 20, 20, 7)
