Create DataBase MyDataBase;

use MyDataBase;

Create table Users(
Id bigint identity(1,1) Primary key,
FirstName nvarchar(20) Not Null,
LastName nvarchar(20) Not Null,
DateOfBirth SMALLDATETIME Not Null,
NumberPhone nvarChar(15),
[Login] varchar(20) Not Null,
[Password] varchar(20) Not Null,
EMail varchar(30) check (EMail like '%@%') Not Null
);

Create table Menthors(
UserId bigint Primary Key Foreign Key References Users(Id) Not Null,
);

Create table Interns(
UserId bigint Primary key Foreign Key References Users(Id) Not Null,
MenthorId bigint Foreign Key References Menthors(UserId) Not Null UNIQUE,
);

Create table Modules(
Id bigint identity(1,1) Primary key,
NameModule nvarchar(30) Not Null,
StartDate SMALLDATETIME 
);

Create table Themes (
Id bigint identity(1,1) Primary key, 
[Name] nvarchar(40) Not Null,
TimeOfTheme SMALLDATETIME,
[Source] nvarchar(40),
MenthorId bigint Foreign Key References Menthors(UserId),
ModuleId bigint Foreign Key References Modules(Id) Not Null
);

Create table ThemeMarks(
Id bigint identity(1,1) Primary Key,
ThemeId bigint Foreign Key References Themes(Id) Not Null,
InternId bigint Foreign Key References Interns(UserId) Not Null,
Mark float check (Mark> 0 AND Mark <=10) Not Null
);

Create table Exams(
[Id] bigint identity(1,1) Primary key,
DateOfExamen SMALLDATETIME,
ModuleId bigint Foreign Key References Modules(Id) NOT NULL UNIQUE
);

Create Table ExamMarks(
Id bigint identity(1,1) Primary Key,
ExamenId bigint Foreign Key References Exams(Id) Not Null,
InternId bigint Foreign Key References Interns(UserId) Not Null,
Mark float check (Mark >0 AND Mark <=10)
);