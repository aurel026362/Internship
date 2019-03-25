
--Create table Users(
--Id bigint identity(1,1) Primary key,
--FirstName nvarchar(20) Not Null,
--LastName nvarchar(20) Not Null,
--DateOfBirth SMALLDATETIME Not Null,
--NumberPhone nvarChar(15),
--[Login] varchar(20) Not Null,
--[Password] varchar(20) Not Null,
--EMail varchar(30) check (EMail like '%@%') Not Null
--);

--Create table Menthors(
--Id bigint identity(1,1) Primary Key,
--UserId bigint Foreign Key References Users(Id) Not Null UNIQUE,
--);

--CREATE TABLE GROUPS(
--Id bigint identity(1,1) Primary key,
--[Name] nvarchar(30),
--[StartDate] Date
--);

--Create table Interns(
--Id bigint identity(1,1) Primary key,
--GroupId bigint FOREIGN KEY REFERENCES Groups(Id) Not Null,
--UserId bigint Foreign Key References Users(Id) Not Null UNIQUE,
--MenthorId bigint Foreign Key References Menthors(Id) UNIQUE,
--);

--Create table Modules(
--Id bigint identity(1,1) Primary key,
--[Name] nvarchar(30) Not Null,
--StartDate SMALLDATETIME 
--);

--Create table Themes (
--Id bigint identity(1,1) Primary key, 
--[Name] nvarchar(40) Not Null,
--TimeOfTheme SMALLDATETIME,
--[Source] nvarchar(40),
--MenthorId bigint Foreign Key References Menthors(Id),
--ModuleId bigint Foreign Key References Modules(Id) Not Null
--);

--Create table ThemeMarks(
--Id bigint identity(1,1) Primary Key,
--ThemeId bigint Foreign Key References Themes(Id) Not Null,
--InternId bigint Foreign Key References Interns(Id) Not Null,
--Mark float check (Mark> 0 AND Mark <=10) Not Null
--);

--Create table Exams(
--[Id] bigint identity(1,1) Primary key,
--DateOfExamen SMALLDATETIME,
--ModuleId bigint Foreign Key References Modules(Id) NOT NULL UNIQUE
--);

--Create Table ExamMarks(
--Id bigint identity(1,1) Primary Key,
--ExamenId bigint Foreign Key References Exams(Id) Not Null,
--InternId bigint Foreign Key References Interns(Id) Not Null,
--Mark float check (Mark >0 AND Mark <=10)
--);

----CREATE TABLE Test(
----[Id] bigint identity(1,1) Primary Key
----);

----CREATE TABLE Test2(
----[Id] bigint identity(1,1) Primary Key
----);
GO
